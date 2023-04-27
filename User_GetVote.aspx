<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User_GetVote.aspx.cs" Inherits="User_GetVote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td colspan="3">
                <asp:GridView ID="dgJozeiat" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" DataSourceID="LinqDtsJozeiatRai" ForeColor="#333333" 
                    GridLines="None" Width="98%" DataKeyNames="JozeiatRaiId" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="JozeiatRaiId" HeaderText="کد" 
                            SortExpression="JozeiatRaiId" />
                        <asp:BoundField DataField="RaigiriName" HeaderText="عنوان" 
                            SortExpression="RaigiriName" />
                        <asp:BoundField DataField="RaiQuantity" HeaderText="تعداد" 
                            SortExpression="RaiQuantity" />
                        <asp:BoundField DataField="KandidName" HeaderText="کاندید" 
                            SortExpression="KandidName" />
                        <asp:BoundField DataField="RaigiriTitleId" HeaderText="RaigiriTitleId" 
                            SortExpression="RaigiriTitleId" Visible="False" />
                        <asp:CommandField ShowSelectButton="True" SelectText="رای" />
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
                    TableName="xtblJozeiatRais" Where="RaigiriTitleId == @RaigiriTitleId">
                    <WhereParameters>
                        <asp:QueryStringParameter Name="RaigiriTitleId" QueryStringField="ID" 
                            Type="Int32" />
                    </WhereParameters>
                </asp:LinqDataSource>
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
                <asp:Label ID="LblMessage" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Chart ID="Chart1" runat="server" DataSourceID="LinqDtsJoze">
                    <Series>
                        <asp:Series Name="Series1" XValueMember="KandidName" 
                            YValueMembers="RaiQuantity">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
                <asp:LinqDataSource ID="LinqDtsJoze" runat="server" 
                    ContextTypeName="Lsc_EVotingDataContext" EntityTypeName="" 
                    TableName="tblJozeiatRais" Where="RaigiriTitleId == @RaigiriTitleId">
                    <WhereParameters>
                        <asp:QueryStringParameter Name="RaigiriTitleId" QueryStringField="ID" 
                            Type="Int32" />
                    </WhereParameters>
                </asp:LinqDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

