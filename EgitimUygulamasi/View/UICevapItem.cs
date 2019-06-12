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
    public partial class UICevapItem : UserControl
    {
        public UICevapItem()
        {
            InitializeComponent();
        }
        private KlasikCevaplar UIView;
        public Model.KlasikCevap Cevap { get; set; }
        private List<Model.Calisan> Calisanlar = Database.Select.Calisanlar();
        public void SetKlasikCevap(Model.KlasikCevap Cevap)
        {
            this.Cevap = Cevap;
            Model.Calisan calisan = Calisanlar.Find(x => x.ID == Cevap.CalisanID);
            lblAd.Text = calisan.Ad + " " + calisan.Soyad;
            lblCevap.Text = Cevap.Cevap;
            lblTarih.Text = Cevap.Tarih.ToString("dd.MM.yyyy");

        }

        private void lblCevap_MouseHover(object sender, EventArgs e)
        {
        }

        private void lblCevap_MouseLeave(object sender, EventArgs e)
        {
            lblCevap.BackColor = Color.FromArgb(224, 224, 224);
            lblTarih.BackColor = Color.FromArgb(224, 224, 224);
            lblAd.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void lblCevap_MouseEnter(object sender, EventArgs e)
        {
            lblCevap.BackColor = Color.FromArgb(205, 220, 57);
            lblTarih.BackColor = Color.FromArgb(205, 220, 57);
            lblAd.BackColor = Color.FromArgb(48, 63, 159);


        }
        public void SetUIComponent(KlasikCevaplar UIView)
        {
            this.UIView = UIView;
        }

        private void lblCevap_Click(object sender, EventArgs e)
        {
            UIView.CevabiGoster(Cevap);
        }
    }
}
