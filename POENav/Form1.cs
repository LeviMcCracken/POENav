//#define INITTREE
#define ZONELEVELINIT

using Microsoft.VisualBasic.FileIO;
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
    public partial class POENavForm : Form
    {

        string logfileStr = "";
        string entryHumanString = "You have entered ";
        string entryAbsoluteString = "Entering area ";

        string mapFolderDispText = "Map folder Location: ";
        string logFileDispText = "Log file Location: ";
        string areaName = "";
        string characterName = "";
        int entryHumanStringLen;
        int entryAbsoluteStringLen;
        string mapFolder = "";
        int rowHighlight = 0;
        int yourLevel = 0;
        int mapLevel = 0;
        List<Tuple<string, int>> areaLevels;
        bool mapFolderInit = false;

        long lastReadLength;
        FileStream logFileStream;

        public POENavForm()
        {
            InitializeComponent();

            areaLevels = new List<Tuple<string, int>>();

            entryHumanStringLen = entryHumanString.Length;
            entryAbsoluteStringLen = entryAbsoluteString.Length;

            retrieveSettings();
            
            mapFolderLoc.Text = mapFolderDispText + mapFolder;
            logFileLoc.Text = logFileDispText + logfileStr;

            setupLogTimer();
            setupLevelDropdown(yourLevelBox);
            setupLevelDropdown(mapLevelBox);

            // make it readonly
            yourLevelBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mapLevelBox.DropDownStyle = ComboBoxStyle.DropDownList;

            characterNameBox.Text = characterName;
            startBackgroundLogScraper();
        }

        private void retrieveSettings()
        {
            logfileStr = Properties.Settings.Default.logFile;
            mapFolder = Properties.Settings.Default.mapFolder;
            characterName = Properties.Settings.Default.characterName;
        }

        private void setupLevelDropdown(ComboBox box)
        {
            List<int> levels = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                levels.Add(i);
            }

            box.DataSource = levels;
            box.SelectedIndex = yourLevel;
        }

        private void setupLogTimer()
        {
            CheckLogForUpdatesTimer.Interval = 1000;
            CheckLogForUpdatesTimer.Tick += new EventHandler(CheckLogForUpdatesTimer_Tick);
            CheckLogForUpdatesTimer.Enabled = true;
        }

        private void CheckLogForUpdatesTimer_Tick(object sender, EventArgs e)
        {
            if (logFileStream != null)
            {
                string s = getNewStringsInLog();
                parseLogSnippet(s);
            }
            else if(logfileStr != ""){
                logFileStream = File.Open(logfileStr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                lastReadLength = logFileStream.Length;
            }

            if(mapFolder != "" && !mapFolderInit)
            {
                initZoneLvl();
                mapFolderInit = true;
            }
        }

        private string getNewStringsInLog()
        {
            logFileStream.Seek(lastReadLength, SeekOrigin.Begin);

            // read 1024 bytes
            byte[] bytes = new byte[1024];
            var bytesRead = logFileStream.Read(bytes, 0, 1024);
            lastReadLength += bytesRead;

            // Convert bytes to string
            string s = Encoding.Default.GetString(bytes);
            return s;
        }

        private void parseLogSnippet(string s)
        {
            string[] lines = s.Split('\n');
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
                    areaName = line.Substring(indexAbs + entryAbsoluteStringLen).Trim();
                    absolute.Text = areaName;
                    displayMap(areaName, humanName);
                    setZoneLvl(areaName);
                }
                findLevel(line);
                yourLevelBox.SelectedIndex = yourLevel;
            }
        }

        private void setZoneLvl(string areaName)
        {
            bool found = false;
            foreach (Tuple<string, int> area in areaLevels)
            {
                if (area.Item1 == areaName)
                {
                    mapLevel = area.Item2;
                    mapLevelBox.SelectedIndex = mapLevel;
                    found = true;
                    errors.Text = "";
                    errors.BackColor = Color.DarkGray;
                }
            }
            if (!found)
            {
                errors.BackColor = Color.Red;
                errors.Text = "Set Zone Level";
            }
        }

        private void initZoneLvl()
        { 
            string localMapFolder = mapFolder.Trim() + @"\zoneLevel.csv";

            string line = "";
            using (StreamReader file = new StreamReader(localMapFolder))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] partsOfLine = line.Split(',');

                    if (partsOfLine.Length >= 2)
                    {
                        partsOfLine[0] = partsOfLine[0].Trim();
                        partsOfLine[1] = partsOfLine[1].Trim();

                        if (partsOfLine[0] != "") {
                            int parsedNum = 0;
                            Int32.TryParse(partsOfLine[1], out parsedNum);
                            Tuple<string, int> areaEntry = new Tuple<string, int>(partsOfLine[0], parsedNum);

                            areaLevels.Add(areaEntry);
                        }
                    }
                }
            }
        }

        private void displayMap(string areaName, string humanName)
        {
            string localMapFolder = mapFolder.Trim() + @"\" + areaName.Trim();

            if (Directory.Exists(localMapFolder))
            {
                try
                {
                    mapPhotosLocationsBox.Text = "";
                    mapPhotosLocationsBox.BackColor = Color.DarkGray;
                    string[] files = Directory.GetFiles(localMapFolder);

                    clearMaps();

                    if (files.Length > 0)
                    {
                        displayMapPhotos(files);
                    }
                    else
                    {
                        displayNoMaps();
                    }
                }
                catch (Exception e)
                {
                    mapPhotosLocationsBox.BackColor = Color.Red;
                    mapPhotosLocationsBox.Text += "No map folder for area: " + localMapFolder;
                }
            }
            else
            {
                displayNoMaps();
            }
        }

        private void displayMapPhotos(string[] files)
        {
            setRowsAndColumnsMapPhotos(files.Length);

            int i = 0;
            foreach (string file in files)
            {
                mapPhotosLocationsBox.Text += file.ToString() + "\n";
                addMapPhoto(i, file);
                i++;
            }
        }

        private void addMapPhoto(int i, string file)
        {
            PictureBox pb = new PictureBox();
            pb.ImageLocation = file;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Dock = DockStyle.Fill;

            mapsTable.Controls.Add(pb, i % mapsTable.ColumnCount, i / mapsTable.ColumnCount);
        }

        private void setRowsAndColumnsMapPhotos(int count)
        {
            int columns = (int)Math.Ceiling(Math.Sqrt(count));
            int rows = columns;
            if ((rows - 1) * columns >= count) { rows--; }
            if (rows == 0) { rows = 1; }

            mapsTable.ColumnCount = columns;
            mapsTable.RowCount = rows;
        }

        private void clearMaps()
        {
            mapsTable.Controls.Clear();

            mapsTable.ColumnCount = 1;
            mapsTable.RowCount = 1;
        }

        private void displayNoMaps()
        {
            clearMaps();

            mapPhotosLocationsBox.Text = "No Maps Found For This Area" + "\n";
            mapPhotosLocationsBox.Text += mapFolder + @"\NoMapFound.png";
            PictureBox pb = new PictureBox();
            pb.ImageLocation = mapFolder + @"\NoMapFound.png";
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Dock = DockStyle.Fill;

            mapsTable.Controls.Add(pb, 0, 0);
        }

        private void logFileLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                logfileStr = file.FileName;

                logFileStream = File.Open(logfileStr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                lastReadLength = logFileStream.Length;

                logFileLoc.Text = logFileDispText + logfileStr;

                Properties.Settings.Default.logFile = logfileStr;
                Properties.Settings.Default.Save();
            }
        }

        private void mapFolderLoc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult folder = fbd.ShowDialog();
            mapFolder = fbd.SelectedPath.ToString().Trim();

            mapFolderLoc.Text = mapFolderDispText + mapFolder;

            Properties.Settings.Default.mapFolder = mapFolder;
            Properties.Settings.Default.Save();
        }

        private void yourLevelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yourLevel = yourLevelBox.SelectedIndex;
            redrawLevelTable();
        }


        private void mapLevelBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mapLevel = mapLevelBox.SelectedIndex;
            redrawLevelTable();

            errors.Text = "";
            errors.BackColor = Color.DarkGray;
