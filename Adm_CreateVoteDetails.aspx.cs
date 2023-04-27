using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adm_CreateVoteDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null  ||  int.Parse(Session["UserTypeID"].ToString()) != 1)
            Response.Redirect("ErrorPage.aspx");
           
        LblMessage.Visible = false;
    }
    protected void BtnInsert_Click(object sender, EventArgs e)
    {
        try
        {
            Lsc_EVotingDataContext db = new Lsc_EVotingDataContext();
            tblJozeiatRai add = new tblJozeiatRai();
            add.KandidName = TxtKandid.Text;
            add.RaigiriTitleId = int.Parse(DrpTitleRaigiri.SelectedValue.ToString());
            add.RaiQuantity = 0;
            db.tblJozeiatRais.InsertOnSubmit(add);
            db.SubmitChanges();
            LblMessage.Visible = true;
            LblMessage.Text = "عملیات درج انجام شد!";
            dgJozeiatRai.DataBind();
        }
        catch
        {
            LblMessage.Visible = true;
            LblMessage.Text = "عملیات درج انجام نشد!";
        }
    }
   
}