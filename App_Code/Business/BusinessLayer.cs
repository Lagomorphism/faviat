using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BusinessLayer
/// </summary>
public class BusinessLayer
{
    public static int Login(string username, string password)
    {
        int accound_id = 0;
        tblAccount a = ModelLayer.GetAccount(username, password);
        if (a != null)
            accound_id = a.iAccount;
        return accound_id;
    }

    public static int Check_Username_Existence(string username)
    {
        List<tblAccount> accounts = ModelLayer.GetAccounts(username);
        if (accounts != null && accounts.Count == 1)
            return 0;
        else if (accounts != null && accounts.Count > 1)
            return 1;
        else
            return 2;
    }

    public static tblQuestion Forgot_Password_Questions(string username)
    {
        tblAccount a = ModelLayer.GetAccount(username);
        tblQuestion q = new tblQuestion();
        int question_set_type = 0;

        if (a != null)
        {
            List<int> q_ids = new List<int>();
            tblQuestionSet qs = ModelLayer.GetQuestionSet(0, question_set_type);
            List<tblQuestion> questions = ModelLayer.GetQuestions(qs.iQuestionSet);

            foreach (tblQuestion question in questions)
            {
                q_ids.Add(question.iQuestion);
            }

            Random ranNum = new Random();
            int question_id = q_ids[ranNum.Next(q_ids.Count)];

            q = ModelLayer.GetQuestion(question_id);
        }

        return q;
    }

    public static bool Check_Login_Session()
    {
        if (System.Web.HttpContext.Current.Session[Constant.LOGGED_IN] == null)
            return false;
        else
            return true;
    }

    public static string Return_Full_Name()
    {
        string full_name = string.Empty;

        if (System.Web.HttpContext.Current.Session[Constant.PROFILE_ID] != null)
        {
            int profile_id = Convert.ToInt32(System.Web.HttpContext.Current.Session[Constant.PROFILE_ID].ToString());
            tblProfile p = ModelLayer.GetProfile(profile_id);
            full_name = p.vLastname + ", " + p.vFirstname;
        }

        return full_name;
    }

    public static DateTime? Return_Last_Login()
    {
        DateTime? last_login = null;

        if (System.Web.HttpContext.Current.Session[Constant.ACCOUNT_ID] != null)
        {
            int account_id = Convert.ToInt32(System.Web.HttpContext.Current.Session[Constant.ACCOUNT_ID].ToString());
            tblAccount a = ModelLayer.GetAccount(account_id);
            last_login = a.dLastUpdated;
        }

        return last_login;
    }
}