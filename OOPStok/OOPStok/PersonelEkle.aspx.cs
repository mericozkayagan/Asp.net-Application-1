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
    public partial class PersonelEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select * from TBLDEPARTMAN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataValueField = "DEPARTMANID";
                DropDownList1.DataTextField = "DEPARTMANAD";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Perad = TextBox1.Text;
            ent.Persoyad = TextBox2.Text;
            ent.Permaas = Convert.ToDecimal(TextBox3.Text);
            ent.Perdepartman = Convert.ToInt32(DropDownList1.SelectedValue);
            BLLPersonel.Personelekle(ent);
            Response.Redirect("Personeller.aspx");

        }
    }
}