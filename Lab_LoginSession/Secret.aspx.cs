﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secret : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         string c = Session["uid"].ToString();
        if (c == "")
        {
            
            Response.Redirect("Login.aspx");
        }
    }
}