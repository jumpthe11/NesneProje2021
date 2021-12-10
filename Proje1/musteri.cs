using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    internal class musteri
    {
        public string mstrAdi { get; set; }
        public string mstrSoyadi { get; set; }
        public string mstrTelefon { get; set; }
        public string mstrAdres { get; set; }
        public musteri(string mstrAdi,string mstrSoyadi,string mstrTelefon,string mstrAdres)
        {
            this.mstrAdi=mstrAdi;
            this.mstrSoyadi =mstrSoyadi;
            this.mstrTelefon =mstrTelefon;
            this.mstrAdres = mstrAdres;
        }

    }
}
