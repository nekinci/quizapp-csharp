using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimUygulamasi.View
{
    public partial class UIProfil : UserControl
    {
        private QuestionScreen main;
        public UIProfil()
        {
            InitializeComponent();
        }
        public void setMain(QuestionScreen main)
        {
            this.main = main;
            Model.Calisan calisan = Database.Select.Calisanlar().Find(x => x.Kadi == Session.KullaniciAdiAl());

            txtAd.Text = calisan.Ad;
            txtSoyad.Text = calisan.Soyad;
            txtKadi.Text = calisan.Kadi;
            txtMail.Text = calisan.Mail;
        }
        private void UIProfil_Load(object sender, EventArgs e)
        {
           
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            main.ButonDegistir();
        }


        public bool VerifyTexts()
        {
            string message = "";
            bool check = true;

            if (txtAd.Text == "")
            {
                check = false;
                message += "Ad girilmedi.\n";
            }
            if (txtSoyad.Text == "")
            {
                check = false;
                message += "Soyad girilmedi.\n";
            }
            if (txtKadi.Text == "")
            {
                check = false;
                message += "Kullanıcı adı girilmedi.\n";
            }
            if (txtMail.Text == "")
            {
                check = false;
                message += "Mail girilmedi.\n";
            }
            if (txtSifre.Text == "")
            {
                check = false;
                message += "Şifre girilmedi.\n";
            }

            if (!check)
                MessageBox.Show(message);
            return check;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            if (!VerifyTexts())
                return;

            Model.Calisan calisan = new Model.Calisan();

            calisan.ID = Database.Select.CalisanCekID(Session.KullaniciAdiAl());

            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.Mail = txtMail.Text;
            calisan.Kadi = txtKadi.Text;
            calisan.Sifre = MD5Sifreleme.MD5Sifrele(txtSifre.Text);

            Database.Update.CalisanGuncelle(calisan);
        }
    }
}
