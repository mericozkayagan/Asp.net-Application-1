using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
   public class BLLPersonel
    {
        public static List<EntityPersonel> Personellistesi()
        {
            return DALPersonel.Personellistesi();
        }
        public static int Personelekle(EntityPersonel ent)
        {
            if (ent.Perad != null && ent.Perad != "" && ent.Persoyad != null && ent.Persoyad != "")
            {
                return DALPersonel.Personelekle(ent);
            }
            else
            {
                return -1;
            }
        }
    }
}
