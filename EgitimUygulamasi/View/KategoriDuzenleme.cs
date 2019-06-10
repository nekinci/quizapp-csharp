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
    public partial class KategoriDuzenleme : UserControl
    {
        private int selectedId = -1;
        private DataTable table;
        public Main main;

        public KategoriDuzenleme()
        {
            InitializeComponent();
        }

        public void setMain(Main main)
        {
            this.main = main;
        }

        private void KategoriDuzenleme_Load(object sender, EventArgs e)
        {
            table = Database.Select.kategorileriCek();
            KategorilerTablosu.DataSource = table;

            KategorilerTablosu.Columns[0].HeaderText = "ID";
            KategorilerTablosu.Columns[1].HeaderText = "Kategori Adı";
            KategorilerTablosu.Columns[2].HeaderText = "Açıklama";

        }

        private void KategorilerTablosu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = Convert.ToInt32(KategorilerTablosu.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtKategoriAdi.Text = KategorilerTablosu.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAciklama.Text = KategorilerTablosu.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Seçili kategori yok!");
                return;
            }

            DialogResult silmeOnay1 = new DialogResult();
            silmeOnay1 = MessageBox.Show("Eğer bu kategoriyi silerseniz bu kategoriyle ilişkili bütün sorularıda silmiş olursunuz\nKategoriyi silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (silmeOnay1 == DialogResult.Yes)
            {
                DialogResult silmeOnay2 = new DialogResult();
                silmeOnay2 = MessageBox.Show("Geri dönüşü olmayan işlem için tekrardan onayınız gerekmektedir. Gerçekten silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (silmeOnay2 == DialogResult.Yes)
                {

                    if (Database.Delete.KategoriSil(selectedId))
                    {
                        MessageBox.Show("Başarıyla silindi");
                        KomponentleriTemizle();
                        this.main.YenidenCiz();
                    }
                    else
                    {
                        MessageBox.Show("Kategori Silinemedi");
                    }
                }
            }
        }

        private void KategoriDuzenleme_Paint(object sender, PaintEventArgs e)
        {

        }

        public void yenidenCiz()
        {
            KategorilerTablosu.DataSource = Database.Select.kategorileriCek();
            KategorilerTablosu.Update();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Model.Kategori _kategori = new Model.Kategori();

            if (VerifyTexts())
            {
                _kategori.ID = selectedId;
                _kategori.Ad = txtKategoriAdi.Text;
                _kategori.Aciklama = txtAciklama.Text;

                Database.Update.KategoriGuncelle(_kategori);
                this.main.YenidenCiz();
                KomponentleriTemizle();
            }
            
        }

        public bool VerifyTexts()
        {
            string message = "";
            bool kontrol = true;

            if (txtKategoriAdi.Text == "")
            {
                message += "Kategori adı girilmedi. \n"; kontrol = false;
            }
            if (txtAciklama.Text == "")
            {
                message += "Açıklama girilmedi. \n"; kontrol = false;
            }
            if (!kontrol)
                MessageBox.Show(message);
            return kontrol;
        }

        private void KomponentleriTemizle()
        {
            txtKategoriAdi.Text = "";
            txtAciklama.Text = "";
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            table.DefaultView.RowFilter = "ad Like '" + txtAra.Text + "%'";
            KategorilerTablosu.DataSource = table;

        }
    }
}
