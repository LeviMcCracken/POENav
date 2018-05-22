using System;
using System.Drawing;
using System.Windows.Forms;

namespace nav
{
    class GuiHelper
    {
        public static TextBox tableLevelCreator(int monsterLevel, int colorVal)
        {
            TextBox tableLevel = new TextBox();
            tableLevel.Dock = DockStyle.Fill;
            tableLevel.Width = 140;
            tableLevel.Text = (monsterLevel).ToString();

            tableLevel.BackColor = Color.FromArgb(255 - colorVal, colorVal, 0);
            return tableLevel;
        }

        public static TextBox xpMultiBoxCreator(double xpMult, int colorVal)
        {
            TextBox xpMultiBox = new TextBox();
            xpMultiBox.Dock = DockStyle.Fill;
            xpMultiBox.Width = 140;
            xpMultiBox.Text = System.Math.Round(xpMult * 100, 2).ToString() + "%";

            xpMultiBox.BackColor = Color.FromArgb(255 - colorVal, colorVal, 0);
            return xpMultiBox;
        }

        public static void setStyleLevelTable(ref TableLayoutPanel localLevelTable)
        {
            TableLayoutRowStyleCollection styles = localLevelTable.RowStyles;
            foreach (RowStyle style in styles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 30;
            }
        }


        public static void setRowsAndColumnsMapPhotos(int count, TableLayoutPanel mapsTable)
        {
            int columns = (int)Math.Ceiling(Math.Sqrt(count));
            int rows = columns;
            if ((rows - 1) * columns >= count) { rows--; }
            if (rows == 0) { rows = 1; }

            mapsTable.ColumnCount = columns;
            mapsTable.RowCount = rows;
        }

        public static void clearMaps(TableLayoutPanel mapsTable)
        {
            mapsTable.Controls.Clear();

            mapsTable.ColumnCount = 1;
            mapsTable.RowCount = 1;
        }
    }
}
