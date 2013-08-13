using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tblAccount
/// </summary>
public class tblAccount
{
    private int _iAccount;
    private int _iProfile;
    private int _iAccess;
    private int _iCompany;
    private int _iAccountType;
    private string _vEmail;
    private string _vPassword;
    private bool _bActive;
    private bool _bLockedout;
    private DateTime _dCreated;
    private DateTime _dLastUpdated;

    public int iAccount { get { return _iAccount; } set { _iAccount = value; } }
    public int iProfile { get { return _iProfile; } set { _iProfile = value; } }
    public int iAccess { get { return _iAccess; } set { _iAccess = value; } }
    public int iCompany { get { return _iCompany; } set { _iCompany = value; } }
    public int iAccountType { get { return _iAccountType; } set { _iAccountType = value; } }
    public string vEmail { get { return _vEmail; } set { _vEmail = value; } }
    public string vPassword { get { return _vPassword; } set { _vPassword = value; } }
    public bool bActive { get { return _bActive; } set { _bActive = value; } }
    public bool bLockedout { get { return _bLockedout; } set { _bLockedout = value; } }
    public DateTime dCreated { get { return _dCreated; } set { _dCreated = value; } }
    public DateTime dLastUpdated { get { return _dLastUpdated; } set { _dLastUpdated = value; } }
}