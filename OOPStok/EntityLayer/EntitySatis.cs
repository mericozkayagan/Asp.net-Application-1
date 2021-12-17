using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySatis
    {
        int satisid;
        int urun;
        int personel;
        decimal tutar;
        int musteri;
        string musteriad;
        string musterisoyad;
        string urunad;
        string personelad;
        string personelsoyad;
        public int Satisid { get => satisid; set => satisid = value; }
        public int Urun { get => urun; set => urun = value; }
        public int Personel { get => personel; set => personel = value; }
        public decimal Tutar { get => tutar; set => tutar = value; }
        public int Musteri { get => musteri; set => musteri = value; }
        public string Musteriad { get => musteriad; set => musteriad = value; }
        public string Musterisoyad { get => musterisoyad; set => musterisoyad = value; }
        public string Urunad { get => urunad; set => urunad = value; }
        public string Personelad { get => personelad; set => personelad = value; }
        public string Personelsoyad { get => personelsoyad; set => personelsoyad = value; }
    }
}
