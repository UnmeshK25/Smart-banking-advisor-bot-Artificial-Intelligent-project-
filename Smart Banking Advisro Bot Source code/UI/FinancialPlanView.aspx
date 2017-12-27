<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinancialPlanView.aspx.cs" Inherits="Banking_Advisor_bot.FinancialPlanView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div>
    <table style="color: #000066; border-style: double; border-width: medium; caption-side: top; background-color: #C0C0C0; height: 151px; width: 679px; margin-left: 38px;">
        <tr>
            <td class="auto-style1"> <strong>Expense Type</strong></td>
            <td style="position: absolute"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;Expenses</strong> </td>
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
    <table style="width:93%; height: 508px; margin-left: 34px;">  
        <caption class="style3" style="color: #000066; background-color: #999966; width: 289px;">  
            <strong>Financial Information</strong></caption>  
        <tr>  
              
            <td style="height: 224px; width: 242px;" >  
      
    <asp:GridView ID="FinancialDataGrid" runat="server"   
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px"   
        CellPadding="2" ForeColor="Black" GridLines="None" Width="421px" >  
        <AlternatingRowStyle BackColor="#FFFFCC" />  
         
        <FooterStyle BackColor="Tan" />  
        <HeaderStyle BackColor="Tan" Font-Bold="True" Width="60px" />  
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
            <td class="auto-style1" style="border-style: double; width: 242px; background-color: #FFFFFF; color: #000066; font-family: Arial; font-size: large; height: 59px;"> <strong>Columns in /financial Plan :</strong></td>
            <td style="border-style: double; color: #000066; background-color: #FFFFFF; font-family: Arial; font-size: large; height: 59px;"> <strong>Explanation </strong> </td>
            </tr>    
           <tr>
            <td class="auto-style1" style="border-style: double; width: 242px; background-color: #FFFFFF; color: #000066;"> Percentage of Income :</td>
            <td style="border-style: double; color: #000066; background-color: #FFFFFF"> Percentage of total income can save for next month for expense type according to smart financial plan </td>
            </tr>
         <tr>
            <td class="auto-style1" style="border-style: double; width: 242px; color: #000066; background-color: #FFFFFF;"> Amount of total Income :</td>
            <td style="border-style: double; color: #000066; background-color: #FFFFFF"> Amount of total income can save for next month for expense type according to smart financial plan </td>
            </tr>
        <tr>
            <td class="auto-style1" style="border-style: double; width: 242px; background-color: #FFFFFF; color: #000066; height: 40px;"> Possible Saving Percentage :</td>
            <td style="border-style: double; color: #000066; background-color: #FFFFFF; height: 40px;"> This is percentage of total income that can save after all other saving target for other expense types fulfilled  </td>
            </tr>
        <tr>
            <td class="auto-style1" style="border-style: double; height: 20px; width: 242px; color: #000066; background-color: #FFFFFF;"> Possible Saving Amount :</td>
            <td style="border-style: double; height: 20px; color: #000066; background-color: #FFFFFF;"> This is amount of total income that can save after all other saving target for other expense types fulfilled  </td>
            </tr>
        <tr>
            <td class="auto-style1" style="border-style: double; width: 242px; background-color: #FFFFFF; color: #000066; height: 40px;"> Lifestyle :</td>
            <td style="border-style: double; color: #000066; background-color: #FFFFFF; height: 40px;"> Entertainment, outside eating expenses, other EMI, other expenses </td>
            </tr>
        <tr>  
              
            <td title="Smart Financial Plan" style="width: 242px" >  
      
    <asp:GridView ID="GridFinancialPlanResult" runat="server"   
        BackColor="#33CCFF" BorderColor="Tan" BorderWidth="1px"   
        CellPadding="2" ForeColor="Black" GridLines="None" CaptionAlign="Top" Width="415px" >  
        <AlternatingRowStyle BackColor="#CCCCFF" />  
         
        <FooterStyle BackColor="Tan" />  
        <HeaderStyle BackColor="#CC66FF" Font-Bold="True" Width="60px" />  
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
