using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EgitimUygulamasi.Model;
using EgitimUygulamasi.Database;

namespace EgitimUygulamasi
{
    public partial class KategoriEkleme : UserControl
    {
        public Main main;

        public void setMain(Main main)
        {
            this.main = main;
        }
        public KategoriEkleme()
        {
            InitializeComponent();
        }

        public void temizle()
        {
            txtAd.Clear();
            txtAciklama.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (VerifyTexts())
            {
                int id = 0;
                string ad = txtAd.Text;
                string aciklama = txtAciklama.Text;

                Kategori _kategori = new Kategori();
                _kategori.ID = id;
                _kategori.Ad = ad;
                _kategori.Aciklama = aciklama;
                Insert.KategoriEkleme(_kategori);
                this.temizle();
            }
        }


        public bool VerifyTexts()
        {
            bool kontrol = true;
            string message = "";
            if (txtAd.Text == "")
            {
                kontrol = false;
                message += "Kategori adı girilmedi\n";
            }

            if (txtAciklama.Text == "")
            {
                kontrol = false;
                message += "Açıklama girilmedi";
            }

            if (!kontrol)
            {
                MessageBox.Show(message);
            }
            return kontrol;

        }

        private void KategoriEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}
