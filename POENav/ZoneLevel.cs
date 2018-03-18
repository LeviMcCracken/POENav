using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nav
{
    class ZoneLevel
    {

        List<Tuple<string, int>> zoneLevels;
        string mapFolder;
        bool mapFolderInit = false;

        public ZoneLevel(string mf)
        {
            updateMapFolder(mf);
        }

        public int zoneKnown(string areaName)
        {
            int mapLevel = -1;
            foreach (Tuple<string, int> area in zoneLevels)
            {
                if (area.Item1 == areaName)
                {
                    mapLevel = area.Item2;
                }
            }
            return mapLevel;
        }

        public void updateMapFolder(string mf)
        {
            zoneLevels = new List<Tuple<string, int>>();
            mapFolder = mf;
            initZoneLvl(ref zoneLevels, mapFolder);
        }
        
        private void initZoneLvl(ref List<Tuple<string, int>> areaLevels, string mapFolder)
        {
            if (mapFolder != "" && !mapFolderInit)
            {
                FileReader.initZoneLvlReader(ref areaLevels, mapFolder);
                mapFolderInit = true;
            }
        }

        public void saveZoneLevel(string areaName, int mapLevel)
        {
            if (!isZoneLevelKnown(areaName))
            {
                saveZoneLevelLocally(areaName, mapLevel);
                saveZoneLevelToFile(areaName, mapLevel);
            }
        }

        private void saveZoneLevelToFile(string areaName, int mapLevel)
        {
            if (mapFolder != "")
            {
                using (StreamWriter outputFile = new StreamWriter(mapFolder + @"\zoneLevel.csv", true))
                {
                    string s = areaName.Trim() + "," + mapLevel;
                    outputFile.WriteLine(s);
                }
            }
        }

        private void saveZoneLevelLocally(string areaName, int mapLevel)
        {
            Tuple<string, int> newEntry = new Tuple<String, int>(areaName, mapLevel);
            zoneLevels.Add(newEntry);
        }

        private bool isZoneLevelKnown(string areaName)
        {
            foreach (Tuple<string, int> area in zoneLevels)
            {
                if (area.Item1 == areaName.Trim())
                {
                    return true; ;
                }
            }
            return false;
        }
    }
}
