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

            Yukle();

        }

        public void setMain(Main main)
        {
            this.main = main;
        }
        private void Yukle()
        {
            List<Model.Puan> Puanlar = Database.Select.Puanlar();
            Model.OdulCeza odulceza = Database.Select.OdulCezaCek();
            List<Model.Calisan> Calisanlar = Database.Select.Calisanlar();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            foreach (var i in Puanlar.FindAll(x => x.CalisanPuani >= odulceza.Ceza1 && x.CalisanPuani <= odulceza.Ceza2))
            {
                Model.Calisan calisan = Calisanlar.Find(x => x.ID == i.CalisanID);
                string isim = calisan.Ad + " " + calisan.Soyad;
                PuanProfil profil = new PuanProfil();
                profil.setValues(isim, i.CalisanPuani.ToString());
                flowLayoutPanel1.Controls.Add(profil);

            }
            foreach (var i in Puanlar.FindAll(x => x.CalisanPuani >= odulceza.Odul1 && x.CalisanPuani <= odulceza.Odul2))
            {
                Model.Calisan calisan = Calisanlar.Find(x => x.ID == i.CalisanID);
                string isim = calisan.Ad + " " + calisan.Soyad;
                PuanProfil profil = new PuanProfil();
                profil.setValues(isim, i.CalisanPuani.ToString());
                flowLayoutPanel2.Controls.Add(profil);

            }
            foreach (var i in Puanlar.FindAll(x => x.CalisanPuani < odulceza.Ceza1 || x.CalisanPuani > odulceza.Odul2))
            {
                Model.Calisan calisan = Calisanlar.Find(x => x.ID == i.CalisanID);
                string isim = calisan.Ad + " " + calisan.Soyad;
                PuanProfil profil = new PuanProfil();
                profil.setValues(isim, i.CalisanPuani.ToString());
                flowLayoutPanel3.Controls.Add(profil);
            }

        }
        private void OdulCeza_Load(object sender, EventArgs e)
        {
            
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
            Yukle();
        }
    }
}
