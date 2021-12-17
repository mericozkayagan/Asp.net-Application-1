using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        int perid;
        string perad;
        string persoyad;
        string perfoto;
        int perdepartman;
        decimal permaas;
        string departmanad;

        public int Perid { get => perid; set => perid = value; }
        public string Perad { get => perad; set => perad = value; }
        public string Persoyad { get => persoyad; set => persoyad = value; }
        public string Perfoto { get => perfoto; set => perfoto = value; }
        public int Perdepartman { get => perdepartman; set => perdepartman = value; }
        public decimal Permaas { get => permaas; set => permaas = value; }
        public string Departmanad { get => departmanad; set => departmanad = value; }
    }
}
