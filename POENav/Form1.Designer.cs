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
            this.leftColumnTable = new System.Windows.Forms.TableLayoutPanel();
            this.logFileLoc = new System.Windows.Forms.Label();
            this.mapFolderLoc = new System.Windows.Forms.Label();
            this.absolute = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Level = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yourLevelBox = new System.Windows.Forms.ComboBox();
            this.mapLevelBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.levelTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelRoot.SuspendLayout();
            this.leftColumnTable.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.Level.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelRoot
            // 
            this.tableLayoutPanelRoot.AutoSize = true;
            this.tableLayoutPanelRoot.ColumnCount = 2;
            this.tableLayoutPanelRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelRoot.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanelRoot.Controls.Add(this.leftColumnTable, 0, 0);
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
            // leftColumnTable
            // 
            this.leftColumnTable.ColumnCount = 1;
            this.leftColumnTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftColumnTable.Controls.Add(this.logFileLoc, 0, 1);
            this.leftColumnTable.Controls.Add(this.mapFolderLoc, 0, 2);
            this.leftColumnTable.Controls.Add(this.absolute, 0, 3);
            this.leftColumnTable.Controls.Add(this.richTextBox1, 0, 4);
            this.leftColumnTable.Controls.Add(this.richTextBox2, 0, 5);
            this.leftColumnTable.Controls.Add(this.tableLayoutPanel4, 0, 6);
            this.leftColumnTable.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.leftColumnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftColumnTable.Location = new System.Drawing.Point(3, 3);
            this.leftColumnTable.Name = "leftColumnTable";
            this.leftColumnTable.RowCount = 7;
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftColumnTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftColumnTable.Size = new System.Drawing.Size(280, 624);
            this.leftColumnTable.TabIndex = 1;
            // 
            // logFileLoc
            // 
            this.logFileLoc.AutoSize = true;
            this.logFileLoc.Location = new System.Drawing.Point(3, 30);
            this.logFileLoc.Name = "logFileLoc";
            this.logFileLoc.Size = new System.Drawing.Size(91, 13);
            this.logFileLoc.TabIndex = 10;
            this.logFileLoc.Text = "Log File Location:";
            // 
            // mapFolderLoc
            // 
            this.mapFolderLoc.AutoSize = true;
            this.mapFolderLoc.Location = new System.Drawing.Point(3, 80);
            this.mapFolderLoc.Name = "mapFolderLoc";
            this.mapFolderLoc.Size = new System.Drawing.Size(107, 13);
            this.mapFolderLoc.TabIndex = 10;
            this.mapFolderLoc.Text = "Map Folder Location:";
            // 
            // absolute
            // 
            this.absolute.BackColor = System.Drawing.SystemColors.ControlDark;
            this.absolute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.absolute.Location = new System.Drawing.Point(3, 133);
            this.absolute.Name = "absolute";
            this.absolute.ReadOnly = true;
            this.absolute.Size = new System.Drawing.Size(274, 54);
            this.absolute.TabIndex = 2;
            this.absolute.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 193);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(274, 54);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 253);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(274, 54);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Level, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.levelTable, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 313);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(274, 308);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // Level
            // 
            this.Level.ColumnCount = 2;
            this.Level.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Level.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Level.Controls.Add(this.label4, 0, 3);
            this.Level.Controls.Add(this.label3, 0, 3);
            this.Level.Controls.Add(this.label2, 1, 0);
            this.Level.Controls.Add(this.yourLevelBox, 0, 1);
            this.Level.Controls.Add(this.mapLevelBox, 1, 1);
            this.Level.Controls.Add(this.label1, 0, 0);
            this.Level.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Level.Location = new System.Drawing.Point(3, 3);
            this.Level.Name = "Level";
            this.Level.RowCount = 4;
            this.Level.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Level.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Level.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Level.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Level.Size = new System.Drawing.Size(268, 94);
            this.Level.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monster Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Experience:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Map Level:";
            // 
            // yourLevelBox
            // 
            this.yourLevelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yourLevelBox.FormattingEnabled = true;
            this.yourLevelBox.Location = new System.Drawing.Point(3, 23);
            this.yourLevelBox.Name = "yourLevelBox";
            this.yourLevelBox.Size = new System.Drawing.Size(128, 21);
            this.yourLevelBox.TabIndex = 2;
            this.yourLevelBox.SelectedIndexChanged += new System.EventHandler(this.yourLevelBox_SelectedIndexChanged);
            // 
            // mapLevelBox
            // 
            this.mapLevelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapLevelBox.FormattingEnabled = true;
            this.mapLevelBox.Location = new System.Drawing.Point(137, 23);
            this.mapLevelBox.Name = "mapLevelBox";
            this.mapLevelBox.Size = new System.Drawing.Size(128, 21);
            this.mapLevelBox.TabIndex = 2;
            this.mapLevelBox.SelectedIndexChanged += new System.EventHandler(this.mapLevelBox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Level:";
            // 
            // levelTable
            // 
            this.levelTable.AutoScroll = true;
            this.levelTable.ColumnCount = 3;
            this.levelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.levelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.levelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.levelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelTable.Location = new System.Drawing.Point(3, 103);
            this.levelTable.Name = "levelTable";
            this.levelTable.RowCount = 2;
            this.levelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.levelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.levelTable.Size = new System.Drawing.Size(268, 202);
            this.levelTable.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(274, 24);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Character Name:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(103, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
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
            this.leftColumnTable.ResumeLayout(false);
            this.leftColumnTable.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.Level.ResumeLayout(false);
            this.Level.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel leftColumnTable;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox absolute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label mapFolderLoc;
        private System.Windows.Forms.Label logFileLoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel Level;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox yourLevelBox;
        private System.Windows.Forms.ComboBox mapLevelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel levelTable;
        private System.Windows.Forms.Timer timer2;
    }
}

