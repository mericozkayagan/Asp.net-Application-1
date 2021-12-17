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
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityUrun> Urunlistesi = BLLUrun.Urunlistesi();
            Repeater1.DataSource = Urunlistesi;
            Repeater1.DataBind();
        }
    }
}