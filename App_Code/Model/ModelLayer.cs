using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ModelLayer
/// </summary>
public class ModelLayer
{
    #region Account
    public static tblAccount GetAccount(int iAccount)
    {
        tblAccount a = new tblAccount();

        return a;
    }

    public static tblAccount GetAccount(string username)
    {
        tblAccount a = new tblAccount();

        return a;
    }

    public static tblAccount GetAccount(string username, string password)
    {
        tblAccount a = new tblAccount();

        return a;
    }

    public static List<tblAccount> GetAccounts(string username)
    {
        List<tblAccount> accounts = new List<tblAccount>();

        return accounts;
    }

    public static tblProfile GetProfile(int iProfile)
    {
        tblProfile p = new tblProfile();

        return p;
    }
    #endregion

    #region Question
    public static tblQuestionSet GetQuestionSet(int iCompany, int iQuestionSetType)
    {
        tblQuestionSet q = new tblQuestionSet();

        return q;
    }

    public static tblQuestion GetQuestion(int iQuestion)
    {
        tblQuestion q = new tblQuestion();

        return q;
    }

    public static List<tblQuestion> GetQuestions(int iQuestionSet)
    {
        List<tblQuestion> qs = new List<tblQuestion>();

        return qs;
    }

    public static tblQuestionAnswer GetQuestionAnswer(int iQuestionAnswer)
    {
        tblQuestionAnswer a = new tblQuestionAnswer();

        return a;
    }
    #endregion
}