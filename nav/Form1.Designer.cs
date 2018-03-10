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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.human = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.absolute = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // human
            // 
            this.human.Location = new System.Drawing.Point(1, -2);
            this.human.Name = "human";
            this.human.ReadOnly = true;
            this.human.Size = new System.Drawing.Size(345, 96);
            this.human.TabIndex = 0;
            this.human.Text = "";
            // 
            // absolute
            // 
            this.absolute.Location = new System.Drawing.Point(1, 100);
            this.absolute.Name = "absolute";
            this.absolute.ReadOnly = true;
            this.absolute.Size = new System.Drawing.Size(345, 96);
            this.absolute.TabIndex = 1;
            this.absolute.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 630);
            this.Controls.Add(this.absolute);
            this.Controls.Add(this.human);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox human;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox absolute;
    }
}

