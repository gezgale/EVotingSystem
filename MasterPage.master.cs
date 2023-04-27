using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserTypeID"] != null)
        {
            if (int.Parse(Session["UserTypeID"].ToString()) == 2)
            {
                GridView1.DataSourceID = "LinqDtsLinks";
                GridView1.DataBind();
            }
            else if (int.Parse(Session["UserTypeID"].ToString()) == 1)
            {
                GridView1.DataSourceID = "LinqDtsLinksAdmins";
                GridView1.DataBind();
            }
        }
        else
        {
            GridView1.DataSourceID = "LinqDtsLinksUsers";
            GridView1.DataBind();
        }
    }
}
