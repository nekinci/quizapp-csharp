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
        public OdulCeza()
        {
            InitializeComponent();

            List<Model.Puan> Puanlar = Database.Select.Puanlar();
            Model.OdulCeza odulceza = Database.Select.OdulCezaCek();
            List<Model.Calisan> Calisanlar = Database.Select.Calisanlar();
            foreach(var i in Puanlar.FindAll(x=>x.CalisanPuani>=odulceza.Ceza1 && x.CalisanPuani <= odulceza.Ceza2))
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
            foreach (var i in Puanlar.FindAll(x => x.CalisanPuani < odulceza.Ceza1 && x.CalisanPuani > odulceza.Odul2))
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
    }
}
