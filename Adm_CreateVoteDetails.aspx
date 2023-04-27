<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Adm_CreateVoteDetails.aspx.cs" Inherits="Adm_CreateVoteDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .style2
        {
            width: 58px;
        }
        .style3
        {
            width: 105px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="style3">
                <asp:Label ID="Label1" runat="server" Text="عنوان رای گیری"></asp:Label>
            </td>
            <td class="style2">
                <asp:DropDownList ID="DrpTitleRaigiri" runat="server" 
                    DataSourceID="LinqDtsOnvanRaigiri" DataTextField="RaigiriName" 
                    DataValueField="RaigiriTitleId" Height="16px" Width="187px" ValidationGroup="2" 
                    >
                </asp:DropDownList>
                <asp:LinqDataSource ID="LinqDtsOnvanRaigiri" runat="server" 
                    ContextTypeName="Lsc_EVotingDataContext" EntityTypeName="" 
                    OrderBy="RaigiriTitleId desc" TableName="tblRaigiriTitles">
                </asp:LinqDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                کاندید</td>
            <td class="style2">
                <asp:TextBox ID="TxtKandid" runat="server" Width="183px" ValidationGroup="2"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style2">
                <asp:Button ID="BtnInsert" runat="server" onclick="BtnInsert_Click" 
                    Text="درج" ValidationGroup="2" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="LblMessage" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1" colspan="3">
                <asp:GridView ID="dgJozeiatRai" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" DataSourceID="LinqDtsJozeiatRai" ForeColor="#333333" 
                    GridLines="None" Width="98%" AllowPaging="True" 
                    DataKeyNames="JozeiatRaiId" PageSize="5">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:BoundField DataField="JozeiatRaiId" HeaderText="کد چزئیات رای" 
                            SortExpression="JozeiatRaiId" InsertVisible="False" ReadOnly="True" />
                        <asp:BoundField DataField="RaigiriTitleId" HeaderText="کدعنوان رای گیری" 
                            SortExpression="RaigiriTitleId" />
                        <asp:BoundField DataField="RaiQuantity" HeaderText="تعدادرای" 
                            SortExpression="RaiQuantity" />
                        <asp:BoundField DataField="KandidName" HeaderText="کاندید" 
                            SortExpression="KandidName" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:LinqDataSource ID="LinqDtsJozeiatRai" runat="server" 
                    ContextTypeName="Lsc_EVotingDataContext" EntityTypeName="" 
                    OrderBy="JozeiatRaiId desc" TableName="tblJozeiatRais" EnableDelete="True" 
                    EnableUpdate="True">
                </asp:LinqDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

