using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace EgitimUygulamasi
{
    class MailServisi
    {

        public static bool SifreSifirla(string mailAddress,string code)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("destekservisi@outlook.com");
            message.To.Add(mailAddress);

            message.Subject = "Şifre Sıfırlama";
            message.Body = "Lütfen aşağıda yer alan kodu programda ilgili yere giriniz.\nŞifre sıfırlama için kodunuz: "+code+"\nLütfen aşağıda yer alan kodu yöneticiniz dahil kimseyle paylaşmayın.";

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("niyaziekinci5050@gmail.com", "++-5432704++-");
            client.Port = 587;

            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;

            object userState = message;
            bool kontrol = true;

            try
            {
                client.Send(message);
                MessageBox.Show("Gönderildi");
            }catch(SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message + " : Mail Gönderme Hatası", "Hata");
            }
            return kontrol;
        }
    }
}
