using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class tblAccountType
{
    private int _iAccountType;
    private string _vAccountType;
    private bool _bActive;
    private DateTime _dCreated;
    private DateTime _dLastUpdated;

    public int iAccountType { get { return _iAccountType; } set { _iAccountType = value; } }
    public string vAccountType { get { return _vAccountType; } set { _vAccountType = value; } }
    public bool bActive { get { return _bActive; } set { _bActive = value; } }
    public DateTime dCreated { get { return _dCreated; } set { _dCreated = value; } }
    public DateTime dLastUpdated { get { return _dLastUpdated; } set { _dLastUpdated = value; } }
}
