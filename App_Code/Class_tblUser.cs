using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class_User
/// </summary>
public class Class_tblUser
{
    string UsersName, UsersPwa, NameOfUser, SnameOfUser, UserEmail, UserMobilePhone;
    int TypeUser;
    public Class_tblUser(string _UsersName,string  _UsersPwa,string  _NameOfUser,string  _SnameOfUser,string  _UserEmail,string  _UserMobilePhone,int _TypeId)
	{
		UsersName=_UsersName;
        UsersPwa=_UsersPwa;
        NameOfUser=_NameOfUser;
        SnameOfUser=_SnameOfUser;
        UserEmail=_UserEmail;
        UserMobilePhone = _UserMobilePhone;
        TypeUser = _TypeId;
	}
    private void InsertUser()
    {
        Lsc_EVotingDataContext db = new Lsc_EVotingDataContext();
        tblUser AddUser = new tblUser();
        AddUser.NameOfUser = UsersName;
        AddUser.SnameOfUser = SnameOfUser;
        AddUser.UserEmail = UserEmail;
        AddUser.UserMobilePhone = UserMobilePhone;
    }
}