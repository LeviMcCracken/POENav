using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nav
{
    public partial class Form1 : Form
    {

        string logfileStr = "";
        string entryHumanString = "You have entered ";
        string entryAbsoluteString = "Entering area ";
        int entryHumanStringLen;
        int entryAbsoluteStringLen;
        string mapFolder = "";

        long lastReadLength;
        FileStream logFileStream;

        public Form1()
        {
            InitializeComponent();
            
            entryHumanStringLen = entryHumanString.Length;
            entryAbsoluteStringLen = entryAbsoluteString.Length;

            logfileStr = Properties.Settings.Default.logFile;
            mapFolder = Properties.Settings.Default.mapFolder;
            
            mapFolderLoc.Text = "Map folder Location: " + mapFolder;
            logFileLoc.Text = "Log file Location: " + logfileStr;

            // Set to 1 second.  
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_tick);

            // Enable timer. 
            timer1.Enabled = true;

        }

        private void timer1_tick(object sender, System.EventArgs e)
        {
            if (logFileStream != null) {
                logFileStream.Seek(lastReadLength, SeekOrigin.Begin);

                // read 1024 bytes
                byte[] bytes = new byte[1024];
                var bytesRead = logFileStream.Read(bytes, 0, 1024);
                lastReadLength += bytesRead; //TODO, what if this splits the string?

                // Convert bytes to string
                string s = Encoding.Default.GetString(bytes);

                parseLogSnippet(s);
            }else if(logfileStr != ""){
                logFileStream = File.Open(logfileStr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                lastReadLength = logFileStream.Length;
            }
        }

        private void parseLogSnippet(string s)
        {
            string[] lines = s.Split('\n');
            string areaName = "";
            string humanName = "";
            foreach (string line in lines)
            {
                int index = line.IndexOf(entryHumanString);
                if (index != -1)
                {
                    humanName = line.Substring(index + entryHumanStringLen).Replace(" ", "").Replace("'", "").Replace(".", "");
                }
                int indexAbs = line.IndexOf(entryAbsoluteString);
                if (indexAbs != -1)
                {
                    areaName = line.Substring(indexAbs + entryAbsoluteStringLen);
                    absolute.Text = areaName;
                    displayMap(areaName, humanName);
                }
            }
        }

        private void displayMap(string areaName, string humanName)
        {
            string localMapFolder = makeStringLegal(mapFolder + @"\" + areaName);

            if (Directory.Exists(localMapFolder))
            {
                try
                {
                    
                    richTextBox1.Text = "";
                    string[] files = Directory.GetFiles(localMapFolder);

                    tableLayoutPanel1.Controls.Clear();

                    tableLayoutPanel1.ColumnCount = 1;
                    tableLayoutPanel1.RowCount = 1;

                    if (files.Length > 0)
                    {

                        int columns = (int)Math.Ceiling(Math.Sqrt(files.Length));
                        int rows = columns;
                        if ((rows - 1) * columns >= files.Length) { rows--; }
                        if (rows == 0) { rows = 1; }

                        tableLayoutPanel1.ColumnCount = columns;
                        tableLayoutPanel1.RowCount = rows;


                        int i = 0;
                        foreach (string file in files)
                        {
                            richTextBox1.Text += file.ToString() + "\n";
                            PictureBox pb = new PictureBox();
                            pb.ImageLocation = file;
                            pb.SizeMode = PictureBoxSizeMode.Zoom;
                            pb.Dock = DockStyle.Fill;

                            tableLayoutPanel1.Controls.Add(pb, i % columns, i / columns);
                            i++;
                        }

                    }
                    else
                    {
                        richTextBox1.Text += "No Maps Found For This Area" + "\n";
                        richTextBox1.Text += mapFolder + @"\NoMapFound.png";
                        PictureBox pb = new PictureBox();
                        pb.ImageLocation = mapFolder + @"\NoMapFound.png";
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Dock = DockStyle.Fill;

                        tableLayoutPanel1.Controls.Add(pb, 0, 0);
                    }
                }
                catch (Exception e)
                {
                    richTextBox1.Text = e.ToString();
                    richTextBox1.Text += "\n" + localMapFolder;
                }
            }
            else
            {
                using (StreamWriter outputFile = new StreamWriter(mapFolder + "\\nameMap.txt", true))
                {
                    outputFile.WriteLine(areaName + " " + humanName);
                }
                Directory.CreateDirectory(localMapFolder);
            }
        }

        private string makeStringLegal(string s)
        {
            string invalid = new string(Path.GetInvalidPathChars());
            
            foreach (char c in invalid)
            {
                s = s.Replace(c.ToString(), "");
            }

            return s;
        }
        
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logFileLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                logfileStr = file.FileName;

                logFileStream = File.Open(logfileStr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                lastReadLength = logFileStream.Length;

                logFileLoc.Text = "Log file Location: " + logfileStr;

                Properties.Settings.Default["logFile"] = logfileStr;
                Properties.Settings.Default.Save();
            }
        }

        private void mapFolderLoc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult folder = fbd.ShowDialog();
            mapFolder = makeStringLegal(fbd.SelectedPath.ToString());

            mapFolderLoc.Text = "Map folder Location: " + mapFolder;

            Properties.Settings.Default["mapFolder"] = mapFolder;
            Properties.Settings.Default.Save();
        }
    }
}
