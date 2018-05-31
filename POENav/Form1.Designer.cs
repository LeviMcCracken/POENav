namespace nav
{
    partial class POENavForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CheckLogForUpdatesTimer = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanelRoot = new System.Windows.Forms.TableLayoutPanel();
            this.mapsTable = new System.Windows.Forms.TableLayoutPanel();
            this.leftColumnTable = new System.Windows.Forms.TableLayoutPanel();
            this.charNameBox = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.characterNameBox = new System.Windows.Forms.TextBox();
            this.logFileLoc = new System.Windows.Forms.Label();
            this.mapFolderLoc = new System.Windows.Forms.Label();
            this.mapName = new System.Windows.Forms.Label();
            this.mapPhotosLocationsBox = new System.Windows.Forms.Label();
            this.errors = new System.Windows.Forms.RichTextBox();
            this.lvlLabel = new System.Windows.Forms.Label();
            this.yourLevelBox = new System.Windows.Forms.ComboBox();
            this.levelTab = new System.Windows.Forms.TabControl();
            this.p1t = new System.Windows.Forms.TabPage();
            this.part1Tab = new System.Windows.Forms.TableLayoutPanel();
            this.mapLevelLabel1 = new System.Windows.Forms.Label();
            this.mapLevelBox1 = new System.Windows.Forms.ComboBox();
            this.monsterLvlLabel1 = new System.Windows.Forms.Label();
            this.levelTable1 = new System.Windows.Forms.TableLayoutPanel();
            this.p2t = new System.Windows.Forms.TabPage();
            this.part2Tab = new System.Windows.Forms.TableLayoutPanel();
            this.mapLevelLabel2 = new System.Windows.Forms.Label();
            this.mapLevelBox2 = new System.Windows.Forms.ComboBox();
            this.monsterLvlLabel2 = new System.Windows.Forms.Label();
            this.levelTable2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundLevelTableBuilder = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRoot.SuspendLayout();
            this.leftColumnTable.SuspendLayout();
            this.charNameBox.SuspendLayout();
            this.levelTab.SuspendLayout();
            this.p1t.SuspendLayout();
            this.part1Tab.SuspendLayout();
            this.p2t.SuspendLayout();
            this.part2Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckLogForUpdatesTimer
            // 
            this.CheckLogForUpdatesTimer.Tick += new System.EventHandler(this.CheckLogForUpdatesTimer_Tick);
            // 
            // tableLayoutPanelRoot
            // 
            this.tableLayoutPanelRoot.AutoSize = true;
            this.tableLayoutPanelRoot.ColumnCount = 2;
            this.tableLayoutPanelRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRoot.Controls.Add(this.mapsTable, 1, 0);
            this.tableLayoutPanelRoot.Controls.Add(this.leftColumnTable, 0, 0);
            this.tableLayoutPanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRoot.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelRoot.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelRoot.Name = "tableLayoutPanelRoot";
            this.tableLayoutPanelRoot.RowCount = 1;
            this.tableLayoutPanelRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRoot.Size = new System.Drawing.Size(1433, 630);
            this.tableLayoutPanelRoot.TabIndex = 5;
            // 
            // mapsTable
            // 
            this.mapsTable.ColumnCount = 2;
            this.mapsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapsTable.Location = new System.Drawing.Point(300, 0);
            this.mapsTable.Margin = new System.Windows.Forms.Padding(0);
            this.mapsTable.Name = "mapsTable";
            this.mapsTable.RowCount = 2;
            this.mapsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapsTable.Size = new System.Drawing.Size(1133, 630);
            this.mapsTable.TabIndex = 4;
            // 
            // leftColumnTable
            // 
            this.leftColumnTable.ColumnCount = 1;
            this.leftColumnTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftColumnTable.Controls.Add(this.charNameBox);
            this.leftColumnTable.Controls.Add(this.logFileLoc);
            this.leftColumnTable.Controls.Add(this.mapFolderLoc);
            this.leftColumnTable.Controls.Add(this.mapName);
            this.leftColumnTable.Controls.Add(this.mapPhotosLocationsBox);
            this.leftColumnTable.Controls.Add(this.errors);
            this.leftColumnTable.Controls.Add(this.lvlLabel);
            this.leftColumnTable.Controls.Add(this.yourLevelBox);
            this.leftColumnTable.Controls.Add(this.levelTab);
            this.leftColumnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftColumnTable.Location = new System.Drawing.Point(0, 0);
            this.leftColumnTable.Margin = new System.Windows.Forms.Padding(0);
            this.leftColumnTable.Name = "leftColumnTable";
            this.leftColumnTable.RowCount = 10;
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftColumnTable.Size = new System.Drawing.Size(300, 630);
            this.leftColumnTable.TabIndex = 1;
            // 
            // charNameBox
            // 
            this.charNameBox.ColumnCount = 2;
            this.charNameBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.charNameBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.charNameBox.Controls.Add(this.label5, 0, 0);
            this.charNameBox.Controls.Add(this.characterNameBox, 1, 0);
            this.charNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charNameBox.Location = new System.Drawing.Point(0, 0);
            this.charNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.charNameBox.Name = "charNameBox";
            this.charNameBox.RowCount = 1;
            this.charNameBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.charNameBox.Size = new System.Drawing.Size(300, 30);
            this.charNameBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Character Name:";
            // 
            // characterNameBox
            // 
            this.characterNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterNameBox.Location = new System.Drawing.Point(103, 3);
            this.characterNameBox.Name = "characterNameBox";
            this.characterNameBox.Size = new System.Drawing.Size(194, 20);
            this.characterNameBox.TabIndex = 1;
            this.characterNameBox.TextChanged += new System.EventHandler(this.characterNameBox_TextChanged);
            // 
            // logFileLoc
            // 
            this.logFileLoc.AutoSize = true;
            this.logFileLoc.Location = new System.Drawing.Point(3, 30);
            this.logFileLoc.Name = "logFileLoc";
            this.logFileLoc.Size = new System.Drawing.Size(91, 13);
            this.logFileLoc.TabIndex = 10;
            this.logFileLoc.Text = "Log File Location:";
            this.logFileLoc.Click += new System.EventHandler(this.logFileLoc_Click_1);
            // 
            // mapFolderLoc
            // 
            this.mapFolderLoc.AutoSize = true;
            this.mapFolderLoc.Location = new System.Drawing.Point(3, 80);
            this.mapFolderLoc.Name = "mapFolderLoc";
            this.mapFolderLoc.Size = new System.Drawing.Size(107, 13);
            this.mapFolderLoc.TabIndex = 10;
            this.mapFolderLoc.Text = "Map Folder Location:";
            this.mapFolderLoc.Click += new System.EventHandler(this.mapFolderLoc_Click);
            // 
            // mapName
            // 
            this.mapName.AutoSize = true;
            this.mapName.Location = new System.Drawing.Point(3, 130);
            this.mapName.Name = "mapName";
            this.mapName.Size = new System.Drawing.Size(57, 13);
            this.mapName.TabIndex = 11;
            this.mapName.Text = "Map name";
            // 
            // mapPhotosLocationsBox
            // 
            this.mapPhotosLocationsBox.AutoSize = true;
            this.mapPhotosLocationsBox.Location = new System.Drawing.Point(3, 160);
            this.mapPhotosLocationsBox.Name = "mapPhotosLocationsBox";
            this.mapPhotosLocationsBox.Size = new System.Drawing.Size(64, 13);
            this.mapPhotosLocationsBox.TabIndex = 12;
            this.mapPhotosLocationsBox.Text = "Map images";
            // 
            // errors
            // 
            this.errors.BackColor = System.Drawing.SystemColors.ControlDark;
            this.errors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errors.Location = new System.Drawing.Point(3, 223);
            this.errors.Name = "errors";
            this.errors.ReadOnly = true;
            this.errors.Size = new System.Drawing.Size(294, 54);
            this.errors.TabIndex = 5;
            this.errors.Text = "";
            // 
            // lvlLabel
            // 
            this.lvlLabel.AutoSize = true;
            this.lvlLabel.Location = new System.Drawing.Point(3, 280);
            this.lvlLabel.Name = "lvlLabel";
            this.lvlLabel.Size = new System.Drawing.Size(61, 13);
            this.lvlLabel.TabIndex = 3;
            this.lvlLabel.Text = "Your Level:";
            // 
            // yourLevelBox
            // 
            this.yourLevelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yourLevelBox.FormattingEnabled = true;
            this.yourLevelBox.Location = new System.Drawing.Point(3, 303);
            this.yourLevelBox.Name = "yourLevelBox";
            this.yourLevelBox.Size = new System.Drawing.Size(294, 21);
            this.yourLevelBox.TabIndex = 2;
            this.yourLevelBox.SelectedIndexChanged += new System.EventHandler(this.yourLevelBox_SelectedIndexChanged);
            // 
            // levelTab
            // 
            this.levelTab.Controls.Add(this.p1t);
            this.levelTab.Controls.Add(this.p2t);
            this.levelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelTab.Location = new System.Drawing.Point(3, 333);
            this.levelTab.Name = "levelTab";
            this.levelTab.SelectedIndex = 0;
            this.levelTab.Size = new System.Drawing.Size(294, 274);
            this.levelTab.TabIndex = 13;
            // 
            // p1t
            // 
            this.p1t.BackColor = System.Drawing.SystemColors.ControlDark;
            this.p1t.Controls.Add(this.part1Tab);
            this.p1t.Location = new System.Drawing.Point(4, 22);
            this.p1t.Name = "p1t";
            this.p1t.Size = new System.Drawing.Size(286, 248);
            this.p1t.TabIndex = 0;
            this.p1t.Text = "Part 1";
            // 
            // part1Tab
            // 
            this.part1Tab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.part1Tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.part1Tab.Controls.Add(this.mapLevelLabel1);
            this.part1Tab.Controls.Add(this.mapLevelBox1);
            this.part1Tab.Controls.Add(this.monsterLvlLabel1);
            this.part1Tab.Controls.Add(this.levelTable1);
            this.part1Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.part1Tab.Location = new System.Drawing.Point(0, 0);
            this.part1Tab.Name = "part1Tab";
            this.part1Tab.Padding = new System.Windows.Forms.Padding(3);
            this.part1Tab.RowCount = 4;
            this.part1Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.part1Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.part1Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.part1Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.part1Tab.Size = new System.Drawing.Size(286, 248);
            this.part1Tab.TabIndex = 0;
            this.part1Tab.Text = "Part 1";
            // 
            // mapLevelLabel1
            // 
            this.mapLevelLabel1.AutoSize = true;
            this.mapLevelLabel1.Location = new System.Drawing.Point(6, 3);
            this.mapLevelLabel1.Name = "mapLevelLabel1";
            this.mapLevelLabel1.Size = new System.Drawing.Size(60, 13);
            this.mapLevelLabel1.TabIndex = 4;
            this.mapLevelLabel1.Text = "Map Level:";
            // 
            // mapLevelBox1
            // 
            this.mapLevelBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapLevelBox1.FormattingEnabled = true;
            this.mapLevelBox1.Location = new System.Drawing.Point(6, 26);
            this.mapLevelBox1.Name = "mapLevelBox1";
            this.mapLevelBox1.Size = new System.Drawing.Size(274, 21);
            this.mapLevelBox1.TabIndex = 2;
            this.mapLevelBox1.SelectedIndexChanged += new System.EventHandler(this.mapLevelBox1_SelectedIndexChanged);
            // 
            // monsterLvlLabel1
            // 
            this.monsterLvlLabel1.AutoSize = true;
            this.monsterLvlLabel1.Location = new System.Drawing.Point(6, 53);
            this.monsterLvlLabel1.Name = "monsterLvlLabel1";
            this.monsterLvlLabel1.Size = new System.Drawing.Size(208, 13);
            this.monsterLvlLabel1.TabIndex = 6;
            this.monsterLvlLabel1.Text = "Monster Level                           Experience";
            // 
            // levelTable1
            // 
            this.levelTable1.AutoScroll = true;
            this.levelTable1.ColumnCount = 1;
            this.levelTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.levelTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelTable1.Location = new System.Drawing.Point(3, 73);
            this.levelTable1.Margin = new System.Windows.Forms.Padding(0);
            this.levelTable1.Name = "levelTable1";
            this.levelTable1.RowCount = 100;
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable1.Size = new System.Drawing.Size(280, 172);
            this.levelTable1.TabIndex = 1;
            // 
            // p2t
            // 
            this.p2t.BackColor = System.Drawing.SystemColors.ControlDark;
            this.p2t.Controls.Add(this.part2Tab);
            this.p2t.Location = new System.Drawing.Point(4, 22);
            this.p2t.Name = "p2t";
            this.p2t.Size = new System.Drawing.Size(286, 268);
            this.p2t.TabIndex = 1;
            this.p2t.Text = "Part 2";
            // 
            // part2Tab
            // 
            this.part2Tab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.part2Tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.part2Tab.Controls.Add(this.mapLevelLabel2);
            this.part2Tab.Controls.Add(this.mapLevelBox2);
            this.part2Tab.Controls.Add(this.monsterLvlLabel2);
            this.part2Tab.Controls.Add(this.levelTable2);
            this.part2Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.part2Tab.Location = new System.Drawing.Point(0, 0);
            this.part2Tab.Name = "part2Tab";
            this.part2Tab.Padding = new System.Windows.Forms.Padding(3);
            this.part2Tab.RowCount = 4;
            this.part2Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.part2Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.part2Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.part2Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.part2Tab.Size = new System.Drawing.Size(286, 268);
            this.part2Tab.TabIndex = 1;
            this.part2Tab.Text = "Part 2";
            // 
            // mapLevelLabel2
            // 
            this.mapLevelLabel2.AutoSize = true;
            this.mapLevelLabel2.Location = new System.Drawing.Point(6, 3);
            this.mapLevelLabel2.Name = "mapLevelLabel2";
            this.mapLevelLabel2.Size = new System.Drawing.Size(60, 13);
            this.mapLevelLabel2.TabIndex = 4;
            this.mapLevelLabel2.Text = "Map Level:";
            // 
            // mapLevelBox2
            // 
            this.mapLevelBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapLevelBox2.FormattingEnabled = true;
            this.mapLevelBox2.Location = new System.Drawing.Point(6, 26);
            this.mapLevelBox2.Name = "mapLevelBox2";
            this.mapLevelBox2.Size = new System.Drawing.Size(274, 21);
            this.mapLevelBox2.TabIndex = 2;
            this.mapLevelBox2.SelectedIndexChanged += new System.EventHandler(this.mapLevelBox2_SelectedIndexChanged);
            // 
            // monsterLvlLabel2
            // 
            this.monsterLvlLabel2.AutoSize = true;
            this.monsterLvlLabel2.Location = new System.Drawing.Point(6, 53);
            this.monsterLvlLabel2.Name = "monsterLvlLabel2";
            this.monsterLvlLabel2.Size = new System.Drawing.Size(208, 13);
            this.monsterLvlLabel2.TabIndex = 6;
            this.monsterLvlLabel2.Text = "Monster Level                           Experience";
            // 
            // levelTable2
            // 
            this.levelTable2.AutoScroll = true;
            this.levelTable2.ColumnCount = 1;
            this.levelTable2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.levelTable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelTable2.Location = new System.Drawing.Point(3, 73);
            this.levelTable2.Margin = new System.Windows.Forms.Padding(0);
            this.levelTable2.Name = "levelTable2";
            this.levelTable2.RowCount = 100;
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.levelTable2.Size = new System.Drawing.Size(280, 192);
            this.levelTable2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 313);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(274, 308);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // backgroundLevelTableBuilder
            // 
            this.backgroundLevelTableBuilder.WorkerSupportsCancellation = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(106, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // POENavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1433, 630);
            this.Controls.Add(this.tableLayoutPanelRoot);
            this.Name = "POENavForm";
            this.Text = "POENav";
            this.tableLayoutPanelRoot.ResumeLayout(false);
            this.leftColumnTable.ResumeLayout(false);
            this.leftColumnTable.PerformLayout();
            this.charNameBox.ResumeLayout(false);
            this.charNameBox.PerformLayout();
            this.levelTab.ResumeLayout(false);
            this.p1t.ResumeLayout(false);
            this.part1Tab.ResumeLayout(false);
            this.part1Tab.PerformLayout();
            this.p2t.ResumeLayout(false);
            this.part2Tab.ResumeLayout(false);
            this.part2Tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer CheckLogForUpdatesTimer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoot;
        private System.Windows.Forms.TableLayoutPanel mapsTable;
        private System.Windows.Forms.TableLayoutPanel leftColumnTable;
        private System.Windows.Forms.RichTextBox errors;
        private System.Windows.Forms.TableLayoutPanel charNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox characterNameBox;
        private System.Windows.Forms.Label mapFolderLoc;
        private System.Windows.Forms.Label logFileLoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label monsterLvlLabel1;
        private System.Windows.Forms.Label monsterLvlLabel2;
        private System.Windows.Forms.Label mapLevelLabel1;
        private System.Windows.Forms.Label mapLevelLabel2;
        private System.Windows.Forms.ComboBox yourLevelBox;
        private System.Windows.Forms.ComboBox mapLevelBox1;
        private System.Windows.Forms.ComboBox mapLevelBox2;
        private System.Windows.Forms.Label lvlLabel;
        private System.Windows.Forms.TableLayoutPanel levelTable1;
        private System.Windows.Forms.TableLayoutPanel levelTable2;
        private System.Windows.Forms.Label mapPhotosLocationsBox;
        private System.Windows.Forms.Label mapName;
        private System.ComponentModel.BackgroundWorker backgroundLevelTableBuilder;
        private System.Windows.Forms.TabControl levelTab;
        private System.Windows.Forms.TableLayoutPanel part1Tab;
        private System.Windows.Forms.TableLayoutPanel part2Tab;
        private System.Windows.Forms.TabPage p1t;
        private System.Windows.Forms.TabPage p2t;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

