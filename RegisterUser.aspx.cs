using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisterUser : System.Web.UI.Page
{
    protected void Btn_Insert_Click(object sender, EventArgs e)
    {
        Lbl_Massage.Visible = false;
        if ((CheckUseName() == true) && (CheckEmail(Txt_tt.Text) == 1))
        {
            Lsc_EVotingDataContext db = new Lsc_EVotingDataContext();
            tblUser add = new tblUser();
            add.NameOfUser = Txt_Name.Text;
            add.SnameOfUser = Txt_SName.Text;
            add.UserEmail = Txt_tt.Text;
            add.UserMobilePhone = Txt_Phone.Text;
            add.UsersName = Txt_UserName.Text;
            add.UsersPwa = Txt_PassWord.Text;
            add.UserTypeID = 2;
            db.tblUsers.InsertOnSubmit(add);
            db.SubmitChanges();
            Lbl_Massage.Visible = true;
            Lbl_Massage.Text = "عملیات درج انجام شد!";
            Txt_Name.Text = "";
            Txt_SName.Text="";
            Txt_tt.Text="";
            Txt_Phone.Text="";
            Txt_UserName.Text="";
            Txt_PassWord.Text="";
        }
        else
        {
            Lbl_Massage.Visible = true;
            Lbl_Massage.Text = "ایمیل یا نام کاربری تکراری می باشد!";
        }
    }
    private bool  CheckUseName()
    {
        Lsc_EVotingDataContext db2 = new Lsc_EVotingDataContext();
        try
        {
            tblUser User1 = db2.tblUsers.Single(n => n.UsersName.Trim() == Txt_UserName.Text.Trim());
        }
        catch
        {
            return true ; 
        }
        return false;
    }
        private int  CheckEmail(string Str_email)
    {
        Lsc_EVotingDataContext db1 = new Lsc_EVotingDataContext();
        try
        {
            tblUser User2 = db1.tblUsers.Single(n => n.UserEmail.Trim() == Str_email.Trim());
            Response.Write(User2.SnameOfUser.ToString());
        }
        catch
        {
            return 1;
        }
        return 0;
    }
}