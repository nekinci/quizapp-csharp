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
    public partial class KlasikCevaplar : UserControl
    {
        private List<Model.Calisan> Calisanlar;
        private List<Model.KlasikCevap> cevaplar = Database.Select.Cevaplar();
        private List<Model.BirlesikSoru> sorular = Database.Select.Sorular();
        private Model.KlasikCevap SelectedCevap = null;
        private Main main;

        public void SetMain(Main main)
        {
            this.main = main;
        }

        public void SeciliCevap(Model.KlasikCevap cevap)
        {
            CevabiGoster(cevap);
        }

        public KlasikCevaplar()
        {
            InitializeComponent();
        }
        private void KlasikCevaplar_Load(object sender, EventArgs e)
        {
        }

        public void Doldur()
        {
            Calisanlar = Database.Select.Calisanlar();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            cevaplar = cevaplar.OrderByDescending(x => x.Tarih).ToList();
            cevaplar = cevaplar.OrderBy(x => x.Durum).ToList();
            foreach (var i in cevaplar)
            {
                UICevapItem item = new UICevapItem();
                item.SetKlasikCevap(i);
                item.Width = flowLayoutPanel1.Width;
                item.SetUIComponent(this);
                flowLayoutPanel1.Controls.Add(item);
            }
        }
        Model.Calisan calisan;
        public void CevabiGoster(Model.KlasikCevap cevap)
        {
            SelectedCevap = cevap;
            if (cevap.Durum != 0)
            {
                btnOnayla.Enabled = false;
                btnReddet.Enabled = false;
            }
            if(cevap.Durum == 0)
            {
                btnOnayla.Enabled = true;
                btnReddet.Enabled = true;
            }
            calisan = Calisanlar.Find(x => x.ID == cevap.CalisanID);

            lblAdSoyad.Text = calisan.Ad + " " + calisan.Soyad;
            lblKadi.Text = calisan.Kadi;
            lblPuan.Text = Database.Select.Puanlar().Find(x => x.CalisanID == calisan.ID).CalisanPuani.ToString();
            lblSure.Text = Database.Select.CalisanCevaplari().Find(x => x.SoruID == cevap.SoruID && x.CalisanID == cevap.CalisanID && x.Tarih == cevap.Tarih).Sure.ToString();
            lblSoru.Text = sorular.Find(x => x.soru.ID == cevap.SoruID).soru.SoruBasligi;

            txtCevap.Text = cevap.Cevap;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            OnayDurumu(true);
        }

        private bool Onayliyormusunuz()
        {
            return MessageBox.Show("İşlemi onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public void yenidenCiz()
        {
            if (cmbFiltre.SelectedIndex <= 0)
            {
                cevaplar = Database.Select.Cevaplar();
                Doldur();
            }
            if (cmbFiltre.SelectedIndex == 1)
            {
                cevaplar = Database.Select.Cevaplar().FindAll(x => x.Durum == 0);
                Doldur();
            }
            SelectedCevap = null;
            lblAdSoyad.Text = "";
            lblKadi.Text = "";
            lblPuan.Text = "";
            lblSoru.Text = "";
            lblSure.Text = "";
            txtCevap.Text = "";
            btnOnayla.Enabled = false;
            btnReddet.Enabled = false;
        }
        public void OnayDurumu(bool durum)
        {
            if (!Onayliyormusunuz())
                return;

            try
            {
                Database.Update.PuanGuncelle(calisan.Kadi, sorular.Find(x => x.soru.ID == SelectedCevap.SoruID).soru.ZorlukSeviyesi, durum, false);
                Database.Update.CevapDurumu(SelectedCevap.ID, durum ? 1 : 2);
                MessageBox.Show("Teşekkürler, puan güncellenmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("Yolunda gitmeyen birşeyler var!");
            }
            main.YenidenCiz();
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            OnayDurumu(false);
        }

        private void lblSoru_VisibleChanged(object sender, EventArgs e)
        {
            Doldur();
        }

        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFiltre.SelectedIndex == 0)
            {
                cevaplar = Database.Select.Cevaplar();
                Doldur();
            }
            if(cmbFiltre.SelectedIndex == 1)
            {
                cevaplar = Database.Select.Cevaplar().FindAll(x => x.Durum == 0);
                Doldur();
            }
        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {

        }
    }
}
