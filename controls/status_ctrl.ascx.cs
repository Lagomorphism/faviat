using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class controls_status_ctrl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadStatus();
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {

    }

    private void LoadStatus()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<table style='width: 100%;'><tbody>");

        sb.Append("<tr>");

        sb.Append("<td style='width:35%;'>");
        sb.Append("<b>Applied:</b>");
        sb.Append("</td>");
        sb.Append("<td style='width:15%;'>");
        sb.Append("6");
        sb.Append("</td>"); 

        sb.Append("<td style='width:40%;'>");
        sb.Append("<b>Total:</b>");
        sb.Append("</td>");
        sb.Append("<td style='width:10%;'>");
        sb.Append("10");
        sb.Append("</td>");

        sb.Append("</tr>");

        sb.Append("<tr>");

        sb.Append("<td>");
        sb.Append("<b>Passed:</b>");
        sb.Append("</td>");
        sb.Append("<td>");
        sb.Append("3");
        sb.Append("</td>");

        sb.Append("<td style='width:40%;'>");
        sb.Append("<b>Recommended:</b>");
        sb.Append("</td>");
        sb.Append("<td style='width:10%;'>");
        sb.Append("7");
        sb.Append("</td>");

        sb.Append("</tr>");

        sb.Append("<tr>");

        sb.Append("<td>");
        sb.Append("<b>Rejected:</b>");
        sb.Append("</td>");
        sb.Append("<td>");
        sb.Append("2");
        sb.Append("</td>");

        sb.Append("<td style='width:40%;'>");
        sb.Append("<b>Boo:</b>");
        sb.Append("</td>");
        sb.Append("<td style='width:10%;'>");
        sb.Append("3");
        sb.Append("</td>");

        sb.Append("</tr>");

        sb.Append("<tr>");

        sb.Append("<td>");
        sb.Append("<b>Waiting:</b>");
        sb.Append("</td>");
        sb.Append("<td>");
        sb.Append("1");
        sb.Append("</td>");

        sb.Append("</tr>");

        sb.Append("</tbody></table>");

        lit_status.Text = sb.ToString();
    }
}