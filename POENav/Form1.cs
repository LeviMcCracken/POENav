//#define INITTREE
#define ZONELEVELINIT
#define INITMAPSFOLDER

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace nav
{
    public partial class POENavForm : Form
    {

        string logfileStr = "";
        string entryHumanString = "You have entered ";

        string mapFolderDispText = "Map folder Location: ";
        string logFileDispText = "Log file Location: ";
        string areaName = "";
        string characterName = "";
        int entryHumanStringLen;
        string mapFolder = "";
        int rowHighlight1 = 0;
        int rowHighlight2 = 0;
        int yourLevel = 0;
        int mapLevel1 = 0;
        int mapLevel2 = 0;

        ZoneLevel zl;
        FileReader fr;

        System.Threading.Thread charNameThread;

        public POENavForm()
        {
            InitializeComponent();

            entryHumanStringLen = entryHumanString.Length;

            retrieveSettings();
            zl = new ZoneLevel(mapFolder);
            fr = new FileReader(logfileStr,logFileDispText, logFileLoc);
            
            mapFolderLoc.Text = mapFolderDispText + mapFolder;
            logFileLoc.Text = logFileDispText + logfileStr;

            setupLogTimer();
            setupLevelDropdown(yourLevelBox);
            setupLevelDropdown(mapLevelBox1);
            setupLevelDropdown(mapLevelBox2);

            yourLevelBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mapLevelBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            mapLevelBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            characterNameBox.Text = characterName;

            charNameThread = new System.Threading.Thread(startBackgroundLogScraper);
            charNameThread.Start();
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
                        mapName.Text = humanName;
                        areaName = humanName;
                        displayMap(humanName);
                        setZoneLvlGui(humanName);
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
            mapLevel1 = zl.zoneKnown(areaName, 1);
            mapLevel2 = zl.zoneKnown(areaName, 2);

            if (mapLevel1 == -1 && levelTab.SelectedIndex == 0 
                || mapLevel2 == -1 && levelTab.SelectedIndex == 1)
            {
                errors.BackColor = Color.Red;
                errors.Text = "Set Zone Level";
            }
            else
            {
                errors.Text = "";
                errors.BackColor = Color.DarkGray;
                mapLevelBox1.SelectedIndex = mapLevel1;
                mapLevelBox2.SelectedIndex = mapLevel2;
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
                catch (Exception)
                {
                    mapPhotosLocationsBox.BackColor = Color.Red;
                    mapPhotosLocationsBox.Text += "No map folder for area: " + localMapFolder;

                }
            }
            else
            {
#if INITMAPSFOLDER
                Directory.CreateDirectory(localMapFolder);
#endif
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
            fr.logFileLocMethod();
        }

        private void mapFolderLoc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult folder = fbd.ShowDialog();
            if (folder == DialogResult.Cancel)
            {
                return;
            }
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


        private void mapLevelBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapLevel1 = mapLevelBox1.SelectedIndex;
            redrawLevelTable();

            errors.Text = "";
            errors.BackColor = Color.DarkGray;
#if ZONELEVELINIT
            zl.saveZoneLevel(areaName, mapLevel1, 1);
#endif
        }

        private void mapLevelBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapLevel2 = mapLevelBox2.SelectedIndex;
            redrawLevelTable();

            errors.Text = "";
            errors.BackColor = Color.DarkGray;
#if ZONELEVELINIT
            zl.saveZoneLevel(areaName, mapLevel2, 2);
#endif
        }

        private void redrawLevelTable()
        {
            levelTable1.Controls.Clear();
            levelTable1.ColumnCount = 1;
            levelTable1.RowCount = 0;

            levelTable2.Controls.Clear();
            levelTable2.ColumnCount = 1;
            levelTable2.RowCount = 0;

            int safeZone = (int)Math.Floor((double)(3 + (yourLevel / 16)));

            int shownRow = -1;
            rowHighlight1 = -1;
            rowHighlight2 = -1;

            for (int r = 0; r < 100; r++)
            {
                int monsterLevel = r + 1;
                int effectiveDiff = Math.Abs(yourLevel - monsterLevel) - safeZone;
                if (effectiveDiff < 0) effectiveDiff = 0;
                double xpMult = Math.Pow(((yourLevel + 5) / (yourLevel + 5 + Math.Pow(effectiveDiff, 2.5))), 1.5);

                if (xpMult > 0.20)
                {
                    if (monsterLevel == mapLevel1)
                    {
                        rowHighlight1 = shownRow + 2;
                        levelTable1.CellPaint += levelTable1_CellPaint;
                    }
                    else if (monsterLevel == mapLevel2)
                    {
                        rowHighlight2 = shownRow + 2;
                        levelTable2.CellPaint += levelTable2_CellPaint;
                    }

                    int colorVal = (int)Math.Floor(255 * xpMult);

                    TableLayoutPanel expTLB1 = new TableLayoutPanel();
                    expTLB1.Dock = DockStyle.Fill;
                    expTLB1.Controls.Add(GuiHelper.tableLevelCreator(monsterLevel, colorVal), 0, shownRow + 1);
                    expTLB1.Controls.Add(GuiHelper.xpMultiBoxCreator(xpMult, colorVal), 1, shownRow + 1);

                    TableLayoutPanel expTLB2 = new TableLayoutPanel();
                    expTLB2.Dock = DockStyle.Fill;
                    expTLB2.Controls.Add(GuiHelper.tableLevelCreator(monsterLevel, colorVal), 0, shownRow + 1);
                    expTLB2.Controls.Add(GuiHelper.xpMultiBoxCreator(xpMult, colorVal), 1, shownRow + 1);

                    shownRow++;
                    levelTable1.Controls.Add(expTLB1, 0, shownRow + 1);
                    levelTable1.RowCount++;
                    levelTable2.Controls.Add(expTLB2, 0, shownRow + 1);
                    levelTable2.RowCount++;
                }
            }

            GuiHelper.setStyleLevelTable(ref levelTable1);
            GuiHelper.setStyleLevelTable(ref levelTable2);
        }

        void levelTable1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == rowHighlight1)
                e.Graphics.DrawRectangle(new Pen(Color.Red, 3), e.CellBounds);
        }
        void levelTable2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == rowHighlight2)
                e.Graphics.DrawRectangle(new Pen(Color.Red, 3), e.CellBounds);
        }

        private void characterNameBox_TextChanged(object sender, EventArgs e)
        {
            if (charNameThread != null)
            {
                charNameThread.Abort();
            }
            charNameThread = new System.Threading.Thread(startBackgroundLogScraper);
            charNameThread.Start();
        }

        private void startBackgroundLogScraper()
        {
            try
            {
                characterName = characterNameBox.Text;
                Properties.Settings.Default.characterName = characterName;
                Properties.Settings.Default.Save();

                yourLevelBox.Invoke(new Action(() => yourLevelBox.SelectedIndex = fr.getCharacterLevel(characterName, logfileStr)));
            }catch(Exception)
            {

            }
        }
    }
}
