using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using EgitimUygulamasi.Model;
using System.Diagnostics;

namespace EgitimUygulamasi.View
{
    public partial class SSoru1 : UserControl
    {
        public SSoru1()
        {
            InitializeComponent();
        }
        private List<Kategori> Kategoriler;
        private void pnl1_Paint(object sender, PaintEventArgs e)
        {
            Kategoriler = EgitimUygulamasi.Database.Select.KategoriCek();
            List<string> KategoriIsimler = new List<string>();

            for (var i = 0; i < Kategoriler.Count; i++)
            {
                KategoriIsimler.Add(Kategoriler.ElementAt(i).Ad);
            }

            cmbKategori.DataSource = KategoriIsimler;
            cmbKategori.SelectedIndex = -1;
        }

        private void ilerleButton_Click(object sender, EventArgs e)
        {
            if (VerifyTexts())
            {

                Soru _soru = new Soru();
                _soru.ID = 0;
                _soru.KategoriID = Kategoriler.ElementAt(cmbKategori.SelectedIndex).ID;
                _soru.SoruBasligi = txtSoruBasligi.Text;
                _soru.ZorlukSeviyesi = cmbZorluk.SelectedItem.ToString();
                _soru.Sure = Convert.ToInt32(txtSure.Text);



            }
        }

        public bool VerifyTexts()
        {
            String message = "";
            bool kontrol = true;
            if (txtSoruBasligi.Text == "")
            {
                message += "Soru başlığı alanınını kontrol ediniz.\n";
                kontrol = false;
            }
            if (cmbKategori.SelectedIndex < 0)
            {
                message += "Kategori seçmediniz.\n";
                kontrol = false;
            }
            if (cmbZorluk.SelectedIndex < 0)
            {
                message += "Zorluk seviyesi seçmediniz.\n";
                kontrol = false;
            }
            if (txtSure.Text == "")
            {
                message += "Süre belirtmediniz.";
                kontrol = false;
            }

            if (!kontrol)
                MessageBox.Show(message);
            return kontrol;
        }

        private void txtSoruBasligi_Click(object sender, EventArgs e)
        {

        }

        public void KomponentTemizle()
        {
            this.cmbZorluk.SelectedIndex = -1;
            this.cmbKategori.SelectedIndex = -1;
            this.txtSure.Clear();
            this.txtSoruBasligi.Clear();
        }

        private void txtSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            KomponentTemizle();
        }
    }

}
