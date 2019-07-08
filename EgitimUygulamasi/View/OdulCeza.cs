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
    public partial class OdulCeza : UserControl
    {
        private Main main;
        public OdulCeza()
        {
            InitializeComponent();

        }

        public void setMain(Main main)
        {
            this.main = main;
        }
        private void Yukle()
        {
            

        }
        private void OdulCeza_Load(object sender, EventArgs e)
        {
            OdulVeCezaTablosu.DataSource = Database.Select.odulveCezaCek();
            OdulVeCezaTablosu.Update();
            OdulVeCezaTablosu.Columns[0].HeaderText = "ID";
            OdulVeCezaTablosu.Columns[1].HeaderText = "Ad";
            OdulVeCezaTablosu.Columns[2].HeaderText = "Tür";
            OdulVeCezaTablosu.Columns[3].HeaderText = "Aralık 1";
            OdulVeCezaTablosu.Columns[4].HeaderText = "Aralık 2";
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tüm kayıtlı çalışanların puanını sıfırlamak istediğinizden emin misiniz?)","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                if (MessageBox.Show("Gerçekten Sıfırlamak istiyor musunuz?)", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    Database.Update.PuanlariSifirla();
                    Yukle();
                    main.YenidenCiz();
                }

            }
        }

        public void yenidenCiz()
        {
            OdulVeCezaTablosu.DataSource = Database.Select.odulveCezaCek();
            OdulVeCezaTablosu.Update();
        }

        private void OdulVeCezaTablosu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


            string tur = OdulVeCezaTablosu.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (tur == "Ödül")
                lblBilgi.ForeColor = Color.Blue;
            else
                lblBilgi.ForeColor = Color.Red;
            lblBilgi.Text = tur;
            int aralik1 = Int32.Parse(OdulVeCezaTablosu.Rows[e.RowIndex].Cells[3].Value.ToString());
            int aralik2 = Int32.Parse(OdulVeCezaTablosu.Rows[e.RowIndex].Cells[4].Value.ToString());

            List<Model.Calisan> Calisanlar = Database.Select.Calisanlar();
            List<Model.Puan> Puanlar = Database.Select.Puanlar();
            flowLayoutPanel1.Controls.Clear();
            foreach (var i in Puanlar.FindAll(x => x.CalisanPuani >= aralik1 && x.CalisanPuani <= aralik2))
            {
                PuanProfil profil = new PuanProfil();
                Model.Calisan calisan = Calisanlar.Find(x => x.ID == i.CalisanID);
                profil.setValues(calisan.Ad + " " + calisan.Soyad, i.CalisanPuani.ToString());
                flowLayoutPanel1.Controls.Add(profil);
            }
        }
    }
}
