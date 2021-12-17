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
    public class DALPersonel
    {
        public static List<EntityPersonel> Personellistesi()
        {
            List<EntityPersonel> liste = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("departmanlist", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Perid = Convert.ToInt32(dr[0]);
                ent.Perad = dr[1].ToString();
                ent.Persoyad = dr[2].ToString();
                ent.Perfoto = dr[3].ToString();
                ent.Departmanad = dr[4].ToString();
                //ent.Perdepartman = Convert.ToInt32(dr[4]);
                ent.Permaas = Convert.ToDecimal(dr[5]);
                liste.Add(ent);
            }
            dr.Close();
            return liste;
        }
        public static int Personelekle(EntityPersonel ent)
        {
            SqlCommand komut = new SqlCommand("insert into TBLPERSONEL (PERAD,PERSOYAD,PERDEPARTMAN,PERMAAS) values (@p1,@p2,@p3,@p4)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", ent.Perad);
            komut.Parameters.AddWithValue("@p2", ent.Persoyad);
            komut.Parameters.AddWithValue("@p3", ent.Perdepartman);
            komut.Parameters.AddWithValue("@p4", ent.Permaas);
            return komut.ExecuteNonQuery();
        }
    }
}
