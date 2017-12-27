<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PriorityBasedFinancialPlan.aspx.cs" Inherits="Banking_Advisor_bot.PriorityBasedFinancialPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <table style="color: #000066; border-style: double; border-width: medium; caption-side: top; background-color: #C0C0C0; height: 151px; width: 679px;">
        <tr>
            <td class="auto-style1"> <strong>Expense Type</strong></td>
            <td style="position: fixed"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;Expenses</strong> </td>
            </tr>
         <tr>
            <td class="auto-style1"> Household :</td>
            <td> House rent, Utilities, Grocery shopping </td>
            </tr>
         <tr>
            <td class="auto-style1"> Health :</td>
            <td> Health related expenses </td>
            </tr>
        <tr>
            <td class="auto-style1"> Education :</td>
            <td> Expenses on education </td>
            </tr>
        <tr>
            <td class="auto-style1" style="height: 20px"> Travel :</td>
            <td style="height: 20px"> Transportation, traveling expenses </td>
            </tr>
        <tr>
            <td class="auto-style1"> Lifestyle :</td>
            <td> Entertainment, outside eating expenses, other EMI, other expenses </td>
            </tr>
        </table>
    </div>
    <table style="width:100%; height: 508px;">  
        <caption class="style3" style="color: #000066; background-color: #999966; width: 289px;">  
            <strong>Financial Information</strong></caption>  
        <tr>  
              
            <td style="height: 224px" >  
      
    <asp:GridView ID="FinancialDataGrid" runat="server"   
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px"   
        CellPadding="2" ForeColor="Black" GridLines="None" >  
        <AlternatingRowStyle BackColor="#FFFFCC" />  
         
        <FooterStyle BackColor="Tan" />  
        <HeaderStyle BackColor="Tan" Font-Bold="True" />  
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue"   
            HorizontalAlign="Center" />  
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />  
        <SortedAscendingCellStyle BackColor="#FAFAE7" />  
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />  
        <SortedDescendingCellStyle BackColor="#E1DB9C" />  
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />  
    </asp:GridView>  
            </td>  
              
        </tr>  
                
           
        <tr>  
              
            <td title="Priority Based Smart Financial Plan" >  
      
    <asp:GridView ID="GridFinancialPlanResult" runat="server"   
        BackColor="#33CCFF" BorderColor="Tan" BorderWidth="1px"   
        CellPadding="2" ForeColor="Black" GridLines="None" CaptionAlign="Top" >  
        <AlternatingRowStyle BackColor="#CCCCFF" />  
         
        <FooterStyle BackColor="Tan" />  
        <HeaderStyle BackColor="#CC66FF" Font-Bold="True" />  
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue"   
            HorizontalAlign="Center" />  
        <RowStyle BackColor="#CCCCFF" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />  
        <SortedAscendingCellStyle BackColor="#FAFAE7" />  
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />  
        <SortedDescendingCellStyle BackColor="#E1DB9C" />  
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />  
    </asp:GridView>  
            </td>  
              
        </tr>  
    </table>  
     
</asp:Content>
