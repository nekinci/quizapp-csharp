using EgitimUygulamasi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimUygulamasi.View
{
    public partial class YeniMedya : Form
    {
        private string dosyayolu = "";
        private string dosyaadi = "";
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Media\";
        private MedyaDegistir medyaDegistir1;
        private int selectedId;

        public YeniMedya()
        {
            InitializeComponent();
        }

        public void setYeniMedya(MedyaDegistir medyaDegistir1, int selectedId)
        {
            this.medyaDegistir1 = medyaDegistir1;
            this.selectedId = selectedId;
            cmbKategori.Items.Add(Database.Select.KategoriCekMedya(selectedId).Ad);
            cmbKategori.Items.Add(Database.Select.KategoriCekMedya(selectedId).Ad);
        }

        private void YeniMedya_Load(object sender, EventArgs e)
        {

        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Medya seç";
            openFileDialog1.Filter = "JPEG |*.jpg|GIF|*.gif|MP4 Video|*.mp4|WMV Video|*.wmv|MP3 Audio|*.mp3";

            dosyayolu = "";
            dosyaadi = "";


            if (!Directory.Exists(appPath)) Directory.CreateDirectory(appPath); // Path yoksa oluştur

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyayolu = openFileDialog1.FileName;
                dosyaadi = openFileDialog1.SafeFileName;
                txtDosya.Text = dosyayolu;
            }

            Medya medya = new Medya();
            medya.Path = dosyayolu;
            vlcPlayer1.SetMedia(medya);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (VerifyTexts())
            {
                Model.Medya _medya = new Model.Medya();

                _medya.Ad = txtMedyaAdi.Text;
                _medya.ID = 0;
                _medya.KategoriID = Database.Select.KategoriCekMedya(selectedId).ID;
                _medya.Path = appPath + dosyaadi;
                try
                {
                    File.Copy(dosyayolu, appPath + dosyaadi, true);
                    if (Database.Insert.MedyaEkleme(_medya))
                    {
                        MessageBox.Show("Başarıyla eklendi");
                        medyaDegistir1.MedyaYukle();
                    }
                    else
                    {
                        MessageBox.Show("Eklenirken bir sorun oluştu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": Dosya yüklenirken bir sorun oluştu!");
                }
            }
        }

        public bool VerifyTexts()
        {
            bool kontrol = true;
            string message = "";

            if (txtMedyaAdi.Text == "")
            {
                message += "Medya adi girilmedi.\n"; kontrol = false;
            }
            if (dosyayolu == "")
            {
                message += "Dosya seçilmedi.\n";
                kontrol = false;
            }
            if (cmbKategori.SelectedIndex < 0)
            {
                message += "Kategori seçilmedi.\n"; kontrol = false;
            }
            if (txtDosya.Text == "")
            {
                message += "Dosya ismi bölümü boş!\n"; kontrol = false;
            }

            if (!kontrol)
                MessageBox.Show(message);
            return kontrol;
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            Medya medya = new Medya();
            medya.Path = txtURL.Text;
            vlcPlayer2.SetMedia(medya);
        }

        public bool VerifyTexts1()
        {
            bool kontrol = true;
            string message = "";

            if (txtIsim.Text == "")
            {
                message += "Medya adi girilmedi.\n"; kontrol = false;
            }
            if (cmbKategori.SelectedIndex < 0)
            {
                message += "Kategori seçilmedi.\n"; kontrol = false;
            }
            if (txtURL.Text == "")
            {
                message += "URL girilmedi!\n"; kontrol = false;
            }

            if (!kontrol)
                MessageBox.Show(message);
            return kontrol;
        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (VerifyTexts1())
            {
                Model.Medya _medya = new Model.Medya();

                _medya.Ad = txtIsim.Text;
                _medya.ID = 0;
                _medya.KategoriID = Database.Select.KategoriCekMedya(selectedId).ID;
                _medya.Path = txtURL.Text;
                try
                {
                    if (Database.Insert.MedyaEkleme(_medya))
                    {
                        MessageBox.Show("Başarıyla eklendi");
                        medyaDegistir1.MedyaYukle();
                    }
                    else
                    {
                        MessageBox.Show("Eklenirken bir sorun oluştu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": Dosya yüklenirken bir sorun oluştu!");
                }
            }
        }
    }
}
