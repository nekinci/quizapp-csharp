using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimUygulamasi
{
    class DatabaseInf
    {
        public static string Veritabani { get { return "server=localhost;Port=3320;userid=root;pwd=1234;database=egitim;charset=utf8;convertzerodatetime=true"; } }
        public static string Veritabani0 { get { return "server=localhost;userid=root;pwd=1234;Port=3320;"; } }
    }
}
