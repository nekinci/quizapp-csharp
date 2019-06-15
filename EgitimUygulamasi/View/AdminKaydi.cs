using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimUygulamasi.View
{
    public partial class AdminKaydi : Form
    {
        public AdminKaydi()
        {
            InitializeComponent();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Model.Admin admin = new Model.Admin();
            admin.Ad = txtAd.Text;
            admin.Soyad = txtSoyad.Text;
            admin.Kadi = txtKadi.Text;
            admin.Email = txtMail.Text;
            admin.Sifre = txtSifre.Text;

            Database.Insert.AdminEkleme(admin);
            Dispose();
        }
    }
}
