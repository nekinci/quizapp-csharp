using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EgitimUygulamasi.Properties;
using System.Diagnostics;

namespace EgitimUygulamasi.View
{
    public partial class IcerikEkleme : UserControl
    {
        private List<Model.Kategori> _kategori;
        private List<string> strkategori = new List<string>();
        private string dosyayolu = "";
        private string dosyaadi = "";
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Media\";
        private SoruEkleme soruEkleme;
        private MedyaYukle main1;

        public void setSoruEkleme(SoruEkleme soruEkleme,MedyaYukle main1)
        {
            this.soruEkleme = soruEkleme;
            this.main1 = main1;
            
        }
        public IcerikEkleme()
        {
            InitializeComponent();
        }

        

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Lütfen Medya dosyasını seçin";
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

            pictureMedya.ImageLocation = dosyayolu;

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (VerifyTexts())
            {
                Model.Medya medya = new Model.Medya();
                medya.ID = 0;
                medya.Ad = txtIsim.Text;
                medya.KategoriID = _kategori.ElementAt(cmbKategori.SelectedIndex).ID;
                medya.Path = appPath + dosyaadi;
                try
                {
                    File.Copy(dosyayolu, appPath + dosyaadi, true);
                    if (Database.Insert.MedyaEkleme(medya))
                    {

                        this.soruEkleme.MedyaYukle();
                        this.main1.CloseWindow();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir sorun oluştu: " + ex.Message);
                }
               
            }
        }

        public bool VerifyTexts()
        {
            bool kontrol = true;
            string message = "";

            if (txtIsim.Text == "")
            {
                message += "İsim alanı boş bırakıldı. \n";
                kontrol = false;
            }

            if (txtDosya.Text == "")
            {
                message += "Dosya kısmında bir sorun var. \n";
                kontrol = false;
            }

            if (cmbKategori.SelectedIndex < 0)
            {
                message += "Kategori seçilmedi.\n";
                kontrol = false;
            }

            if (dosyayolu == "")
            {
                message += "Dosya seçilmedi.\n";
                kontrol = false;
            }

            if (!kontrol)
                MessageBox.Show(message);
            return kontrol;
        }

        private void IcerikEkleme_Load(object sender, EventArgs e)
        {
            _kategori = Database.Select.KategoriCek();
            foreach (var i in _kategori)
            {
                strkategori.Add(i.Ad);
            }

            cmbKategori.DataSource = strkategori;
            cmbKategori.SelectedIndex = -1;

        }
    }
}
