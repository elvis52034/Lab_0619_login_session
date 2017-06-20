using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string b = Session["uid"].ToString();
        if (b != null) {
            string log = "Logout";
        } else { 
            string log = "Login";
        }
    }
}
