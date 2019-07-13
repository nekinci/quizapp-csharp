using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using EgitimUygulamasi.Model;

namespace EgitimUygulamasi.View
{
    public partial class SoruEkleme : UserControl
    {
        private Main main;
        public SoruEkleme()
        {
            InitializeComponent();
        }

        public void setMain(Main main)
        {
            this.main = main;
        }
        public void MedyaYukle()
        {

            _medyalar = Database.Select.MedyaCek(_kategoriler.ElementAt(cmbKategori.SelectedIndex).ID);
            imageLists.Items.Clear();
            foreach (var i in _medyalar)
            {
                imageLists.Items.Add(i);
            }
            imageLists.DisplayMember = "Ad";
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtE_Click(object sender, EventArgs e)
        {

        }

        private void txtD_Click(object sender, EventArgs e)
        {

        }

        private void txtC_Click(object sender, EventArgs e)
        {

        }

        private void txtB_Click(object sender, EventArgs e)
        {

        }

        private void txtA_Click(object sender, EventArgs e)
        {

        }

        private void btnIlerle_Click(object sender, EventArgs e)
        {
            if (VerifyTextsA())
                soru.SelectedTab = secenektab;
        }

        public bool VerifyTextsA()
        {
            string message = "";
            bool kontrol = true;

            if (txtSoruBasligi.Text == "")
            {
                message += "Soru Başlığı girilmedi.\n"; kontrol = false;
            }
            if (txtSure.Text == "")
            {
                message += "Süre girilmedi.\n"; kontrol = false;
            }
            if (cmbKategori.SelectedIndex < 0)
            {
                message += "Kategori seçilmedi.\n"; kontrol = false;
            }

            if (cmbZorluk.SelectedIndex < 0)
            {
                message += "Zorluk seviyesi seçilmedi.\n"; kontrol = false;
            }

            if (!kontrol)
                MessageBox.Show(message);
            return kontrol;
        }

        public bool VerifyTextsB()
        {
            string message = "";
            bool kontrol = true;
            if (checkedklasik)
                return true;

            if (txtA.Text == "")
            {
                message += "A seçeneği girilmedi.\n"; kontrol = false;
            }
            if (txtB.Text == "")
            {
                message += "B seçeneği girilmedi.\n"; kontrol = false;
            }
            if (txtC.Text == "")
            {
                message += "C seçeneği girilmedi.\n"; kontrol = false;
            }
            if (txtD.Text == "")
            {
                message += "D seçeneği girilmedi.\n"; kontrol = false;
            }
            if (txtE.Text == "")
            {
                message += "E seçeneği girilmedi.\n"; kontrol = false;
            }

            if (cmbDogru.SelectedIndex < 0)
            {
                message += "Doğru cevap seçilmedi. \n"; kontrol = false;
            }



            if (!kontrol)
                MessageBox.Show(message);

            return kontrol;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (VerifyTextsA() && VerifyTextsB())
            {
                Model.Soru _soru = new Model.Soru();
                Model.Secenekler _secenekler = new Model.Secenekler();

                _soru.ID = 0;
                _soru.KategoriID = _kategoriler.ElementAt(cmbKategori.SelectedIndex).ID;
                _soru.SoruBasligi = txtSoruBasligi.Text;
                _soru.Sure = Convert.ToInt32(txtSure.Text);
                _soru.ZorlukSeviyesi = cmbZorluk.SelectedItem.ToString();
                if (imageLists.SelectedIndex > -1)
                    _soru.MedyaID = ((Medya)imageLists.SelectedItem).ID;
                else
                    _soru.MedyaID = -1;

                _soru.KlasikSoru = checkedklasik;
                _secenekler.ASecenegi = txtA.Text;
                _secenekler.BSecenegi = txtB.Text;
                _secenekler.CSecenegi = txtC.Text;
                _secenekler.DSecenegi = txtD.Text;
                _secenekler.ESecenegi = txtE.Text;
                if (cmbDogru.SelectedIndex < 0)
                    _secenekler.DogruCevap = "";
                else
                    _secenekler.DogruCevap = cmbDogru.SelectedItem.ToString();
                _secenekler.SoruID = _soru.ID;

                BirlesikSoru soru = new BirlesikSoru();
                soru.soru = _soru;
                soru.secenekler = _secenekler;

                Database.Insert.SoruEkleme(soru);
                this.temizle();
                this.main.YenidenCiz();
            }
        }
        private void temizle()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtE.Text = "";
            cmbDogru.SelectedIndex = -1;

            txtSoruBasligi.Text = "";
            txtSure.Text = "";
            cmbZorluk.SelectedIndex = -1;
        }
        private void btnYukle_Click(object sender, EventArgs e)
        {
            MedyaYukle mediaYukle = new MedyaYukle();
            mediaYukle.setSoruEkleme(this);
            mediaYukle.Show();
        }

        private List<string> kategoriler = new List<string>();
        private List<Kategori> _kategoriler;
        private void SoruEkleme_Load(object sender, EventArgs e)
        {
            yenidenCiz();
        }
        public void yenidenCiz()
        {
            _kategoriler = Database.Select.Kategoriler();
            kategoriler = new List<string>();
            foreach (var i in _kategoriler)
            {
                kategoriler.Add(i.Ad);
            }

            cmbKategori.DataSource = kategoriler;
            if (kategoriler.Count <= 0)
                imageLists.Items.Clear();

        }
        private void imageLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Medya _medya = (Model.Medya)imageLists.SelectedItem;

            if (_medya == null)
                return;
            vlcPlayer1.SetMedia(_medya);
        }

        private List<Medya> _medyalar;
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            MedyaYukle();

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }
        private bool checkedklasik = false;
        private void checkKlasik_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkedklasik)
            {
                checkedklasik = true;
                txtA.Enabled = false; txtB.Enabled = false; txtC.Enabled = false; txtD.Enabled = false; txtE.Enabled = false; cmbDogru.Enabled = false;
            }
            else
            {
                checkedklasik = false;
                txtA.Enabled = true; txtB.Enabled = true; txtC.Enabled = true; txtD.Enabled = true; txtE.Enabled = true; cmbDogru.Enabled = true;

            }
        }
    }
}
