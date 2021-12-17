using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
namespace OOPStok
{
    public partial class Urunekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityUrun ent = new EntityUrun();
            ent.Urunad = TextBox1.Text;
            ent.Urunfiyat = Convert.ToDecimal(TextBox2.Text);
            ent.Urunadet = Convert.ToInt32(TextBox3.Text);
            BLLUrun.Urunekle(ent);
        }
    }
}