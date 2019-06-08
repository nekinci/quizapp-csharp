﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using EgitimUygulamasi.Model;

namespace EgitimUygulamasi.View
{
    public partial class SoruDuzenleme : UserControl
    {

        private List<Model.Kategori> Kategoriler = null;
        private int selectedId;
        private DataTable table;
        private List<string> KategoriIsimler;
        private Model.Medya _medya = null;
        private Model.Medya _tmp_medya;
        public Main main;

        public void setMain(Main main)
        {
            this.main = main;
        }

        public SoruDuzenleme()
        {
            InitializeComponent();
        }
        private void SoruDuzenleme_Load(object sender, EventArgs e)
        {
            table = Database.Select.sorulariCek();
            SorularTablosu.DataSource = table;
            SorularTablosu.Columns[0].HeaderText = "ID";
            SorularTablosu.Columns[1].HeaderText = "Soru";
            SorularTablosu.Columns[2].HeaderText = "Zorluk Seviyesi";
            SorularTablosu.Columns[3].HeaderText = "Süre";
            SorularTablosu.Columns[4].HeaderText = "Kategori Adı";
            SorularTablosu.Columns[5].HeaderText = "A Seçeneği";
            SorularTablosu.Columns[6].HeaderText = "B Seçeneği";
            SorularTablosu.Columns[7].HeaderText = "C Seçeneği";
            SorularTablosu.Columns[8].HeaderText = "D Seçeneği";
            SorularTablosu.Columns[9].HeaderText = "E Seçeneği";
            SorularTablosu.Columns[10].HeaderText = "Doğru Cevap";
            SorularTablosu.Columns[11].HeaderText = "Medya";

            Kategoriler = Database.Select.KategoriCek();
            KategoriIsimler = new List<string>();

            for (var i = 0; i < Kategoriler.Count; i++)
            {
                KategoriIsimler.Add(Kategoriler.ElementAt(i).Ad);
            }
            cmbKategori.DataSource = KategoriIsimler;
            KategoriIsimler.Add("Tümü");
            cmbFiltreKategori.DataSource = KategoriIsimler;

            cmbFiltreKategori.SelectedIndex = -1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click_1(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (VerifyTextsA())
                tabSorular.SelectedTab = secenektab;
        }

        private void SorularTablosu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSoruBasligi.Text = SorularTablosu.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbKategori.SelectedItem = SorularTablosu.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbZorlukSeviyesi.SelectedItem = SorularTablosu.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSure.Text = SorularTablosu.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtA.Text = SorularTablosu.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtB.Text = SorularTablosu.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtC.Text = SorularTablosu.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtD.Text = SorularTablosu.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtE.Text = SorularTablosu.Rows[e.RowIndex].Cells[9].Value.ToString();
            cmbDogru.SelectedItem = SorularTablosu.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtMedya.Text = SorularTablosu.Rows[e.RowIndex].Cells[11].Value.ToString();
            selectedId = Convert.ToInt32(SorularTablosu.Rows[e.RowIndex].Cells[0].Value.ToString());
            _tmp_medya = Database.Select.MedyaCekForSoruDuzenleme(selectedId);
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (Database.Delete.SoruSil(selectedId))
            {
                MessageBox.Show("Soru başarıyla silindi!");
                temizle();
                main.YenidenCiz();
            }
            else
            {
                MessageBox.Show("Silinemedi");
            }
        }


        private bool VerifyTextsA()
        {
            bool kontrol = true;
            string message = "";

            if (txtSoruBasligi.Text == "")
            {
                message += "Soru başlığı girilmedi. \n"; kontrol = false;
            }
            if (txtSure.Text == "")
            {
                message += "Süre girilmedi. \n"; kontrol = false;
            }
            if (cmbKategori.SelectedIndex < 0)
            {
                message += "Kategori seçilmedi. \n"; kontrol = false;
            }
            if (cmbZorlukSeviyesi.SelectedIndex < 0)
            {
                message += "Zorluk seviyesi seçilmedi. \n"; kontrol = false;
            }
            if (txtMedya.Text == "")
            {
                message += "Medya seçilmedi. \n"; kontrol = false;
            }

            if (!kontrol)
                MessageBox.Show(message);
            return kontrol;
        }


