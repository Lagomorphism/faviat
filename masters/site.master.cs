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
        if (Check_Login_Session() != 0)
        {
            pnl_login_before.Visible = false;
            pnl_login_after.Visible = true;

            int account_id = Check_Login_Session();
            
            Load_FieldSet(account_id);
        }
        else
        {
            pnl_login_before.Visible = true;
            pnl_login_after.Visible = false;
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        string id = ((Control)sender).ID;

        switch (id)
        {
            case "rib_login":
                Response.RedirectToRoute("Login");
                break;
            case "rib_signin":
                Response.RedirectToRoute("Signup");
                break;
            case "rib_gotomyaccount":
                Response.RedirectToRoute("MyProfile");
                break;
            default:
                break;
        }
    }

    private int Check_Login_Session()
    {
        int account_id = 0;
        if (Session[Constant.ACCOUNT_ID] == null || Session[Constant.ACCOUNT_ID] == "0" || Session[Constant.ACCOUNT_ID] == string.Empty)
            return account_id;
        else
            return Convert.ToInt32(Session[Constant.ACCOUNT_ID].ToString());
    }

    private void Load_FieldSet(int account_id)
    {
        tblAccount a = ModelLayer.GetAccount(account_id);
        int profile_id = a.iProfile;
        label_full_name.Text = BusinessLayer.Return_Full_Name(profile_id);

        StringBuilder sb = new StringBuilder();
        sb.Append("<span class='f_1 bold white italic'>Last Login: " + BusinessLayer.Return_Last_Login(account_id).ToString() + "</span>");
        lit_login_msg.Text = sb.ToString();
    }
}
