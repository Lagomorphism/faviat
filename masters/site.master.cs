using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class masters_site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (BusinessLayer.Check_Login_Session())
        {
            pnl_login_before.Visible = false;
            pnl_login_after.Visible = true;
        }
        else
        {
            pnl_login_before.Visible = true;
            pnl_login_after.Visible = false;

            LoadFieldSet();
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        string id = ((Control)sender).ID;

        switch (id)
        {
            case "rib_login":
                Response.Redirect("~/Login");
                break;
            case "rib_signin":
                Response.Redirect("~/Signup");
                break;
            case "rib_gotomyaccount":
                Response.Redirect("~/MyProfile");
                break;
            default:
                break;
        }
    }

    private void LoadFieldSet()
    {
        label_full_name.Text = BusinessLayer.Return_Full_Name();

        StringBuilder sb = new StringBuilder();

        sb.Append("<span class='f_1 bold white italic'>Last Login: " + BusinessLayer.Return_Last_Login().ToString() + "</span>");

        lit_login_msg.Text = sb.ToString();
    }
}
