using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Cubelique.Account.Base;
using Account=Cubelique.Account.Business;
using Cubelique.Question.Base;
using Question=Cubelique.Question.Business;

public partial class forgot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Click(object sender, EventArgs e)
    {
        string id = ((Control)sender).ID;

        switch (id)
        {
            case "btn_submit":
                int account_id = Account.BusinessLayer.Check_Username_Existence(txt_forgot_password.Text);
                
                if (account_id == 0)
                    LoadQuestions(txt_forgot_password.Text);
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<p class='error'>Your account does not exist.<br />Please check email address again.<br /></p>");
                    lit_error.Text = sb.ToString();
                }
                break;
            default:
                break;
        }
    }

    private void LoadQuestions(string email)
    {
        tblQuestion q = Question.BusinessLayer.Forgot_Password_Questions(email);
        
        StringBuilder sb = new StringBuilder();
        lit_question.Text = sb.ToString();

        StringBuilder sb2 = new StringBuilder();
        lit_question_answer.Text = sb2.ToString();
    }
}