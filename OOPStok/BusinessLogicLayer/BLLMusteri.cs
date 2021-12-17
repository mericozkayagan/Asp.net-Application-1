using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLMusteri
    {
        public static List<EntityMusteri> Musterilistesi()
        {
            return DALMusteri.MusteriListesi();
        }

        public static int Musteriekle(EntityMusteri ent)
        {
            if (ent.Musteriad != null && ent.Musteriad != "" && ent.Musterisoyad != null && ent.Musterisoyad != "")
            {
                return DALMusteri.Musteriekle(ent);
            }
            else
            {
                return -1;
            }
        }
        public static bool Musteriguncelle(EntityMusteri ent)
        {
            if (ent.Musteriid != 0 && ent.Musteriad != null && ent.Musteriad != "" && ent.Musterisoyad != null && ent.Musterisoyad != "")
            {
                return DALMusteri.Musteriguncelle(ent);
            }
            else
            {
                return false;
            }
        }
        public static bool Musterisil(int deger)
        {
            if (deger != 0)
            {
                return DALMusteri.Musterisil(deger);
            }
            else
            {
                return false;
            }
        }
        public static bool Musteriaktiflestir(int deger)
        {
            if (deger != 0)
            {
                return DALMusteri.Musteriaktiflestir(deger);
            }
            else
            {
                return false;
            }
        }
    }
}
