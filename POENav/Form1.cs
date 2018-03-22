//#define INITTREE
#define ZONELEVELINIT

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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
        
        ZoneLevel zl;
        FileReader fr;

        public POENavForm()
        {
            InitializeComponent();


            entryHumanStringLen = entryHumanString.Length;
            entryAbsoluteStringLen = entryAbsoluteString.Length;

            retrieveSettings();
            zl = new ZoneLevel(mapFolder);
            fr = new FileReader(logfileStr);
            
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
            string s = fr.getNewStringsInLog();
            parseLogSnippet(s);
        }

        private void parseLogSnippet(string s)
        {
            if (s.Length != 0)
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
                        mapName.Text = areaName + "\n" + humanName;
                        displayMap(areaName);
                        setZoneLvlGui(areaName);
                    }
                    int lvl = Parser.findLevel(line, characterName);
                    if (lvl != -1)
                    {
                        yourLevel = lvl;
                        yourLevelBox.SelectedIndex = yourLevel;
                    }
                }
            }
        }

        private void setZoneLvlGui(string areaName)
        {
            mapLevel = zl.zoneKnown(areaName);

            if (mapLevel == -1)
            {
                errors.BackColor = Color.Red;
                errors.Text = "Set Zone Level";
            }
            else
            {
                errors.Text = "";
                errors.BackColor = Color.DarkGray;
                mapLevelBox.SelectedIndex = mapLevel;
            }
        }


        private void displayMap(string areaName)
        {
            string localMapFolder = mapFolder.Trim() + @"\" + areaName.Trim();

            if (Directory.Exists(localMapFolder))
            {
                try
                {
                    mapPhotosLocationsBox.Text = "";
                    mapPhotosLocationsBox.BackColor = Color.DarkGray;
                    string[] files = Directory.GetFiles(localMapFolder);

                    GuiHelper.clearMaps(mapsTable);

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
            GuiHelper.setRowsAndColumnsMapPhotos(files.Length, mapsTable);

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
        
        private void displayNoMaps()
        {
            GuiHelper.clearMaps(mapsTable);

            mapPhotosLocationsBox.Text = "No Maps Found For This Area" + "\n";
            mapPhotosLocationsBox.Text += mapFolder + @"\NoMapFound.png";
            PictureBox pb = new PictureBox();
            pb.ImageLocation = mapFolder + @"\NoMapFound.png";
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Dock = DockStyle.Fill;

            mapsTable.Controls.Add(pb, 0, 0);
        }


        private void logFileLoc_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                logfileStr = file.FileName;

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
            zl.updateMapFolder(mapFolder);

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
            zl.saveZoneLevel(areaName, mapLevel);
#endif
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
                int effectiveDiff = Math.Abs(yourLevel - monsterLevel) - safeZone;
                if (effectiveDiff < 0) effectiveDiff = 0;
                double xpMult = Math.Pow(((yourLevel + 5) / (yourLevel + 5 + Math.Pow(effectiveDiff, 2.5))), 1.5);

                if (xpMult > 0.20)
                {
                    if (monsterLevel == mapLevel)
                    {
                        rowHighlight = shownRow + 1;
                        levelTable.CellPaint += levelTable_CellPaint;
                    }

                    int colorVal = (int)Math.Floor(255 * xpMult);

                    TableLayoutPanel expTLB = new TableLayoutPanel();
                    expTLB.Dock = DockStyle.Fill;

                    expTLB.Controls.Add(GuiHelper.tableLevelCreator(monsterLevel, colorVal), 0, shownRow + 1);
                    expTLB.Controls.Add(GuiHelper.xpMultiBoxCreator(xpMult, colorVal), 1, shownRow + 1);

                    levelTable.Controls.Add(expTLB, 0, shownRow + 1);
                    shownRow++;
                    levelTable.RowCount++;
                }
            }

            GuiHelper.setStyleLevelTable(ref levelTable);
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
            backgroundLogScraper = Util.createBackgroundWorker();
            backgroundLogScraper.DoWork += backgroundLogScraper_DoWork;
            backgroundLogScraper.RunWorkerAsync();
        }

        private void backgroundLogScraper_DoWork(object sender, DoWorkEventArgs e)
        {
            characterName = characterNameBox.Text;
            Properties.Settings.Default.characterName = characterName;
            Properties.Settings.Default.Save();

            yourLevelBox.Invoke(new Action(() => yourLevelBox.SelectedIndex = fr.getCharacterLevel(characterName, logfileStr)));
        }
    }
}
