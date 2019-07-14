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

namespace EgitimUygulamasi.View
{
    public partial class Ayarlar : UserControl
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        private Main main;


        public void setMain(Main main)
        {
            this.main = main;
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            Model.ZorlukPuanlari z = new Model.ZorlukPuanlari();

            z = Database.Select.ZorlukPuanlari();

            txtKolay.Text = z.Kolay.ToString();
            txtOrta.Text = z.Orta.ToString();
            txtZor.Text = z.Zor.ToString();

            Model.Ayarlar ayar = Database.Select.AyarCek();

            if (ayar.GeriCekilme == 1)
                gericekilme.Checked = true;
            else
                gericekilme.Checked = false;
            txtGunSayisi.Text = ayar.GunSayisi.ToString();

            if (ayar.YanlisCevap == 1)
                yanliscevap.Checked = true;
            else
                yanliscevap.Checked = false;



        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            int kolay, orta, zor;
            kolay = Convert.ToInt32(txtKolay.Text);
            orta = Convert.ToInt32(txtOrta.Text);
            zor = Convert.ToInt32(txtZor.Text);

            Model.ZorlukPuanlari z = new Model.ZorlukPuanlari();
            z.Kolay = kolay;
            z.Orta = orta;
            z.Zor = zor;

            Database.Update.ZorlukPuaniGuncelle(z);

            main.YenidenCiz();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (gericekilme.Checked == false)
                Database.Update.AyarGuncelle(0, 1);
            else
                Database.Update.AyarGuncelle(1, 1);
            main.YenidenCiz();

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Database.Update.AyarGuncelle(Convert.ToInt32(txtGunSayisi.Text), 2);
            main.YenidenCiz();

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            if (yanliscevap.Checked == false)
                Database.Update.AyarGuncelle(0, 3);
            else
                Database.Update.AyarGuncelle(1, 3);
            main.YenidenCiz();


        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {

        }

        string dosyayolu = "";
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Media\";
        private string backup_files = "";
        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Veritabanını yedeklemek istediğiniz yeri seçiniz";
            saveFileDialog1.Filter = "MySqlBackup File |*.sql";
            saveFileDialog1.DefaultExt = "sql";

            DialogResult result = saveFileDialog1.ShowDialog();
            dosyayolu = saveFileDialog1.FileName;
            backup_files = Path.GetDirectoryName(saveFileDialog1.FileName) + @"\backup_files\";

            if (result == DialogResult.OK)
            {
                txtPath.Text = dosyayolu;
                btnYedekle.Enabled = true;
            }

            
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            txtPath.Clear();
            Database.Backup.Yedekle(dosyayolu);
            var dosyalar = new DirectoryInfo(appPath).GetFiles("*.*");
            if (!Directory.Exists(backup_files)) Directory.CreateDirectory(backup_files); // Path yoksa oluştur
            try
            {
                foreach (FileInfo dosya in dosyalar)
                {
                    dosya.CopyTo(backup_files + dosya.Name, true);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Veritabanı tamam ama medya dosyaları yedeklenirken sorun oluştu büyük ihtimalle dosya izin yetkilerinde sorun var. " + ex.Message);
            }
            btnYedekle.Enabled = false;
        }

        string yuklenendosya = "";
        string backupfiles = "";
        private void btnGozatYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Yüklenecek veritabanını seçin";
            openFileDialog1.Filter = "MySqlBackup File|*.sql";


            DialogResult result = openFileDialog1.ShowDialog();
            yuklenendosya = openFileDialog1.FileName;
            backupfiles = Path.GetDirectoryName(openFileDialog1.FileName) + @"\backup_files\";

            if(result == DialogResult.OK)
            {
                txtYuklePath.Text = yuklenendosya;
                btnYukle.Enabled = true;
            }

        }

        private void btnYukle_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Şu anki programda olan bütün veriler silinecek ve eskiden eklediğiniz sorular ve çalışanlar geri yüklenecek, devam etmek istediğinize emin misiniz", "UYARI", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);

            if (result == DialogResult.No)
                return;

            var dosyalar = new DirectoryInfo(backupfiles).GetFiles("*.*");

            try
            {
                foreach (FileInfo dosya in dosyalar)
                {
                    dosya.CopyTo(appPath + dosya.Name, true);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Medya dosyalarının geri yüklenmesinde sorun var: " + ex.Message);
            }
            Database.Backup.GeriYukle(yuklenendosya);
            txtYuklePath.Clear();
            btnYukle.Enabled = false;
        }
    }

       
    }

