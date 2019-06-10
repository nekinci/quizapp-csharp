using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimUygulamasi.Model
{
    public class Soru
    {
        public int ID { get; set; }
        public string SoruBasligi { get; set; }
        public int Sure { get; set;  }
        public int KategoriID { get; set; }
        public int MedyaID { get; set; }
        public string ZorlukSeviyesi { get; set; }
        public bool KlasikSoru { get; set; }
    }
}
