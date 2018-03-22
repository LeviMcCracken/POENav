using System;

namespace nav
{
    class Parser
    {
        public static int findLevel(string s, string characterName)
        {
            int indexName = s.LastIndexOf(characterName.Trim() + " ");
            int indexLevel = s.IndexOf("is now level");

            int ret = -1;
            if (indexName != -1 && indexLevel != -1 && indexLevel < 2000)
            {
                s = s.Substring(indexLevel + 13).Trim();
                int index = s.IndexOf("\r");
                if (index > 0)
                {
                    s = s.Substring(0, index).Trim();
                }
                Int32.TryParse(s, out ret);
                return ret;
            }
            return ret;
        }
    }
}
