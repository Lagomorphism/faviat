using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class tblQuestionAnswer
{
    private int _iQuestionAnswer;
    private string _vQuestionAnswer;
    private bool _bActive;
    private DateTime _dCreated;
    private DateTime _dLastUpdated;

    public int iQuestionAnswer { get { return _iQuestionAnswer; } set { _iQuestionAnswer = value; } }
    public string vQuestionAnswer { get { return _vQuestionAnswer; } set { _vQuestionAnswer = value; } }
    public bool bActive { get { return _bActive; } set { _bActive = value; } }
    public DateTime dCreated { get { return _dCreated; } set { _dCreated = value; } }
    public DateTime dLastUpdated { get { return _dLastUpdated; } set { _dLastUpdated = value; } }
}
