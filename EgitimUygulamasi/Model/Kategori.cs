using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimUygulamasi.Model
{
    class Kategori
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }

        public Kategori(int id,string Ad, string Tur, string Aciklama)
        {
            this.ID = id;
            this.Ad = Ad;
            this.Aciklama = Aciklama;
        }

        public Kategori() { }
    }
}
