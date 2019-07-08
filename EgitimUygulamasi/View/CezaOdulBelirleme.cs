using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimUygulamasi.View
{
    public partial class CezaOdulBelirleme : UserControl
    {

        private Main main;


        public void setMain(Main main)
        {
            this.main = main;
        }

        public CezaOdulBelirleme()
        {
            InitializeComponent();
        }

        private int selectedid;

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void CezaOdulBelirleme_Load(object sender, EventArgs e)
        {
            OdulVeCezaTablosu.DataSource = Database.Select.odulveCezaCek();
            OdulVeCezaTablosu.Update();
            OdulVeCezaTablosu.Columns[0].HeaderText = "ID";
            OdulVeCezaTablosu.Columns[1].HeaderText = "Ad";
            OdulVeCezaTablosu.Columns[2].HeaderText = "Tür";
            OdulVeCezaTablosu.Columns[3].HeaderText = "Aralık 1";
            OdulVeCezaTablosu.Columns[4].HeaderText = "Aralık 2";
        }

        public void yenidenCiz()
        {
            OdulVeCezaTablosu.DataSource = Database.Select.odulveCezaCek();
            OdulVeCezaTablosu.Update();
            
        }


        public bool VerifyTexts()
        {
            string message = "";
            bool durum = true;
            if (txtAd.Text == "")
            {
                message += "Ad girilmedi.\n"; durum = false;
            }
            if (cmbTur.SelectedIndex < 0)
            {
                message += "Tür seçilmedi.\n"; durum = false;
            }

            if (txtAralik1.Text == "")
            {
                message += "Aralık 1 girilmedi. \n"; durum = false;
            }

            if (txtAralik2.Text == "")
            {
                message += "Aralık 2 girilmedi.\n"; durum = false;
            }


            if (!durum)
                MessageBox.Show(message);

            return durum;
        }

        public bool VerifyTexts1()
        {
            string message = "";
            bool durum = true;
            if (txtAd1.Text == "")
            {
                message += "Ad girilmedi.\n"; durum = false;
            }
            if (cmbTur1.SelectedIndex < 0)
            {
                message += "Tür seçilmedi.\n"; durum = false;
            }

            if (txtAralik11.Text == "")
            {
                message += "Aralık 1 girilmedi. \n"; durum = false;
            }

            if (txtAralik21.Text == "")
            {
                message += "Aralık 2 girilmedi.\n"; durum = false;
            }


            if (!durum)
                MessageBox.Show(message);

            return durum;
        }
        private void OdulVeCezaTablosu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedid = Convert.ToInt32(OdulVeCezaTablosu.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtAd1.Text = OdulVeCezaTablosu.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbTur1.Text = OdulVeCezaTablosu.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAralik11.Text = OdulVeCezaTablosu.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAralik21.Text = OdulVeCezaTablosu.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btmKaydet_Click(object sender, EventArgs e)
        {

            if (!VerifyTexts())
                return;

            Model.OdulCezaModel model = new Model.OdulCezaModel();

            model.ID = 0;
            model.Ad = txtAd.Text;
            model.Tur = cmbTur.SelectedItem.ToString();
            model.Aralik1 = Convert.ToInt32(txtAralik1.Text);
            model.Aralik2 = Convert.ToInt32(txtAralik2.Text);

            Database.Insert.OdulCezaEkleme(model);
            temizle();
            main.YenidenCiz();
        }

        public void temizle()
        {
            txtAd.Clear();
            txtAralik1.Clear();
            txtAralik2.Clear();
            cmbTur.SelectedIndex = -1;
        }
        private void btnKaydet1_Click(object sender, EventArgs e)
        {


            if (!VerifyTexts1())
                return;

            Model.OdulCezaModel model = new Model.OdulCezaModel();

            model.ID = selectedid;
            model.Ad = txtAd1.Text;
            model.Tur = cmbTur1.Text;
            model.Aralik1 = Convert.ToInt32(txtAralik11.Text);
            model.Aralik2 = Convert.ToInt32(txtAralik21.Text);

            Database.Update.OdulveCezaGuncelle(model);
            main.YenidenCiz();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Gerçekten Silmek istiyormusunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Database.Delete.OdulveCezaSil(selectedid);
                main.YenidenCiz();
            }

        }
    }
}
