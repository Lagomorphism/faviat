using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class controls_news_ctrl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadNews();
        }
    }

    private void LoadNews()
    {
        DateTime currentDate = DateTime.Today;
        List<DateTime> LastThreeDays = new List<DateTime>();

        for (int i = 0; i < 4; i++)
        {
            DateTime date = new DateTime();
            date = currentDate.AddDays(-i);
            LastThreeDays.Add(date);
        }
        
        StringBuilder sb = new StringBuilder();

        foreach (DateTime date in LastThreeDays)
        {
            sb.Append("<p class='bold italic'>" + date.ToString("D") + "</p>");
            sb.Append("<ul style='margin-left: -3%;'>");
            sb.Append("<li>" + "<a href='#' target='_blank'>News link goes here</a>" + "</li>");
            sb.Append("</ul>");
        }

        lit_news.Text = sb.ToString();
    }
    protected void btn_Click(object sender, EventArgs e)
    {

    }
}