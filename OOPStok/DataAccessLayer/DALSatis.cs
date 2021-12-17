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
    public class DALSatis
    {
        public static List<EntitySatis> Satislistesi()
        {
            List<EntitySatis> liste = new List<EntitySatis>();
            SqlCommand komut = new SqlCommand("SATISLAR", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySatis ent = new EntitySatis();
                ent.Satisid = Convert.ToInt32(dr["SATISID"]);
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Personelad = dr["PERSONEL"].ToString();
                //ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Musteriad = dr["MUSTERI"].ToString();
                //ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                ent.Tutar = decimal.Parse(dr["TUTAR"].ToString());
                liste.Add(ent);
            }
            dr.Close();
            return liste;
        }
    }
}