#if ZONELEVELINIT
            saveZoneLevel();
#endif
        }

        private void saveZoneLevel()
        {
            if (!isZoneLevelKnown())
            {
                saveZoneLevelLocally();
                saveZoneLevelToFile();
            }
        }

        private void saveZoneLevelToFile()
        {
            using (StreamWriter outputFile = new StreamWriter(mapFolder + @"\zoneLevel.csv", true))
            {
                string s = areaName.Trim() + "," + mapLevel;
                outputFile.WriteLine(s);
            }
        }

        private void saveZoneLevelLocally()
        {
            Tuple<string, int> newEntry = new Tuple<String, int>(areaName, mapLevel);
            areaLevels.Add(newEntry);
        }

        private bool isZoneLevelKnown()
        {
            foreach (Tuple<string, int> area in areaLevels)
            {
                if (area.Item1 == areaName.Trim())
                {
                    return true; ;
                }
            }
            return false;
        }

        private void redrawLevelTable()
        {
            levelTable.Controls.Clear();
            levelTable.ColumnCount = 1;
            levelTable.RowCount = 0;

            int safeZone = (int)Math.Floor((double)(3 + (yourLevel / 16)));

            int shownRow = -1;
            rowHighlight = -1;

            for (int r = 0; r < 100; r++)
            {
                int monsterLevel = r + 1;
                if (monsterLevel == mapLevel)
                {
                    rowHighlight = shownRow + 1;
                    levelTable.CellPaint += levelTable_CellPaint;
                }

                int effectiveDiff = Math.Abs(yourLevel - monsterLevel) - safeZone;
                if (effectiveDiff < 0) effectiveDiff = 0;
                double xpMult = Math.Pow(((yourLevel + 5) / (yourLevel + 5 + Math.Pow(effectiveDiff, 2.5))), 1.5);

                if (xpMult > 0.20)
                {
                    int colorVal = (int)Math.Floor(255 * xpMult);

                    TableLayoutPanel expTLB = new TableLayoutPanel();
                    expTLB.Dock = DockStyle.Fill;

                    expTLB.Controls.Add(tableLevelCreator(monsterLevel, colorVal), 0, shownRow + 1);
                    expTLB.Controls.Add(xpMultiBoxCreator(xpMult, colorVal), 1, shownRow + 1);

                    levelTable.Controls.Add(expTLB, 0, shownRow + 1);
                    shownRow++;
                    levelTable.RowCount++;
                }
            }

            setStyleLevelTable(levelTable);
        }

        private static void setStyleLevelTable(TableLayoutPanel localLevelTable)
        {
            TableLayoutRowStyleCollection styles = localLevelTable.RowStyles;
            foreach (RowStyle style in styles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 30;
            }
        }

        private static TextBox xpMultiBoxCreator(double xpMult, int colorVal)
        {
            TextBox xpMultiBox = new TextBox();
            xpMultiBox.Dock = DockStyle.Fill;
            xpMultiBox.Width = 140;
            xpMultiBox.Text = Math.Round(xpMult * 100, 2).ToString() + "%";

            xpMultiBox.BackColor = Color.FromArgb(255 - colorVal, colorVal, 0);
            return xpMultiBox;
        }

        private static TextBox tableLevelCreator(int monsterLevel, int colorVal)
        {
            TextBox tableLevel = new TextBox();
            tableLevel.Dock = DockStyle.Fill;
            tableLevel.Width = 140;
            tableLevel.Text = (monsterLevel).ToString();

            tableLevel.BackColor = Color.FromArgb(255 - colorVal, colorVal, 0);
            return tableLevel;
        }

        void levelTable_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == rowHighlight)
                e.Graphics.DrawRectangle(new Pen(Color.Red, 3), e.CellBounds);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            startBackgroundLogScraper();
        }

        private void startBackgroundLogScraper()
        {
            if (backgroundLogScraper.IsBusy == true)
            {
                backgroundLogScraper.CancelAsync();
            }
            backgroundLogScraper = CreateBackgroundWorker();
            backgroundLogScraper.RunWorkerAsync();
        }

        private BackgroundWorker CreateBackgroundWorker()
        {
            var bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += backgroundLogScraper_DoWork;
            return bw;
        }

        public string[] WriteSafeReadAllLines(String path)
        {
            using (var csv = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(csv))
            {
                List<string> file = new List<string>();
                while (!sr.EndOfStream)
                {
                    file.Add(sr.ReadLine());
                }

                return file.ToArray();
            }
        }

        private void setCharacterLevel()
        {
            string[] lines = WriteSafeReadAllLines(logfileStr);

            for (int i = lines.Length - 1 ; i >= 0; i--)
            {
                if (findLevel(lines[i]))
                {
                    break;
                }
            }
            yourLevelBox.Invoke(new Action(() => yourLevelBox.SelectedIndex = yourLevel));
        }

        private bool findLevel(string s)
        {
            int indexName = s.LastIndexOf(characterName + " ");
            int indexLevel = s.IndexOf("is now level");
            if (indexName != -1 && indexLevel != -1 && indexLevel < 2000)
            {
                s = s.Substring(indexLevel + 13).Trim();
                int index = s.IndexOf("\r");
                if (index > 0)
                {
                    s = s.Substring(0, index).Trim();
                }

                return Int32.TryParse(s, out yourLevel);
            }
            return false;
        }

        private void backgroundLogScraper_DoWork(object sender, DoWorkEventArgs e)
        {
            characterName = characterNameBox.Text;
            Properties.Settings.Default.characterName = characterName;
            Properties.Settings.Default.Save();
            setCharacterLevel();
        }

        /*TODO
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
        */
    }
}
