using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenAlanCevreClass
{
    class Dikdortgen
    {

        public int en, boy, alan, cevre;

        public int AlanHesapla()
        {
            alan = en * boy;
            return alan;

        }

        public int CevreHesapla()
        {
            cevre = (en + boy) * 2;
            return cevre;
        }
    }
}
