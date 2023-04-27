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
using System.Globalization;

/// <summary>
/// کلاس شمسی
/// </summary>
public class Class_ShamsiTools
{
    private String Str_CurrentShamsiDate = String.Empty;

    public Class_ShamsiTools()
    {
    }

    // Not Needwd Method
    public Class_ShamsiTools(DateTime MiladiDate)
    {
        DateTime Dt_Now = MiladiDate;
        PersianCalendar Per_Calendar = new PersianCalendar();
        Str_CurrentShamsiDate = Per_Calendar.GetYear(Dt_Now).ToString() + "/" + Per_Calendar.GetMonth(Dt_Now).ToString("00") + "/" + Per_Calendar.GetDayOfMonth(Dt_Now).ToString("00");
    }

    public void UDF_GetCurrentShamsiDate()
    {
        DateTime Dt_Now = DateTime.Now;
        PersianCalendar Per_Calendar = new PersianCalendar();
        Str_CurrentShamsiDate = Per_Calendar.GetYear(Dt_Now).ToString() + "/" + Per_Calendar.GetMonth(Dt_Now).ToString("00") + "/" + Per_Calendar.GetDayOfMonth(Dt_Now).ToString("00");
    }

    public String CurrentShmasiDate
    {
        get
        {
            return Str_CurrentShamsiDate;
        }
    }
}
