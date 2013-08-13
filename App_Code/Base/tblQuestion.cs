using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tblQuestion
/// </summary>
public class tblQuestion
{
    private int _iQuestion;
    private int _iQuestionSet;
    private int _iQuestionIndex;
    private int _iQuestionType;
    private int _iQuestionAnswer;
    private string _vQuestion;
    private bool _bActive;
    private DateTime _dCreated;
    private DateTime _dLastUpdated;

    public int iQuestion { get { return _iQuestion; } set { _iQuestion = value; } }
    public int iQuestionSet { get { return _iQuestionSet; } set { _iQuestionSet = value; } }
    public int iQuestionIndex { get { return _iQuestionIndex; } set { _iQuestionIndex = value; } }
    public int iQuestionType { get { return _iQuestionType; } set { _iQuestionType = value; } }
    public int iQuestionAnswer { get { return _iQuestionAnswer; } set { _iQuestionAnswer = value; } }
    public string vQuestion { get { return _vQuestion; } set { _vQuestion = value; } }
    public bool bActive { get { return _bActive; } set { _bActive = value; } }
    public DateTime dCreated { get { return _dCreated; } set { _dCreated = value; } }
    public DateTime dLastUpdated { get { return _dLastUpdated; } set { _dLastUpdated = value; } }
}