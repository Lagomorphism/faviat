using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class tblAccess
{
    private int _iAccess;
    private string _vAccessName;
    private bool _bCreate;
    private bool _bModify;
    private bool _bDelete;
    private bool _bActive;
    private DateTime _dCreated;
    private DateTime _dLastUpdated;

    public int iAccess { get { return _iAccess; } set { _iAccess = value; } }
    public string vAccessName { get { return _vAccessName; } set { _vAccessName = value; } }
    public bool bCreate { get { return _bCreate; } set { _bCreate = value; } }
    public bool bModify { get { return _bModify; } set { _bModify = value; } }
    public bool bDelete { get { return _bDelete; } set { _bDelete = value; } }
    public bool bActive { get { return _bActive; } set { _bActive = value; } }
    public DateTime dCreated { get { return _dCreated; } set { _dCreated = value; } }
    public DateTime dLastUpdated { get { return _dLastUpdated; } set { _dLastUpdated = value; } }
}
