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

        string path = "";
        string entryHumanString = "You have entered ";
        string entryAbsoluteString = "Entering area ";

        int entryHumanStringLen;
        int entryAbsoluteStringLen;

        long lastReadLength;
        FileStream fs;
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        public Form1()
        {
            DialogResult folder = fbd.ShowDialog();
            OpenFileDialog file = new OpenFileDialog();


            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;

                fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                lastReadLength = fs.Length;

                entryHumanStringLen = entryHumanString.Length;
                entryAbsoluteStringLen = entryAbsoluteString.Length;

                InitializeComponent();

                // Call this procedure when the application starts.  
                // Set to 1 second.  
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_tick);

                // Enable timer. 
                timer1.Enabled = true;
            }
            
        }

        private void timer1_tick(object sender, System.EventArgs e)
        {
            
            fs.Seek(lastReadLength, SeekOrigin.Begin);

            // read 1024 bytes
            byte[] bytes = new byte[1024];
            var bytesRead = fs.Read(bytes, 0, 1024);
            lastReadLength += bytesRead; //TODO, what if this splits the string?

            // Convert bytes to string
            string s = Encoding.Default.GetString(bytes);

            parseLogSnippet(s);
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
                    human.Text = humanName;
                }
                int indexAbs = line.IndexOf(entryAbsoluteString);
                if (indexAbs != -1)
                {
                    areaName = line.Substring(indexAbs + entryAbsoluteStringLen);
                    absolute.Text = areaName;
                    displayMap(areaName, humanName);
                }
            }

            

            //textBox.Text = area;
        }

        private void displayMap(string areaName, string humanName)
        {
            string mapFolder = makeStringLegal(fbd.SelectedPath.ToString() + @"\" + areaName);

            if (Directory.Exists(mapFolder))
            {
                try
                {
                    
                    richTextBox1.Text = "";
                    string[] files = Directory.GetFiles(mapFolder);

                    tableLayoutPanel1.Controls.Clear();

                    tableLayoutPanel1.ColumnCount = 1;
                    tableLayoutPanel1.RowCount = 1;

                    if (files.Length > 0)
                    {

                        int columns = (int)Math.Ceiling(Math.Sqrt(files.Length));
                        int rows = columns;
                        if ((rows - 1) * columns >= files.Length) { rows--; }
                        if (rows == 0) { rows = 1; }

                        richTextBox2.Text = columns + ":" + rows;

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
                }
                catch (Exception e)
                {
                    richTextBox1.Text = e.ToString();
                    richTextBox1.Text += "\n" + mapFolder;
                }
            }
            else
            {
                using (StreamWriter outputFile = new StreamWriter(fbd.SelectedPath + "\\nameMap.txt", true))
                {
                    outputFile.WriteLine(areaName + " " + humanName);
                }
                Directory.CreateDirectory(mapFolder);
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

        private void human_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
