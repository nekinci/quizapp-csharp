using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimUygulamasi
{
    class MaterialColors
    {
        private Color[] colors = new Color[18];
        public MaterialColors()
        {
            colors[0] = Color.FromArgb(244, 67, 54);
            colors[1] = Color.FromArgb(33, 150, 243);
            colors[2] = Color.FromArgb(139, 195, 74);
            colors[3] = Color.FromArgb(255, 235, 59);
            colors[4] = Color.FromArgb(13, 71, 161);
            colors[5] = Color.FromArgb(0, 188, 212);
            colors[6] = Color.FromArgb(92, 107, 192);
            colors[7] = Color.FromArgb(255, 87, 34);
            colors[8] = Color.FromArgb(0, 150, 136);
            colors[9] = Color.FromArgb(255, 193, 7);
            colors[10] = Color.FromArgb(255, 87, 34);
            colors[11] = Color.FromArgb(38, 50, 56);
            colors[12] = Color.FromArgb(255, 51, 0);
            colors[13] = Color.FromArgb(9, 184, 62);
            colors[14] = Color.FromArgb(221, 75, 57);
            colors[15] = Color.FromArgb(26, 183, 234);
            colors[16] = Color.FromArgb(41, 128, 185);
            colors[17] = Color.FromArgb(192, 57, 43);
        }

        public Color get(int i)
        {
            return colors[i];
        }
    }
}
