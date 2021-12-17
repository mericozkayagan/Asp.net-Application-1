using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLUrun
    {
        public static List<EntityUrun> Urunlistesi()
        {
            return DALUrun.Urunlistesi();
        }
        public static int Urunekle(EntityUrun ent)
        {
            if (ent.Urunad != null && ent.Urunad != "" && ent.Urunfiyat > 0)
            {
                return DALUrun.Urunekle(ent);
            }
            else
            {
                return -1;
            }
        }
    }
}
