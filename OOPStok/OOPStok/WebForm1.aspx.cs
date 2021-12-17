using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;

namespace OOPStok
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDepartman> deplist = BLLDepartman.BllDepartmanListele();
            Repeater1.DataSource = deplist;
            Repeater1.DataBind();
        }
    }
}