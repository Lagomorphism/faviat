using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class controls_resource_ctrl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadResource();
        }
    }

    private void LoadResource()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<ul style='margin-left: -3%;'>");
        sb.Append("<li>" + "<a href='#'>Resource Link 1</a>" + "</li>");
        sb.Append("<li>" + "<a href='#'>Resource Link 2</a>" + "</li>");
        sb.Append("<li>" + "<a href='#'>Resource Link 3</a>" + "</li>");
        sb.Append("<li>" + "<a href='#'>Resource Link 4</a>" + "</li>");
        sb.Append("<li>" + "<a href='#'>Resource Link 5</a>" + "</li>");
        sb.Append("</ul>");

        lit_resource.Text = sb.ToString();
    }
}