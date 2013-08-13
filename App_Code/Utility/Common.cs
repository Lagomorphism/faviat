using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Common
/// </summary>
public class Common
{
	public static void ErrorLog(string path, string log)
    {
        string sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";

        StreamWriter sw = new StreamWriter(path, true);
        sw.WriteLine(sLogFormat + log);
        sw.Flush();
        sw.Close();
        sw.Dispose();
    }
}