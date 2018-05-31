
#define ZONELEVELINIT

using System;
using System.Collections.Generic;
using System.IO;



namespace nav
{
    class ZoneLevel
    {

        List<Tuple<string, int, int>> zoneLevels;
        string mapFolder;
        bool mapFolderInit = false;
        
        public ZoneLevel(string mf)
        {
            updateMapFolder(mf);
        }

        public int zoneKnown(string areaName, int partNumber)
        {
            int mapLevel = -1;
            foreach (Tuple<string, int, int> area in zoneLevels)
            {
                if (area.Item1 == areaName.Trim() || area.Item3 == partNumber)
                {
                    mapLevel = area.Item2;
                }
            }
            return mapLevel;
        }

        public void updateMapFolder(string mf)
        {
            zoneLevels = new List<Tuple<string, int, int>>();
            mapFolder = mf;
            initZoneLvl(ref zoneLevels, mapFolder);
        }
        
        private void initZoneLvl(ref List<Tuple<string, int, int>> areaLevels, string mapFolder)
        {
            if (mapFolder != "" && !mapFolderInit)
            {
                FileReader.initZoneLvlReader(ref areaLevels, mapFolder);
                mapFolderInit = true;
            }
        }

        public void saveZoneLevel(string areaName, int mapLevel, int partNumber)
        {
#if ZONELEVELINIT
            if (areaName != "")
#else
            if (areaName != "" && !isZoneLevelKnown(areaName))
#endif
            {
                saveZoneLevelLocally(areaName.Trim(), mapLevel, partNumber);
                saveZoneLevelToFile(areaName.Trim(), mapLevel, partNumber);
            }

        }

        private void saveZoneLevelToFile(string areaName, int mapLevel, int partNumber)
        {
            if (mapFolder != "")
            {
                using (StreamWriter outputFile = new StreamWriter(mapFolder + @"\zoneLevel.csv", true))
                {
                    string s = areaName.Trim() + "," + mapLevel + "," + partNumber;
                    outputFile.WriteLine(s);
                }
            }
        }

        private void saveZoneLevelLocally(string areaName, int mapLevel, int partNumber)
        {
            Tuple<string, int, int> newEntry = new Tuple<String, int, int>(areaName, mapLevel, partNumber);
            zoneLevels.Add(newEntry);
        }

        private bool isZoneLevelKnown(string areaName, int partNumber)
        {
            foreach (Tuple<string, int, int> area in zoneLevels)
            {
                if (area.Item1 == areaName.Trim() && area.Item3 == partNumber)
                {
                    return true; ;
                }
            }
            return false;
        }
    }
}
