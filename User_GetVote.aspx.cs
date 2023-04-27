using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_GetVote : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    bool check=false;
    decimal CurrentRow;
    string str_Username;
    private bool CheckRai()
         {
             Lsc_EVotingDataContext db = new Lsc_EVotingDataContext();
             str_Username = Session["UserName"].ToString();
             tblRaidahandegan user = db.tblRaidahandegans.SingleOrDefault (n => n.UsersNmae.Trim() == str_Username.Trim());
             if (user  == null  )
                 check = false;
             else check = true;
             return check;
         }

    private void sabtRaiDahande()
    {
        try
        {
            Lsc_EVotingDataContext db1 = new Lsc_EVotingDataContext();
            tblRaidahandegan addRaydahandegan = new tblRaidahandegan();
            Class_ShamsiTools shamsi = new Class_ShamsiTools();

            shamsi.UDF_GetCurrentShamsiDate();
            addRaydahandegan.DateRai = shamsi.CurrentShmasiDate;
            addRaydahandegan.UsersNmae =Session["UserName"].ToString(); 
            
            addRaydahandegan.JozeiatRaiId = decimal.Parse(dgJozeiat.SelectedValue.ToString());
            db1.tblRaidahandegans.InsertOnSubmit(addRaydahandegan);
            db1.SubmitChanges();
        }
        catch
        {
        }
    }
    private void rai()
    {
        try
        {
            Lsc_EVotingDataContext db = new Lsc_EVotingDataContext();
            CurrentRow = decimal.Parse(dgJozeiat.SelectedValue.ToString());
            tblJozeiatRai upd = db.tblJozeiatRais.Single(n => n.JozeiatRaiId == CurrentRow);
            upd.RaiQuantity = upd.RaiQuantity + 1;
            db.SubmitChanges();
        }
        catch
        {
        }
     }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!CheckRai())
        {
            rai();
            sabtRaiDahande();
            dgJozeiat.DataBind();
        }
        else
        {
            LblMessage.Visible = true;
            LblMessage.Text =Session["UserName"]+" " +"شما قبلا رای داده اید!";
        }
       
    }
}