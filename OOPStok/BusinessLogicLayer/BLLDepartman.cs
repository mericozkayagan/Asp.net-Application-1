using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDepartman
    {
        public static List<EntityDepartman> BllDepartmanListele()
        {
            return DALDepartman.Departmanlistesi();
        }
        public static int BLLDepartmanekle(EntityDepartman ent)
        {
            if (ent.Departmanad != null&&ent.Departmanad!="")
            {
                return DALDepartman.ekle(ent);
            }
            else
            {
                return -1;
            }
        }
    }
}
