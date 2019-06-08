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
    public partial class Ayarlar : UserControl
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            Model.ZorlukPuanlari z = new Model.ZorlukPuanlari();

            z = Database.Select.ZorlukPuanlari();

            txtKolay.Text = z.Kolay.ToString();
            txtOrta.Text = z.Orta.ToString();
            txtZor.Text = z.Zor.ToString();

            Model.Ayarlar ayar = Database.Select.AyarCek();

            if (ayar.GeriCekilme == 1)
                gericekilme.Checked = true;
            else
                gericekilme.Checked = false;
            txtGunSayisi.Text = ayar.GunSayisi.ToString();

            if (ayar.YanlisCevap == 1)
                yanliscevap.Checked = true;
            else
                yanliscevap.Checked = false;

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            int kolay, orta, zor;
            kolay = Convert.ToInt32(txtKolay.Text);
            orta = Convert.ToInt32(txtOrta.Text);
            zor = Convert.ToInt32(txtZor.Text);

            Model.ZorlukPuanlari z = new Model.ZorlukPuanlari();
            z.Kolay = kolay;
            z.Orta = orta;
            z.Zor = zor;

            Database.Update.ZorlukPuaniGuncelle(z);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (gericekilme.Checked == false)
                Database.Update.AyarGuncelle(0, 1);
            else
                Database.Update.AyarGuncelle(1, 1);
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Database.Update.AyarGuncelle(Convert.ToInt32(txtGunSayisi.Text), 2);
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            if (yanliscevap.Checked == false)
                Database.Update.AyarGuncelle(0, 3);
            else
                Database.Update.AyarGuncelle(1, 3);
        }
    }
}
