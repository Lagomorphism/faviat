using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tblQuestionType
/// </summary>
public class tblQuestionType
{
    private int _iQuestionType;
    private string _vQuestionType;
    private bool _bActive;
    private DateTime _dCreated;
    private DateTime _dLastUpdated;

    public int iQuestionType { get { return _iQuestionType; } set { _iQuestionType = value; } }
    public string vQuestionType { get { return _vQuestionType; } set { _vQuestionType = value; } }
    public bool bActive { get { return _bActive; } set { _bActive = value; } }
    public DateTime dCreated { get { return _dCreated; } set { _dCreated = value; } }
    public DateTime dLastUpdated { get { return _dLastUpdated; } set { _dLastUpdated = value; } }
}