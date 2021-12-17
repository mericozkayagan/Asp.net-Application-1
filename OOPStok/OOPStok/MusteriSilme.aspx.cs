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
    public partial class MusteriSilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityMusteri> liste = BLLMusteri.Musterilistesi();
            Repeater1.DataSource = liste;
            Repeater1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(TextBox1.Text);
            BLLMusteri.Musteriaktiflestir(deger);
            List<EntityMusteri> liste = BLLMusteri.Musterilistesi();
            Repeater1.DataSource = liste;
            Repeater1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            EntityMusteri ent = new EntityMusteri();
            ent.Musteriid = Convert.ToInt32(TextBox1.Text);
            ent.Musteriad = TextBox2.Text;
            ent.Musterisoyad = TextBox3.Text;
            BLLMusteri.Musteriguncelle(ent);
            List<EntityMusteri> liste = BLLMusteri.Musterilistesi();
            Repeater1.DataSource = liste;
            Repeater1.DataBind();
        }

        protected void btnsil_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(TextBox1.Text);
            BLLMusteri.Musterisil(deger);
            List<EntityMusteri> liste = BLLMusteri.Musterilistesi();
            Repeater1.DataSource = liste;
            Repeater1.DataBind();
        }
    }
}