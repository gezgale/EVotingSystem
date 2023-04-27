using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Class_TimeTypes
/// </summary>
public class Class_TimeTypes
{
    private String Str_SimpleTime = String.Empty;

    public Class_TimeTypes()
    {
    }

    public void UDF_MakeSimpleTime()
    {
        Str_SimpleTime = DateTime.Now.TimeOfDay.Hours.ToString("00") + ":" + DateTime.Now.TimeOfDay.Minutes.ToString("00");
    }

    /// <summary>
    /// زمان با قالب ساده به صورت 04:25
    /// </summary>
    public String Str_SimpleTimes
    {
        get
        {
            return Str_SimpleTime;
        }
    }
}
