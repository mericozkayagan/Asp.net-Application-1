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
    public class DALDepartman
    {
        public static List<EntityDepartman> Departmanlistesi()
        {
            List<EntityDepartman> liste = new List<EntityDepartman>();
            SqlCommand komut = new SqlCommand("Select * from TBLDEPARTMAN", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDepartman ent = new EntityDepartman();
                ent.Departmanid = Convert.ToInt32(dr[0]);
                ent.Departmanad = dr[1].ToString();
                liste.Add(ent);
            }
            dr.Close();
            return liste;
        }
        public static int ekle(EntityDepartman ent)
        {
            SqlCommand komut = new SqlCommand("insert into TBLDEPARTMAN (DEPARTMANAD) values (@p1)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",ent.Departmanad);
            return komut.ExecuteNonQuery();
        }
    }
}
