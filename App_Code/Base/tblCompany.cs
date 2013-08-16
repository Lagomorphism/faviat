using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class tblCompany
{
    private int _iCompany;
    private string _vCompanyName;
    private string _vCompanyAddress1;
    private string _vCompanyAddress2;
    private string _vCompanyAddress3;
    private string _vCompanyCity;
    private string _vCompanyState;
    private string _vCompanyCountry;
    private bool _bActive;
    private DateTime _dCreated;
    private DateTime _dLastUpdated;

    public int iCompany { get { return _iCompany; } set { _iCompany = value; } }
    public string vCompanyName { get { return _vCompanyName; } set { _vCompanyName = value; } }
    public string vCompanyAddress1 { get { return _vCompanyAddress1; } set { _vCompanyAddress1 = value; } }
    public string vCompanyAddress2 { get { return _vCompanyAddress2; } set { _vCompanyAddress2 = value; } }
    public string vCompanyAddress3 { get { return _vCompanyAddress3; } set { _vCompanyAddress3 = value; } }
    public string vCompanyCity { get { return _vCompanyCity; } set { _vCompanyCity = value; } }
    public string vCompanyState { get { return _vCompanyState; } set { _vCompanyState = value; } }
    public string vCompanyCountry { get { return _vCompanyCountry; } set { _vCompanyCountry = value; } }
    public bool bActive { get { return _bActive; } set { _bActive = value; } }
    public DateTime dCreated { get { return _dCreated; } set { _dCreated = value; } }
    public DateTime dLastUpdated { get { return _dLastUpdated; } set { _dLastUpdated = value; } }
}
