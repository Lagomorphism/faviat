using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_profile_ctrl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session[Constant.ACCOUNT_ID] != null)
                LoadProfile(Convert.ToInt32(Session[Constant.ACCOUNT_ID].ToString()));
            else
                LoadProfile(0);
        }
    }

    private void LoadProfile(int iAccount)
    {
        if (iAccount != 0)
        {
            tblAccount a = ModelLayer.GetAccount(iAccount);
            tblProfile p = ModelLayer.GetProfile(a.iProfile);
            tblAccountType at = ModelLayer.GetAccountType(a.iAccountType);

            label_name.Text = p.vLastname + ", " + p.vFirstname;
            label_country.Text = p.vCountry;
            label_account_type.Text = at.vAccountType;
            label_age.Text = p.vAge;
            label_sex.Text = p.vSex;
        }
        else
        {
            label_name.Text = "Admin";
            label_country.Text = "Admin";
            label_account_type.Text = "Admin";
            label_age.Text = "Admin";
            label_sex.Text = "Admin";
        }
    }
    protected void btn_Click(object sender, EventArgs e)
    {

    }
}