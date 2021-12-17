using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALUrun
    {
        public static List<EntityUrun> Urunlistesi()
        {
            List<EntityUrun> liste = new List<EntityUrun>();
            SqlCommand komut = new SqlCommand("select * From TBLURUN", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityUrun ent = new EntityUrun();
                ent.Urunid = Convert.ToInt32(dr[0]);
                ent.Urunad = dr[1].ToString();
                ent.Urunfiyat = Convert.ToDecimal(dr[2]);
                ent.Urunadet = Convert.ToInt32(dr[3]);
                liste.Add(ent);
            }
            dr.Close();
            return liste;
        }
        public static int Urunekle(EntityUrun ent)
        {
            SqlCommand komut = new SqlCommand("insert into TBLURUN (URUNAD,URUNADET,URUNFIYAT) values (@p1,@p2,@p3)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", ent.Urunad);
            komut.Parameters.AddWithValue("@p2", ent.Urunadet);
            komut.Parameters.AddWithValue("@p3", ent.Urunfiyat);
            return komut.ExecuteNonQuery();
        }
    }
}
