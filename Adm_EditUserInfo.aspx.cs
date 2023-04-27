using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adm_EditUserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Txt_UserName.Enabled = false;
            Txt_tt.Enabled = false;
            Lbl_UserNam.Enabled = false;
            Lbl_UserPWA3.Enabled = false;

            Lsc_EVotingDataContext db = new Lsc_EVotingDataContext();
            var query = from Row in db.tblUsers
                        where Row.UsersName.Trim() == Session["UserName"].ToString().Trim()
                        select Row;
            foreach (var r in query)
            {
                Txt_Name.Text = r.NameOfUser;
                Txt_PassWord.Text = r.UsersPwa;
                Txt_Phone.Text = r.UserMobilePhone;
                Txt_SName.Text = r.SnameOfUser;
                Txt_tt.Text = r.UserEmail;
                Txt_UserName.Text = r.UsersName;
            }
        }
    }
    protected void Btn_Update_Click(object sender, EventArgs e)
    {
        Lbl_Massage.Visible = false;
       
        try
        {
            Lsc_EVotingDataContext db = new Lsc_EVotingDataContext();
            tblUser add = db.tblUsers.Single(n => n.UsersName == Session["UserName"].ToString());
            add.NameOfUser = Txt_Name.Text;
            add.SnameOfUser = Txt_SName.Text;
            add.UserEmail = Txt_tt.Text;
            add.UserMobilePhone = Txt_Phone.Text;
            add.UsersName = Txt_UserName.Text;
            add.UsersPwa = Txt_PassWord.Text;
            add.UserTypeID = 2;
            db.SubmitChanges();
            Lbl_Massage.Visible = true;
            Lbl_Massage.Text = "عملیات ویرایش انجام شد!";
            Txt_Name.Text = "";
            Txt_SName.Text = "";
            Txt_tt.Text = "";
            Txt_Phone.Text = "";
            Txt_UserName.Text = "";
            Txt_PassWord.Text = "";
        }
        catch
        {
            Lbl_Massage.Visible = true;
            Lbl_Massage.Text = "عملیات ویرایش انجام نشد!";
        }
    }
    
}