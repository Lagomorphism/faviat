using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class tblQuestionOption
{
    private int _iQuestionOption;
    private int _iQuestion;
    private int _iQuestionOptionIndex;
    private string _vQuestionOption;
    private bool _bActive;
    private DateTime _dCreated;
    private DateTime _dLastUpdated;

    public int iQuestionOption { get { return _iQuestionOption; } set { _iQuestionOption = value; } }
    public int iQuestion { get { return _iQuestion; } set { _iQuestion = value; } }
    public int iQuestionOptionIndex { get { return _iQuestionOptionIndex; } set { _iQuestionOptionIndex = value; } }
    public string vQuestionOption { get { return _vQuestionOption; } set { _vQuestionOption = value; } }
    public bool bActive { get { return _bActive; } set { _bActive = value; } }
    public DateTime dCreated { get { return _dCreated; } set { _dCreated = value; } }
    public DateTime dLastUpdated { get { return _dLastUpdated; } set { _dLastUpdated = value; } }
}
