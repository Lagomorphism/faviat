using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tblQuestionSet
/// </summary>
public class tblQuestionSet
{
    private int _iQuestionSet;
    private int _iCompany;
    private int _iQuestionSetType;
    private string _vQuestionSet;
    private bool _bActive;
    private DateTime _dCreated;
    private DateTime _dLastUpdated;

    public int iQuestionSet { get { return _iQuestionSet; } set { _iQuestionSet = value; } }
    public int iCompany { get { return _iCompany; } set { _iCompany = value; } }
    public int iQuestionSetType { get { return _iQuestionSetType; } set { _iQuestionSetType = value; } }
    public string vQuestionSet { get { return _vQuestionSet; } set { _vQuestionSet = value; } }
    public bool bActive { get { return _bActive; } set { _bActive = value; } }
    public DateTime dCreated { get { return _dCreated; } set { _dCreated = value; } }
    public DateTime dLastUpdated { get { return _dLastUpdated; } set { _dLastUpdated = value; } }
}