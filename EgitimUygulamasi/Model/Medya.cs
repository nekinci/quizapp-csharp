using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimUygulamasi.Model
{
    public class Medya
    {
        public int ID { get; set; }
        public int KategoriID { get; set; }
        public string Ad { get; set; }
        public string Path { get; set; }
    }
}
