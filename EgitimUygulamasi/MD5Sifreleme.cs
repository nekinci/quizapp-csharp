using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace EgitimUygulamasi
{
    class MD5Sifreleme
    {
        public static string MD5Sifrele(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] btr = Encoding.UTF8.GetBytes(str);
            btr = md5.ComputeHash(btr);

            StringBuilder builder = new StringBuilder();

            foreach(byte ba in btr)
            {
                builder.Append(ba.ToString("x2").ToLower());
            }

            return builder.ToString();
        }
    }
}
