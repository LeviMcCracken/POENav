using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace nav
{
    class FileReader
    {
        static string zoneLevelFileName = @"\zoneLevel.csv";
        FileStream logFileStream;
        long lastReadLength = 0;

        private static string[] writeSafeReadAllLines(String path)
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

        public static int getCharacterLevel(string characterName, string logfileStr)
        {
            string[] lines = writeSafeReadAllLines(logfileStr);

            int lvl = 0;
            for (int i = lines.Length - 1; i >= 0; i--)
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

        public void updateLogFile(string logfileStr)
        {
            logFileStream = File.Open(logfileStr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            lastReadLength = logFileStream.Length;
        }

        public static void initZoneLvlReader(ref List<Tuple<string, int>> areaLevels, string mapFolder)
        {
            string localMapFolder = mapFolder.Trim() + zoneLevelFileName;

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

                        if (partsOfLine[0] != "")
                        {
                            int parsedNum = 0;
                            Int32.TryParse(partsOfLine[1], out parsedNum);
                            Tuple<string, int> areaEntry = new Tuple<string, int>(partsOfLine[0], parsedNum);

                            areaLevels.Add(areaEntry);
                        }
                    }
                }
            }
        }
    }
}
