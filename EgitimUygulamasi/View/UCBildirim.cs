using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EgitimUygulamasi.Model;

namespace EgitimUygulamasi.View
{
    public partial class UCBildirim : UserControl
    {
        private Model.Bildirim bildirim;
        private Model.KlasikCevap cevap;
        public Model.Bildirim GetBildirim()
        {
            return bildirim;
        }

        public void SetBildirim(Model.Bildirim bildirim)
        {
            this.bildirim = bildirim;
            Model.Calisan calisan = Database.Select.Calisanlar().Find(x => x.ID == bildirim.GonderenID);
            lblCalisan.Text = calisan.Ad + " " + calisan.Soyad;
            lblSoruID.Text = bildirim.SoruID.ToString();

            cevap = Database.Select.Cevaplar().Find(x => x.SoruID == bildirim.SoruID && x.CalisanID == bildirim.GonderenID);
            lblCevap.Text = cevap.Cevap.Substring(0, Math.Min(61,cevap.Cevap.Length));
            lblCevap.Text += "...";
        }

        public Main Main { get; set; }

        public UCBildirim()
        {
            InitializeComponent();
        }

        private void lblCalisan_Click(object sender, EventArgs e)
        {
            bildirim.OkunduMu = true;
            Database.Update.BildirimOkundu(bildirim);
            Main.CevapGoster(cevap);
        }
    }
}
