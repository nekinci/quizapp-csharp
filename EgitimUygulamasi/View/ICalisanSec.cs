using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimUygulamasi.View
{
    public interface ICalisanSec
    {
        void CalisanSecildi(List<int> CalisanIDleri);
        void CalisanSecildi(List<Model.Calisan> Calisanlar);
    }
}
