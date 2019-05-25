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
    public partial class Calisan : UserControl
    {
        private Main main;
        public Calisan()
        {
            InitializeComponent();
        }

        public void setMain(Main main)
        {
            this.main = main;
        }

        private void Calisan_Load(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            this.temizle();
        }

        private void temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtKadi.Clear();
            txtSifre.Clear();
            txtMail.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (VerifyTexts())
            {
                Model.Calisan _calisan = new Model.Calisan();
                _calisan.Ad = txtAd.Text;
                _calisan.Soyad = txtSoyad.Text;
                _calisan.Kadi = txtKadi.Text;
                _calisan.Mail = txtMail.Text;
                _calisan.Sifre = MD5Sifreleme.MD5Sifrele(txtSifre.Text);

                Database.Insert.CalisanEkleme(_calisan);
                this.temizle();
                this.main.YenidenCiz();
            }
        }

        private bool VerifyTexts()
        {
            bool kontrol = true;
            string message = "";
            if (txtAd.Text == "")
            {
                message += "Ad girilmedi. \n"; kontrol = false;
            }
            if (txtSoyad.Text == "")
            {
                message += "Soyad girilmedi. \n"; kontrol = false;
            }
            if (txtKadi.Text == "")
            {
                message += "Kullanıcı adı girilmedi. \n"; kontrol = false;
            }
            if (txtSifre.Text == "")
            {
                message += "Kullanıcı şifresi girilmedi."; kontrol = false;
            }

            if (txtMail.Text == "")
            {
                message += "Mail girilmedi."; kontrol = false;
            }
            if (!kontrol)
                MessageBox.Show(message);

            return kontrol;
        }
    }
}
