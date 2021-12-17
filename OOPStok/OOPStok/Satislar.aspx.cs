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
    public partial class Satislar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntitySatis> Satislistesi = BLLSatis.Satislistesi();
            Repeater1.DataSource = Satislistesi;
            Repeater1.DataBind();
        }
    }
}