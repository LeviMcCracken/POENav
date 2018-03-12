namespace nav
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanelRoot = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.absolute = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mapFolderLoc = new System.Windows.Forms.Label();
            this.logFileLoc = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Level = new System.Windows.Forms.TableLayoutPanel();
            this.mapLevelBox = new System.Windows.Forms.ComboBox();
            this.yourLevelBox = new System.Windows.Forms.ComboBox();
            this.levelTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRoot.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.Level.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelRoot
            // 
            this.tableLayoutPanelRoot.AutoSize = true;
            this.tableLayoutPanelRoot.ColumnCount = 2;
            this.tableLayoutPanelRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelRoot.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanelRoot.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRoot.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelRoot.Name = "tableLayoutPanelRoot";
            this.tableLayoutPanelRoot.RowCount = 1;
            this.tableLayoutPanelRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRoot.Size = new System.Drawing.Size(1433, 630);
            this.tableLayoutPanelRoot.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(289, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1141, 624);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.absolute, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox2, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(280, 624);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // absolute
            // 
            this.absolute.BackColor = System.Drawing.SystemColors.ControlDark;
            this.absolute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.absolute.Location = new System.Drawing.Point(3, 83);
            this.absolute.Name = "absolute";
            this.absolute.ReadOnly = true;
            this.absolute.Size = new System.Drawing.Size(274, 48);
            this.absolute.TabIndex = 2;
            this.absolute.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(274, 48);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 191);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(274, 48);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.mapFolderLoc, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.logFileLoc, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 74);
            this.tableLayoutPanel2.TabIndex = 6;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // mapFolderLoc
            // 
            this.mapFolderLoc.AutoSize = true;
            this.mapFolderLoc.Location = new System.Drawing.Point(3, 37);
            this.mapFolderLoc.Name = "mapFolderLoc";
            this.mapFolderLoc.Size = new System.Drawing.Size(107, 13);
            this.mapFolderLoc.TabIndex = 9;
            this.mapFolderLoc.Text = "Map Folder Location:";
            this.mapFolderLoc.Click += new System.EventHandler(this.mapFolderLoc_Click);
            // 
            // logFileLoc
            // 
            this.logFileLoc.AutoSize = true;
            this.logFileLoc.Location = new System.Drawing.Point(3, 0);
            this.logFileLoc.Name = "logFileLoc";
            this.logFileLoc.Size = new System.Drawing.Size(91, 13);
            this.logFileLoc.TabIndex = 8;
            this.logFileLoc.Text = "Log File Location:";
            this.logFileLoc.Click += new System.EventHandler(this.logFileLoc_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.Level, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.levelTable, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 245);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(274, 376);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // Level
            // 
            this.Level.ColumnCount = 2;
            this.Level.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Level.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Level.Controls.Add(this.mapLevelBox, 1, 0);
            this.Level.Controls.Add(this.yourLevelBox, 0, 0);
            this.Level.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Level.Location = new System.Drawing.Point(3, 3);
            this.Level.Name = "Level";
            this.Level.RowCount = 1;
            this.Level.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Level.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.Level.Size = new System.Drawing.Size(268, 34);
            this.Level.TabIndex = 0;
            // 
            // mapLevelBox
            // 
            this.mapLevelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapLevelBox.FormattingEnabled = true;
            this.mapLevelBox.Location = new System.Drawing.Point(137, 3);
            this.mapLevelBox.Name = "mapLevelBox";
            this.mapLevelBox.Size = new System.Drawing.Size(128, 21);
            this.mapLevelBox.TabIndex = 1;
            this.mapLevelBox.SelectedIndexChanged += new System.EventHandler(this.mapLevel_SelectedIndexChanged);
            // 
            // yourLevelBox
            // 
            this.yourLevelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yourLevelBox.FormattingEnabled = true;
            this.yourLevelBox.Location = new System.Drawing.Point(3, 3);
            this.yourLevelBox.Name = "yourLevelBox";
            this.yourLevelBox.Size = new System.Drawing.Size(128, 21);
            this.yourLevelBox.TabIndex = 0;
            this.yourLevelBox.SelectedIndexChanged += new System.EventHandler(this.yourLevel_SelectedIndexChanged);
            // 
            // levelTable
            // 
            this.levelTable.AutoScroll = true;
            this.levelTable.ColumnCount = 3;
            this.levelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.levelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.levelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.levelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelTable.Location = new System.Drawing.Point(3, 43);
            this.levelTable.Name = "levelTable";
            this.levelTable.RowCount = 2;
            this.levelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.levelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.levelTable.Size = new System.Drawing.Size(268, 330);
            this.levelTable.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1433, 630);
            this.Controls.Add(this.tableLayoutPanelRoot);
            this.Name = "Form1";
            this.Text = "POENav";
            this.tableLayoutPanelRoot.ResumeLayout(false);
            this.tableLayoutPanelRoot.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.Level.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox absolute;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label mapFolderLoc;
        private System.Windows.Forms.Label logFileLoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel Level;
        private System.Windows.Forms.TableLayoutPanel levelTable;
        private System.Windows.Forms.ComboBox mapLevelBox;
        private System.Windows.Forms.ComboBox yourLevelBox;
    }
}

