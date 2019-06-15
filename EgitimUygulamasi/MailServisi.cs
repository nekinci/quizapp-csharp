using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;

namespace EgitimUygulamasi
{
    class MailServisi
    {

        public static bool SifreSifirla(string mailAddress, string code)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("niyaziekinci5050@gmail.com", "++-5432704++-"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            client.Send("niyaziekinci5050@gmail.com", "160204044@ogr.alanya.edu.tr", "test", "testbody");
            MessageBox.Show("Gönderildi.");

            return true;
        }
    }
}
