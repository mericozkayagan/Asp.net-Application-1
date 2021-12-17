using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace OOPStok
{
    public partial class Satisekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select * from TBLURUN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataValueField = "URUNID";
                DropDownList1.DataTextField = "URUNAD";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();

                SqlCommand komut2 = new SqlCommand("Select PERID, (PERAD+' '+PERSOYAD) AS 'PERADSOYAD' from TBLPERSONEL", Baglanti.bgl);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                DropDownList2.DataValueField = "PERID";
                DropDownList2.DataTextField = "PERADSOYAD";
                DropDownList2.DataSource = dt2;
                DropDownList2.DataBind();

                SqlCommand komut3 = new SqlCommand("Select MUSTERIID, (MUSTERIAD+' '+MUSTERISOYAD) AS 'MUSTERIADSOYAD' from TBLMUSTERI", Baglanti.bgl);
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                DataTable dt3 = new DataTable();
                da.Fill(dt3);
                DropDownList3.DataValueField = "MUSTERIID";
                DropDownList3.DataTextField = "MUSTERIADSOYAD";
                DropDownList3.DataSource = dt2;
                DropDownList3.DataBind();
            }
        }
    }
}