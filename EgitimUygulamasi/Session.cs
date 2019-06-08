using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimUygulamasi
{
    class Session
    {
        private static int SessionID = 0;
        private static string UserName;


        private Session()
        {

        }

        public static void OturumAc(string _UserName)
        {
            SessionID++;
           if(UserName == null)
            {
                UserName = _UserName;
            }
            else
            {
                MessageBox.Show("Kapanmamış oturum varken yeni oturum açamazsınız.İşlemleriniz eski oturum üzerinden devam eder.");
            }
        }

        public static void OturumKapat()
        {
            UserName = null;
        }

        public static string KullaniciAdiAl() { return UserName; }

    }
}
