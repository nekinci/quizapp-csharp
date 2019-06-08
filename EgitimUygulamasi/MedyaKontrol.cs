using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimUygulamasi
{
    class MedyaKontrol
    {

        private MedyaKontrol() { }
        private static StringComparison ignore = StringComparison.CurrentCultureIgnoreCase;
        public static bool ResimKontrol(string dosyaadi)
        {
            return dosyaadi.EndsWith(".jpg", ignore) || dosyaadi.EndsWith(".jpeg", ignore) || dosyaadi.EndsWith(".bmp", ignore) || dosyaadi.EndsWith(".png", ignore) || dosyaadi.EndsWith(".tiff", ignore) || dosyaadi.EndsWith(".tif", ignore) || dosyaadi.EndsWith(".gif", ignore);
        }
        public static bool VideoKontrol(string dosyaadi)
        {
            return dosyaadi.EndsWith(".mp4", ignore) || dosyaadi.EndsWith(".wmv", ignore) || dosyaadi.EndsWith(".mp3", ignore) || dosyaadi.EndsWith(".mkv", ignore) || dosyaadi.EndsWith("asf", ignore) || dosyaadi.EndsWith("avi", ignore) || dosyaadi.EndsWith("mov", ignore);
        }
    }
}
