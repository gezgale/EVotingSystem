<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Adm_EditUserInfo.aspx.cs" Inherits="Adm_EditUserInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
 <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="Lbl_UserNam" runat="server" Text="نام کاربری:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt_UserName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lbl_UserPWA" runat="server" Text="کلمه عبور:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt_PassWord" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lbl_UserPWA0" runat="server" Text="نام :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt_Name" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lbl_UserPWA1" runat="server" Text="نام خانوادگی:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt_SName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lbl_UserPWA3" runat="server" Text="ایمیل:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt_tt" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lbl_UserPWA4" runat="server" Text="موبایل /تلفن:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt_Phone" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="Txt_tt" ErrorMessage="قالب ایمیل صحیح نمی باشد!" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Btn_Update" runat="server"  
                    Text="ویرایش" Width="56px" Height="29px" onclick="Btn_Update_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                </td>
            <td class="style1">
                </td>
            <td class="style1">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Lbl_Massage" runat="server" Text="عملیلت ویرایش انجام شد!" 
                    Font-Bold="True" ForeColor="#FF6600" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

