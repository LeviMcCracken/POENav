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

        public Form1()
        {

            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                lastReadLength = 0;

                fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

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
            foreach (string line in lines)
            {
                int index = line.IndexOf(entryHumanString);
                if (index != -1)
                {
                    human.Text = line.Substring(index + entryHumanStringLen).Replace(" ", "").Replace("'","").Replace(".","");
                }
                int indexAbs = line.IndexOf(entryAbsoluteString);
                if (indexAbs != -1)
                {
                    absolute.Text = line.Substring(indexAbs + entryAbsoluteStringLen);
                }
            }

            //textBox.Text = area;
        }

    }
}
