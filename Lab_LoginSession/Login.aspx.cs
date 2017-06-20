using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUserName.Text))
        {
            lblPrompt.Text = "請輸入你的帳號";
            return;
        }

        Session["uid"]= txtUserName.Text;

        string c = Session["uid"].ToString();
        if (c == null)
            Response.Redirect("Default.aspx");
        else
            Response.Redirect("Secret.aspx");


    }
}