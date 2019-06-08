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
    public partial class CalisanDuzenle : UserControl
    {
        private int selectedid = -1;
        public Main main;
        private DataTable table;
        public CalisanDuzenle()
        {
            InitializeComponent();
        }

        public void setMain(Main main)
        {
            this.main = main;
        }

        private void CalisanDuzenle_Load(object sender, EventArgs e)
        {
            table = Database.Select.calisanlariCek(); ;
            CalisanlarTablosu.DataSource = table;
            CalisanlarTablosu.Columns["id"].HeaderText = "ID";
            CalisanlarTablosu.Columns["ad"].HeaderText = "Ad";
            CalisanlarTablosu.Columns["soyad"].HeaderText = "Soyad";
            CalisanlarTablosu.Columns["kadi"].HeaderText = "Kullanıcı Adı";
            CalisanlarTablosu.Columns["mail"].HeaderText = "Mail";
            CalisanlarTablosu.Columns["puan"].HeaderText = "Puan";
        }

        private void CalisanlarTablosu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedid = Convert.ToInt32(CalisanlarTablosu.Rows[e.RowIndex].Cells[0].Value);
            txtAd.Text = CalisanlarTablosu.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = CalisanlarTablosu.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtKadi.Text = CalisanlarTablosu.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMail.Text = CalisanlarTablosu.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private bool VerifyTexts()
        {
            bool kontrol = true;
            string message = "";
            if (txtAd.Text == "")
            {
                message += "Ad girilmedi.\n"; kontrol = false;
            }
            if (txtSoyad.Text == "")
            {
                message += "Soyad girilmedi. \n"; kontrol = false;
            }
            if (txtKadi.Text == "")
            {
                message += "Kullanıcı adı girilmedi.\n"; kontrol = false;
            }
            if (txtSifre.Text == "")
            {
                message += "Kullanıcı şifresi girilmedi."; kontrol = false;
            }
            if (!kontrol)
                MessageBox.Show(message);
            return kontrol;
        }

        private void temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtKadi.Clear();
            txtSifre.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Database.Delete.CalisanSil(selectedid))
            {
                MessageBox.Show("Başarıyla silindi.");
                temizle();
                this.main.YenidenCiz();
            }
            else
                MessageBox.Show("Bir sorun oluştu! Silinemedi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (VerifyTexts())
            {
                Model.Calisan calisan = new Model.Calisan();
                calisan.ID = selectedid;
                calisan.Ad = txtAd.Text;
                calisan.Soyad = txtSoyad.Text;
                calisan.Kadi = txtKadi.Text;
                calisan.Mail = txtMail.Text;
                calisan.Sifre = MD5Sifreleme.MD5Sifrele(txtSifre.Text);

                Database.Update.CalisanGuncelle(calisan);
                temizle();
                this.main.YenidenCiz();
            }
        }
        public void yenidenCiz()
        {
            CalisanlarTablosu.DataSource = Database.Select.calisanlariCek();
            CalisanlarTablosu.Update();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            table.DefaultView.RowFilter = "ad Like '%" + txtAra.Text + "%' or soyad Like '%" + txtAra.Text + "%' or kadi like '%"+txtAra.Text+"%'";
            CalisanlarTablosu.DataSource = table;
        }
    }
}
