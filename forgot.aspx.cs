using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class forgot : System.Web.UI.Page
{
    int question_id = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        string id = ((Control)sender).ID;
        int question_id = 0;

        switch (id)
        {
            case "btn_check":
                int account_id = BusinessLayer.Check_Username_Existence(txt_forgot_password.Text);

                if (account_id == 0)
                {
                    question_id = LoadQuestions(txt_forgot_password.Text);
                    pnl_email.Visible = false;
                    pnl_question.Visible = true;
                    pnl_confirm.Visible = false;
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<p class='error bold'>Your account does not exist. Please check email address again.</p>");
                    lit_error.Text = sb.ToString();
                }
                break;
            case "btn_submit":
                tblQuestion q = ModelLayer.GetQuestion(question_id);
                tblQuestionAnswer a = ModelLayer.GetQuestionAnswer(q.iQuestionAnswer);

                if (a.vQuestionAnswer == txt_question_answer.Text)
                {
                    string result = SendEmail(txt_forgot_password.Text);

                    if (result == "Success")
                    {
                        pnl_email.Visible = false;
                        pnl_question.Visible = false;
                        pnl_confirm.Visible = true;
                    }
                    else
                    {
                        Common.ErrorLog(@"c:\logs\debug.txt", result);
                    }
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<p class='error bold'>Your security question answer does not match with our records. Please check your answer again.</p>");
                    lit_error.Text = sb.ToString();
                }
                break;
            case "btn_confirm":
                Response.Redirect("~/Login");
                break;
            default:
                break;
        }
    }

    private int LoadQuestions(string email)
    {
        int question_id = 0;

        tblQuestion q = BusinessLayer.Forgot_Password_Questions();

        question_id = q.iQuestion;

        StringBuilder sb = new StringBuilder();
        sb.Append("<label class='f_1 bold lh_1 clear'>");
        sb.Append(q.iQuestionIndex + ". " + q.vQuestion + "?");
        sb.Append("</label>");
        lit_question.Text = sb.ToString();

        return question_id;
    }

    private string SendEmail(string toAddress)
    {
        string sMsg = "Success";

        return sMsg;
    }
}