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
    public partial class Board : UserControl
    {
        public Board()
        {
            InitializeComponent();
            BoardCiz();

        }


        public void BoardCiz()
        {
            List<Model.Calisan> Calisanlar = Database.Select.Calisanlar();
            List<Model.BirlesikSoru> Sorular = Database.Select.Sorular();
            List<Kategori> Kategoriler = Database.Select.Kategoriler();


            label1.Text = Calisanlar.Count + " Çalışan";
            label2.Text = Sorular.Count + " Soru";
            label4.Text = Kategoriler.Count + " Kategori";

            List<Puan> puanlar = Database.Select.Puanlar();

            puanlar = puanlar.OrderByDescending(x => x.CalisanPuani).ToList();

            if(puanlar.Count > 0)
            {
                Model.Calisan calisan = Calisanlar.Find(x => x.ID == puanlar.ElementAt(0).CalisanID);
                lblIsim1.Text = calisan.Ad + " " + calisan.Soyad;
                lblPuan1.Text = puanlar.ElementAt(0).CalisanPuani.ToString();

                lblIsim1.Visible = true;
                lblPuan1.Visible = true;
            }

            if(puanlar.Count > 1)
            {
                Model.Calisan calisan = Calisanlar.Find(x => x.ID == puanlar.ElementAt(1).CalisanID);
                lblIsim2.Text = calisan.Ad + " " + calisan.Soyad;
                lblPuan2.Text = puanlar.ElementAt(1).CalisanPuani.ToString();

                lblIsim2.Visible = true;
                lblPuan2.Visible = true;
            }

            if (puanlar.Count > 2)
            {
                Model.Calisan calisan = Calisanlar.Find(x => x.ID == puanlar.ElementAt(2).CalisanID);
                lblIsim3.Text = calisan.Ad + " " + calisan.Soyad;
                lblPuan3.Text = puanlar.ElementAt(2).CalisanPuani.ToString();

                lblIsim3.Visible = true;
                lblPuan3.Visible = true;
            }

            if (puanlar.Count > 3)
            {
                Model.Calisan calisan = Calisanlar.Find(x => x.ID == puanlar.ElementAt(3).CalisanID);
                lblIsim4.Text = calisan.Ad + " " + calisan.Soyad;
                lblPuan4.Text = puanlar.ElementAt(2).CalisanPuani.ToString();

                lblIsim4.Visible = true;
                lblPuan4.Visible = true;
            }
        }


        public void yenidenCiz()
        {
            BoardCiz();
        }
        private void Board_Load(object sender, EventArgs e)
        {

        }
    }
}