        private bool VerifyTextsB()
        {
            bool kontrol = true;
            string message = "";
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
                message += "Doğru cevap seçilmedi."; kontrol = false;
            }

            if (!kontrol)
                MessageBox.Show(message);
            return kontrol;
        }
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            if (VerifyTextsA() && VerifyTextsB())
            {
                Soru _soru = new Soru();
                Model.Secenekler _secenekler = new Model.Secenekler();

                _soru.ID = selectedId;
                _soru.KategoriID = Kategoriler.ElementAt(cmbKategori.SelectedIndex).ID;
                _soru.ZorlukSeviyesi = cmbZorlukSeviyesi.SelectedItem.ToString();
                _soru.SoruBasligi = txtSoruBasligi.Text;
                _soru.Sure = Convert.ToInt32(txtSure.Text);
                _soru.MedyaID = _medya != null ? _medya.ID : _tmp_medya.ID;
                _secenekler.ASecenegi = txtA.Text;
                _secenekler.BSecenegi = txtB.Text;
                _secenekler.CSecenegi = txtC.Text;
                _secenekler.DSecenegi = txtD.Text;
                _secenekler.ESecenegi = txtE.Text;
                _secenekler.DogruCevap = cmbDogru.SelectedItem.ToString();

                temizle();
                this.main.YenidenCiz();

                Database.Update.SoruGuncelle(_soru, _secenekler);
            }
        }

        private void SoruDuzenleme_Paint(object sender, PaintEventArgs e)
        {

        }

        public void yenidenCiz()
        {
            SorularTablosu.DataSource = Database.Select.sorulariCek();
            SorularTablosu.Update();
        }

        private void txtSure_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            table.DefaultView.RowFilter = "soruBasligi Like '" + txtAra.Text + "%'";
            SorularTablosu.DataSource = table;

        }

        private void txtAra_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void temizle()
        {
            cmbDogru.SelectedIndex = -1;
            cmbKategori.SelectedIndex = -1;
            cmbZorlukSeviyesi.SelectedIndex = -1;

            txtSoruBasligi.Clear();
            txtSure.Clear();

            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtD.Clear();
            txtE.Clear();
            txtMedya.Clear();
        }

        public void MedyaDegistir(Medya _medya)
        {
            this._medya = _medya;
            txtMedya.Text = _medya.Path;
        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MedyaDegistir();
        }

        public void MedyaDegistir()
        {
            MedyaDegistir medyaDegistir = new MedyaDegistir();
            medyaDegistir.setSoruDuzenleme(this, selectedId);
            medyaDegistir.Show();
        }

        private void materialFlatButton2_Click_1(object sender, EventArgs e)
        {
            MedyaGor _medyagor = new MedyaGor();
            _medyagor.setMedya(_medya ?? _tmp_medya);
            _medyagor.Show();
        }

        private void txtMedya_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Kategori x = Kategoriler.ElementAt(cmbKategori.SelectedIndex);

            MedyaDegistir medyaDegistir = new MedyaDegistir();
            medyaDegistir.setSoruDuzenleme1(this, x.ID);
            medyaDegistir.KategoriDegisti(true);
            medyaDegistir.Show();
        }

        private void cmbFiltreKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFiltreKategori_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbFiltreKategori.SelectedItem.ToString() == "Tümü")
                table.DefaultView.RowFilter = "";
            else
                table.DefaultView.RowFilter = "ad = '" + cmbFiltreKategori.SelectedItem.ToString() + "'";
            SorularTablosu.DataSource = table;
        }

        private void cmbFiltreZorluk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbFiltreZorluk.SelectedItem.ToString() == "Tümü")
                table.DefaultView.RowFilter = "";
            else
                table.DefaultView.RowFilter = "zorlukSeviyesi = '" + cmbFiltreZorluk.SelectedItem.ToString() + "'";
            SorularTablosu.DataSource = table;
        }
    }
}
