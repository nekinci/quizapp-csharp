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
        private Main main;


        public void setMain(Main main)
        {
            this.main = main;
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

            Model.OdulCeza cezaodul = Database.Select.OdulCezaCek();

            ceza1.Text = cezaodul.Ceza1.ToString();
            ceza2.Text = cezaodul.Ceza2.ToString();
            odul1.Text = cezaodul.Odul1.ToString();
            odul2.Text = cezaodul.Odul2.ToString();

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

            main.YenidenCiz();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (gericekilme.Checked == false)
                Database.Update.AyarGuncelle(0, 1);
            else
                Database.Update.AyarGuncelle(1, 1);
            main.YenidenCiz();

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Database.Update.AyarGuncelle(Convert.ToInt32(txtGunSayisi.Text), 2);
            main.YenidenCiz();

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            if (yanliscevap.Checked == false)
                Database.Update.AyarGuncelle(0, 3);
            else
                Database.Update.AyarGuncelle(1, 3);
            main.YenidenCiz();


        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            if (KontrolEt())
            {
                Model.OdulCeza odulceza = new Model.OdulCeza();

                odulceza.ID = 1;
                odulceza.Ceza1 = Convert.ToInt32(ceza1.Text);
                odulceza.Ceza2 = Convert.ToInt32(ceza2.Text);
                odulceza.Odul1 = Convert.ToInt32(odul1.Text);
                odulceza.Odul2 = Convert.ToInt32(odul2.Text);

                Database.Update.OdulCezaGuncelle(odulceza);
                main.YenidenCiz();

            }
        }

        private bool KontrolEt()
        {
            string message = "";
            bool check = true;

            if(ceza1.Text == "")
            {
                check = false;
                message += "Ceza Başlangıç puanı girilmedi.\n";
            }

            if(ceza2.Text == "")
            {
                check = false;
                message += "Ceza Başlangıç puanı girilmedi.\n";

            }

            if(odul1.Text == "")
            {
                check = false;
                message += "Ödül Başlangıç Puanı girilmedi.\n";
            }

            if(odul2.Text == "")
            {
                message += "Ödül Başlangıç Puanı girilmedi.\n";
                check = false;
            }
            if (Convert.ToInt32(ceza2.Text) <= Convert.ToInt32(ceza1.Text))
            {
                message += "Ceza Puan aralığını kontrol edin. Bitiş aralığı başlangıçtan büyük olamaz. \n";
                check = false;
            }
            if (Convert.ToInt32(odul1.Text) <= Convert.ToInt32(ceza2.Text))
            {
                message += "Ödül cezadan küçük veya eşit olamaz.\n";
                check = false;
            }

            if (Convert.ToInt32(odul2.Text) <= Convert.ToInt32(odul1.Text))
            {
                message += "Ödül Puan aralığını kontrol edin. Bitiş aralığı başlangıçtan büyük olamaz. \n";
                check = false;
            }

            if (!check)
                MessageBox.Show(message);
            return check;
        }
    }
}
