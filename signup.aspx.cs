using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LoadDDL();
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        string id = ((Control)sender).ID;

        switch (id)
        {
            case "btn_join":
                int exist_indicator = BusinessLayer.Check_Username_Existence(txt_email.Text);
                if (exist_indicator == 2)
                {
                    Response.RedirectToRoute("Login");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<span>");
                    sb.Append("Sorry, it looks like " + txt_email.Text + " belongs to an existing account.");
                    sb.Append("</span>");
                    lit_error.Text = sb.ToString();
                }
                break;
            case "btn_cancel":
                txt_fname.Text = string.Empty;
                txt_lname.Text = string.Empty;
                txt_email.Text = string.Empty;
                txt_password.Text = string.Empty;
                txt_confirm_password.Text = string.Empty;
                break;
            default:
                break;
        }
    }

    private void LoadDDL()
    {
        List<tblAccountType> account_types = ModelLayer.GetAccountTypes();

        ListItem item = new ListItem("Please Select.", "0");
        ddl_account_type.Items.Insert(0, item);

        foreach (tblAccountType account_type in account_types)
        {
            ddl_account_type.Items.Add(new ListItem(account_type.vAccountType, account_type.iAccountType.ToString()));
        }
    }
}