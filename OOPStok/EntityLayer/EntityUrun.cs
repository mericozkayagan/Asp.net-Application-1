using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityUrun
    {
        int urunid;
        string urunad;
        decimal urunfiyat;
        int urunadet;

        public int Urunid { get => urunid; set => urunid = value; }
        public string Urunad { get => urunad; set => urunad = value; }
        public decimal Urunfiyat { get => urunfiyat; set => urunfiyat = value; }
        public int Urunadet { get => urunadet; set => urunadet = value; }
    }
}
