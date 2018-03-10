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
        public Form1()
        {

            string path = "";
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
            }

            InitializeComponent();

            FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            // Seek 1024 bytes from the end of the file
            fs.Seek(-1024, SeekOrigin.End);
            // read 1024 bytes
            byte[] bytes = new byte[1024];
            fs.Read(bytes, 0, 1024);
            // Convert bytes to string
            string s = Encoding.Default.GetString(bytes);
            // or string s = Encoding.UTF8.GetString(bytes);
            // and output to console

            textBox.Text = s;

        }
    }
}
