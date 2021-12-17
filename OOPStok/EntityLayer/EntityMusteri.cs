using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityMusteri
    {
        int musteriid;
        string musteriad;
        string musterisoyad;
        bool musteridurum;
        public int Musteriid { get => musteriid; set => musteriid = value; }
        public string Musteriad { get => musteriad; set => musteriad = value; }
        public string Musterisoyad { get => musterisoyad; set => musterisoyad = value; }
        public bool Musteridurum { get => musteridurum; set => musteridurum = value; }
    }
}
