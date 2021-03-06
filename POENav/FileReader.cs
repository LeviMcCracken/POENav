﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace nav
{
    class FileReader
    {
        static string zoneLevelFileName = @"\zoneLevel.csv";
        FileStream logFileStream;
        long lastReadLength = 0;
        string logfileStr = "";
        string logFileDispText = "";
        System.Windows.Forms.Label logFileLoc;

        public FileReader(string logfileStrIn, string logFileDispTextIn, System.Windows.Forms.Label logFileLocIn)
        {
            logfileStr = logfileStrIn;
            logFileDispText = logFileDispTextIn;
            logFileLoc = logFileLocIn;
            updateLogFile(logfileStr);
        }

        private static List<string> writeSafeReadAllLines(String path)
        {
            using (var csv = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(csv))
            {
                List<string> file = new List<string>();
                while (!sr.EndOfStream)
                {
                    file.Add(sr.ReadLine());
                }

                return file;
            }
        }

        public int getCharacterLevel(string characterName, string logfileStr)
        {
            List<string> lines = writeSafeReadAllLines(logfileStr);
            
            int lvl = 0;
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                lvl = Parser.findLevel(lines[i], characterName);
                if (lvl != -1)
                {
                    break;
                }
            }
            return lvl;
        }

        public string getNewStringsInLog()
        {
            string s = "";

            if (logFileStream != null)
            {

                logFileStream.Seek(lastReadLength, SeekOrigin.Begin);

                // read 1024 bytes
                byte[] bytes = new byte[1024];
                var bytesRead = logFileStream.Read(bytes, 0, 1024);
                lastReadLength += bytesRead;

                // Convert bytes to string
                s = Encoding.Default.GetString(bytes);
            }
            return s;
        }

        public string logFileLocMethod()
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                logfileStr = file.FileName;

                logFileLoc.Text = logFileDispText + logfileStr;

                Properties.Settings.Default.logFile = logfileStr;
                Properties.Settings.Default.Save();

                return logfileStr;
            }
            return "";
        }

        public void updateLogFile(string logfileStr)
        {
            while (string.IsNullOrEmpty(logfileStr))
            {
                MessageBox.Show("Select POE log file location.");
                logfileStr = logFileLocMethod();
                logFileStream = File.Open(logfileStr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            }
            logFileStream = File.Open(logfileStr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            lastReadLength = logFileStream.Length;
        }

        public static void initZoneLvlReader(ref List<Tuple<string, int, int>> areaLevels, string mapFolder)
        {
            string localMapFolder = mapFolder.Trim() + zoneLevelFileName;
            if(!File.Exists(localMapFolder))
            {
                return;
            }
            
            using (StreamReader file = new StreamReader(localMapFolder))
            {
                string line = "";
                while ((line = file.ReadLine()) != null)
                {
                    string[] partsOfLine = line.Split(',');

                    if (partsOfLine.Length >= 2)
                    {
                        partsOfLine[0] = partsOfLine[0].Trim();
                        partsOfLine[1] = partsOfLine[1].Trim();

                        if (partsOfLine[0] != "")
                        {
                            int parsedLevel = 0;
                            int parsedPart = 0;
                            Int32.TryParse(partsOfLine[1], out parsedLevel);
                            Int32.TryParse(partsOfLine[2], out parsedPart);
                            Tuple<string, int, int> areaEntry = new Tuple<string, int, int>(partsOfLine[0], parsedLevel, parsedPart);

                            areaLevels.Add(areaEntry);
                        }
                    }
                }
            }
        }
    }
}
