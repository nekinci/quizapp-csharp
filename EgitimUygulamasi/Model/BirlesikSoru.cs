using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimUygulamasi.Model
{
    public class BirlesikSoru
    {
        public Soru soru { get; set; }
        public Secenekler secenekler { get; set; }
        public Medya medya { get; set; }
        public List<int> calisanlar { get; set; }
    }
}
