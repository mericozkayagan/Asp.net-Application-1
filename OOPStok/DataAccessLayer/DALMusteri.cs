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
    public class DALMusteri
    {
        public static List<EntityMusteri> MusteriListesi()
        {
            List<EntityMusteri> liste = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("select * from TBLMUSTERI", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.Musteriid = Convert.ToInt32(dr[0]);
                ent.Musteriad = dr[1].ToString();
                ent.Musterisoyad = dr[2].ToString();
                ent.Musteridurum = Convert.ToBoolean(dr[3]);
                liste.Add(ent);
            }
            dr.Close();
            return liste;
        }

        public static int Musteriekle(EntityMusteri ent)
        {
            SqlCommand komut = new SqlCommand("insert into TBLMUSTERI (MUSTERIAD,MUSTERISOYAD) values (@p1,@p2)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", ent.Musteriad);
            komut.Parameters.AddWithValue("@p2", ent.Musterisoyad);
            return komut.ExecuteNonQuery();
        }

        public static bool Musteriguncelle(EntityMusteri ent)
        {
            SqlCommand komut = new SqlCommand("update TBLMUSTERI set MUSTERIAD=@p1, MUSTERISOYAD=@p2 where MUSTERIID=@p3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", ent.Musteriad);
            komut.Parameters.AddWithValue("@p2", ent.Musterisoyad);
            komut.Parameters.AddWithValue("@p3", ent.Musteriid);
            return komut.ExecuteNonQuery() > 0;
        }

        public static bool Musterisil(int deger)
        {
            SqlCommand komut = new SqlCommand("update TBLMUSTERI set MUSTERIDURUM=0 where MUSTERIID=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", deger);
            return komut.ExecuteNonQuery() > 0;
        }
        public static bool Musteriaktiflestir(int deger)
        {
            SqlCommand komut = new SqlCommand("update TBLMUSTERI set MUSTERIDURUM=1 where MUSTERIID=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", deger);
            return komut.ExecuteNonQuery() > 0;
        }



    }
}
