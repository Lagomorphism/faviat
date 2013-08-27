using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Click(object sender, EventArgs e)
    {
        string id = ((Control)sender).ID;

        switch (id)
        {
            case "btn_forget_password":
                Response.RedirectToRoute("Forgot");
                break;
            case "btn_login":
                int accound_id = BusinessLayer.Login(txt_username.Text, txt_password.Text);
                if (accound_id != 0)
                    Response.RedirectToRoute("Home");
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<p class='error'>");
                    sb.Append("Email address or password are entered inconrrectly.<br />");
                    sb.Append("Please check your email or password again.<br />");
                    sb.Append("</p>");
                    lit_error.Text = sb.ToString();
                }
                break;
            default:
                break;
        }
    }
}