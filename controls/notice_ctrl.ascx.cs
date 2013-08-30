using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class controls_notice_ctrl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadNotice();
        }
    }

    private void LoadNotice()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<p>Personal Notice goes here like interview reminder, company poke, etc</p>");

        lit_notice.Text = sb.ToString();
    }
}