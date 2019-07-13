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
    public partial class MedyaGuncelleme : Form
    {
        public MedyaGuncelleme()
        {
            InitializeComponent();
        }
        private Model.Medya medya;
        private Model.Medya updatedMedya;

        private IMedya media;
        private void MedyaGuncelleme_Load(object sender, EventArgs e)
        {

        }

        public void SetMedya(Medya medya,IMedya media)
        {
            this.medya = medya;
            this.media = media;
            txtAd.Text = medya.Ad;
            txtPath.Text = medya.Path;
        }
        private string dosyayolu = "";
        private string dosyaadi = "";
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Media\";

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            updatedMedya.Ad = txtAd.Text;
            updatedMedya.Path = null;
            updatedMedya.Path = appPath + dosyaadi;
            try
            {
                File.Copy(dosyayolu, appPath + dosyaadi, true);
                if (Database.Update.MedyaGuncelleme(updatedMedya))
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir sorun oluştu: " + ex.Message);
            }
            media.Guncelle();
            this.Dispose();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            MedyaGor medya = new MedyaGor();
            medya.setMedya(this.medya);
            medya.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen Medya dosyasını seçin";
            openFileDialog1.Filter = "Medya|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.gif;*.mp4;*.wmv;*.mp3;*.mkv;*.asf;*.avi;*.mov|JPEG |*.jpg|GIF|*.gif|MP4 Video|*.mp4|WMV Video|*.wmv|MP3 Audio|*.mp3";

            dosyayolu = "";
            dosyaadi = "";


            if (!Directory.Exists(appPath)) Directory.CreateDirectory(appPath); // Path yoksa oluştur

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyayolu = openFileDialog1.FileName;
                dosyaadi = openFileDialog1.SafeFileName;
                txtPath.Text = dosyayolu;
                MessageBox.Show(dosyaadi);
                updatedMedya = new Model.Medya();
                updatedMedya.ID = medya.ID;
                updatedMedya.KategoriID = medya.KategoriID;
                updatedMedya.Path = dosyayolu;
                btnGoruntule2.Enabled = true;
            }
        }

        private void btnGoruntule2_Click(object sender, EventArgs e)
        {

            MedyaGor medya = new MedyaGor();
            medya.setMedya(this.updatedMedya);
            medya.Show();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            updatedMedya = new Model.Medya();
            updatedMedya.ID = medya.ID;
            updatedMedya.KategoriID = medya.KategoriID;
            updatedMedya.Path = txtURL.Text;
            btnGoruntule2.Enabled = true;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            updatedMedya.Ad = txtAd.Text;
            updatedMedya.Path = null;
            updatedMedya.Path = txtURL.Text;
            try
            {
                if (Database.Update.MedyaGuncelleme(updatedMedya))
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir sorun oluştu: " + ex.Message);
            }
            media.Guncelle();
            this.Dispose();
        }
    }
}
