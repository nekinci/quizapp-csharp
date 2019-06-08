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

namespace EgitimUygulamasi.View
{
    public partial class StepOneApp : UserControl
    {
        private Kategori _kategori;
        private QuestionScreen main;
        private Model.Calisan calisan = Database.Select.Calisanlar().Find(x => x.ID == Database.Select.CalisanCekID(Session.KullaniciAdiAl()));
        public StepOneApp()
        {
            InitializeComponent();
            lblHosgeldiniz.Text = "Hoşgeldiniz " + calisan.Ad + " "+calisan.Soyad;
        }

        public void setMain(QuestionScreen main)
        {
            this.main = main;
        }
        int saniye = 0;
        List<Kategori> liste = new List<Kategori>();

        private void btnKategori_Click(object sender, EventArgs e)
        {
            if (cmbZorluk.SelectedIndex < 0)
            {
                MessageBox.Show("Öncelikle soru zorluk türünü belirtmelisiniz.");
            }
            else
            {
                string zorluk = cmbZorluk.Items[cmbZorluk.SelectedIndex].ToString();
                liste = Database.Select.GetCategories(zorluk);

                if (liste.Count > 0)
                {
                    btnKategori.Visible = false;
                    btnSoruSor.Visible = false;
                    pnlKategori.Size = new Size(780, 491);
                    pnlKategori.Dock = DockStyle.Fill;
                    lblHosgeldiniz.Visible = false;
                    lblBilgilendirme.Visible = false;
                    timer1.Start();
                }
                else
                    MessageBox.Show("Soru çekilemedi. \nOlası Nedenler: \nKategoriye ait hiçbir soru eklenmedi.\nZorluk Türünde soru yok.\nTüm soruları cevapladınız(Yöneticinizin belirlediği süre boyunca aynı soruyu göremeyeceksiniz)\n--Lütfen Yöneticinizle iletişime geçin--");
            }

        }



        private void StepOneApp_Load(object sender, EventArgs e)
        {
            timer1.Interval = 250;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (saniye != 3000)
            {
                saniye += 250;
                pnlKategori.BackColor = new MaterialColors().get(new Random().Next(0, 18));
                _kategori = liste.ElementAt(new Random().Next(0, liste.Count));
                lblKategori.Text = _kategori.Ad;
            }
            else
            {
                timer1.Stop(); saniye = 0;
                lblHosgeldiniz.Visible = true;
                lblBilgilendirme.Visible = true;
                lblKategori.Visible = true;
                btnSoruSor.Visible = true;
                btnKategori.Visible = true;
                btnSoruSor.Enabled = true;
                pnlKategori.Dock = DockStyle.None;
                pnlKategori.Size = new Size(299, 170);
                lblHosgeldiniz.Text = "Kategori belirlendi!";
                lblBilgilendirme.Text = "Herşey yolunda! Soru sor butonuna basın.";
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnSoruSor_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            string kategori = lblKategori.Text;
            string zorluk = cmbZorluk.SelectedItem.ToString();
            SoruBilgileri.KategoriAdi = kategori;
            SoruBilgileri.ZorlukSeviyesi = zorluk;
            main.SoruAktarici(kategori, zorluk);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbZorluk_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBilgilendirme.Text = "Tamam, Kategori seç'e basın.";
        }

        private void lblHosgeldiniz_Click(object sender, EventArgs e)
        {

        }

        public void Resetle()
        {
            lblHosgeldiniz.Text = "Tekrar hoşgeldiniz, " + calisan.Ad + " " + calisan.Soyad;
            lblBilgilendirme.Text = "Önce kategori seçin";
            btnSoruSor.Enabled = false;
            lblKategori.Text = "<Kategori Adi>";
            cmbZorluk.SelectedIndex = -1;
        }
    }
}
