using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
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

        int yourLevel = 6;
        int mapLevel = 8;

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

            var yourLevels = new List<int>();
            var mapLevels = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                yourLevels.Add(i);
                mapLevels.Add(i);
            }

            mapLevelBox.DataSource = mapLevels;
            mapLevelBox.SelectedIndex = mapLevel;
            yourLevelBox.DataSource = yourLevels;
            yourLevelBox.SelectedIndex = yourLevel;

            // make it readonly
            yourLevelBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mapLevelBox.DropDownStyle = ComboBoxStyle.DropDownList;

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

        private void yourLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            yourLevel = yourLevelBox.SelectedIndex;
            redrawLevelTable();
        }

        private void mapLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapLevel = mapLevelBox.SelectedIndex;
            redrawLevelTable();
        }

        private void redrawLevelTable()
        {
            levelTable.Controls.Clear();

            levelTable.ColumnCount = 2;
            levelTable.RowCount = 11;

            int safeZone = (int)Math.Floor((double)(3 + (yourLevel / 16)));

            for (int r = 0; r < 100; r++)
            {
                TextBox tableLevel = new TextBox();
                tableLevel.Dock = DockStyle.Fill;
                int monsterLevel = r + 1;
                tableLevel.Text = (monsterLevel).ToString();

                TextBox xpMultiBox = new TextBox();
                xpMultiBox.Dock = DockStyle.Fill;

                int effectiveDiff = Math.Abs(yourLevel - monsterLevel) - safeZone;
                if (effectiveDiff < 0) effectiveDiff = 0;
                double xpMult = Math.Pow(((yourLevel + 5) / (yourLevel + 5 + Math.Pow(effectiveDiff, 2.5))), 1.5)*100;
                xpMultiBox.Text = Math.Round(xpMult, 2).ToString()+"%";

                if (xpMult > 20) {
                    levelTable.Controls.Add(tableLevel, 0, r);
                    levelTable.Controls.Add(xpMultiBox, 1, r);
                }
            }

            //levelTable.Controls.Add(ltb, 0, 0);
            //levelTable.Controls.Add(mtb, 1, 0);
    
        }

        //copied from https://msdn.microsoft.com/en-us/library/ms404263.aspx
        //https://refactorsaurusrex.com/post/2015/how-to-host-a-clickonce-installer-on-github/
        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.",
                            "Update Available", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("The application has been upgraded, and will now restart.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. Error: " + dde);
                            return;
                        }
                    }
                }
            }
        }
    }
}
