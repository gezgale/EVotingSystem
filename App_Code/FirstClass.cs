using System;
using System.Data;
using System.Data.SqlClient;
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
/// Summary description for FirstClass
/// </summary>
public class FirstClass
{
    SqlConnection con;
    public SqlCommand cmd;
    DataTable dt;
    SqlDataAdapter da;

    public FirstClass()
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["EvotingDBConnectionString"].ConnectionString);
        cmd = new SqlCommand();
        dt = new DataTable();
        cmd.Connection = con;
        da = new SqlDataAdapter(cmd);

    }

    public DataTable dbOut(string sql)
    {
        cmd.CommandText = sql;
        con.Open();
        da.Fill(dt);
        con.Close();
        return dt;
    }

    public DataTable SP_dbOut(string SP_Name)
    {
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = SP_Name;
        con.Open();
        da.Fill(dt);
        con.Close();
        return dt;
    }

    public void exeCommand(string strName)
    {
        con.Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = strName;
        cmd.ExecuteNonQuery();
        con.Close();

    }

    public void exeCommand1(string strName)
    {
        try
        {
            cmd.CommandText = strName;
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch { }
        finally
        {
            con.Close();
        }

    }



    public SqlDataReader dtr101(string sql)
    {
        //cmd = new SqlCommand(sql, con);
        cmd.CommandText = sql;
        con.Open();
        SqlDataReader dtr = cmd.ExecuteReader();

        //dtr.GetString();
        return dtr;
    }

    public string dtShamsi()
    {
        string strMydate;
        PersianCalendar calFar1 = new PersianCalendar();
        strMydate = calFar1.GetYear(DateTime.Now).ToString() + "/" + calFar1.GetMonth(DateTime.Now).ToString("00") + "/" + calFar1.GetDayOfMonth(DateTime.Now).ToString("00");
        return strMydate;
    }

    public int userDuplicate(string sql)
    {

        int i = 0;
        cmd.CommandText = sql;
        con.Open();
        da.Fill(dt);
        if (dt.Rows.Count <= 0)
        {
            i = 0;
        }
        else
        {
            i = 1;
        }
        con.Close();
        return i;
    }
}
