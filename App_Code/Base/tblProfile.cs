using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class tblProfile
{
    private int _iProfile;
    private string _vFirstname;
    private string _vLastname;
    private string _vAge;
    private string _vSex;
    private string _vAddress1;
    private string _vAddress2;
    private string _vAddress3;
    private string _vCity;
    private string _vState;
    private string _vCountry;
    private bool _bActive;
    private DateTime _dCreated;
    private DateTime _dLastUpdated;

    public int iProfile { get { return _iProfile; } set { _iProfile = value; } }
    public string vFirstname { get { return _vFirstname; } set { _vFirstname = value; } }
    public string vLastname { get { return _vLastname; } set { _vLastname = value; } }
    public string vAge { get { return _vAge; } set { _vAge = value; } }
    public string vSex { get { return _vSex; } set { _vSex = value; } }
    public string vAddress1 { get { return _vAddress1; } set { _vAddress1 = value; } }
    public string vAddress2 { get { return _vAddress2; } set { _vAddress2 = value; } }
    public string vAddress3 { get { return _vAddress3; } set { _vAddress3 = value; } }
    public string vCity { get { return _vCity; } set { _vCity = value; } }
    public string vState { get { return _vState; } set { _vState = value; } }
    public string vCountry { get { return _vCountry; } set { _vCountry = value; } }
    public bool bActive { get { return _bActive; } set { _bActive = value; } }
    public DateTime dCreated { get { return _dCreated; } set { _dCreated = value; } }
    public DateTime dLastUpdated { get { return _dLastUpdated; } set { _dLastUpdated = value; } }
}
