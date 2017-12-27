<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="financialDecisionHelp.aspx.cs" Inherits="Banking_Advisor_bot.financialDecisionHelp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>

<html>
<head>
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 436px;
            text-align: center;
            height: 45px;
        }
        .style2
        {
            color: #0066CC;
            text-align: center;
        }

        .style15
        {
            height: 30px;
            color: #0066CC;
            width: 256px;
            text-align: center;
            
        }
         .style14
        {
            height: 30px;
            color: #0066CC;
            width: 256px;
            text-align: center;
            text-decoration-style:solid;
        }
        .style16
        {
            height: 30px;
            color: #0066CC;
            text-align: left;
        }

        .auto-style1 {
            height: 217px;
        width: 228px;
    }
        .auto-style2 {
            height: 18px;
            color: #0066CC;
            width: 228px;
            text-align: left;
        }
        .auto-style3 {
            height: 18px;
            color: #0066CC;
            text-align: left;
            width: 256px;
        }
        .auto-style4 {
            height: 30px;
            color: #0066CC;
            text-align: left;
            width: 256px;
        }
        .auto-style5 {
            height: 41px;
        }

        .auto-style6 {
        height: 30px;
        color: #0066CC;
        width: 228px;
        text-align: center;
    }
    .auto-style7 {
        width: 228px;
    }
    .auto-style8 {
        height: 30px;
        color: #0066CC;
        width: 228px;
        text-align: justify;
    }
    .auto-style9 {
        height: 30px;
        color: #0066CC;
        width: 228px;
        text-align: left;
    }

        </style>
     
 </head>
    <body>
       
    <table style="width:91%;">  
        <caption class="style3" style="font-size: large; font-weight: bold; border: medium double #000000; color: #993300;">  
            <strong>Financial Plan</strong></caption>  
        <tr>  
              
            <td class="auto-style1" >  
      
    <asp:GridView ID="FinancialDataGrid" runat="server"   
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px"   
        CellPadding="2" ForeColor="Black" GridLines="None" >  
        <AlternatingRowStyle BackColor="PaleGoldenrod" />  
         
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
            <td class="auto-style8" style="border-style: double; border-width: medium; background-color: #FFFFFF; color: #000066;">
                        <ul>
                            <li>According to Ideal Expenses percntages, you may save percentage of total income equal to:  </li>
                        </ul>
                    </td>
                          <td class="style14" style="border-style: double; border-width: medium; background-color: #FFFFFF; color: #000066;">
                        34 % </td>
                    </tr>
                     <tr>
            <td class="auto-style6" style="border-style: double; border-width: medium; background-color: #FFFFFF; ">
                        <ul>
                            <li style="width: 227px; color: #000066;">You set target loan period(months):  </li>
                        </ul>
                         </td>
                         <td class="auto-style4" style="border-style: double; border-width: medium; background-color: #FFFFFF">
                        <asp:TextBox ID="loanPeriod" runat="server" MaxLength="15" TextMode="Number" BackColor="White" ></asp:TextBox>
                        <br /></td>
                    </tr>
        <tr>
            <td class="auto-style6" style="border-style: double; border-width: medium; background-color: #FFFFFF">
                        <ul>
                            <li class="text-left" style="color: #000066">Total loan amount with interest that you need to pay at the end of target period:  </li>
                        </ul>
            </td>
                         <td class="auto-style4" style="border-style: double; border-width: medium; background-color: #FFFFFF">
                        <asp:TextBox ID="totalLoanAmount" runat="server" MaxLength="15" TextMode="Number" BackColor="White" ></asp:TextBox>
                        <br /></td>
                    </tr>
        <tr>
            <td class="auto-style9" style="border-style: double; border-width: medium; background-color: #FFFFFF">
                        <ul>
                            <li style="color: #000066">Loan EMI per month that you need to pay:  </li>
                        </ul>
            </td>
                         <td class="auto-style4" style="border-style: double; border-width: medium; background-color: #FFFFFF">
                        <asp:TextBox ID="loanEMI" runat="server" MaxLength="15" TextMode="Number" BackColor="White" ></asp:TextBox>
                        <br /></td>
                    </tr>
        <tr>
            <td class="auto-style9" style="border-style: double; border-width: medium; background-color: #FFFFFF">
                        <ul>
                            <li style="color: #000066">The additional percentage of total income you need to save to complete loan target:  </li>
                        </ul>
            </td>
                         <td class="auto-style4" style="border-style: double; border-width: medium; background-color: #FFFFFF">
                        <asp:TextBox ID="AddSavingper" runat="server" MaxLength="15" TextMode="Number" BackColor="White" ></asp:TextBox>
                        <br /></td>
                    </tr>
        <tr>
            <td class="auto-style2" style="border-style: double; border-width: medium; background-color: #FFFFFF; ">
                        <ul>
                            <li style="color: #000066">The additional amount of total income you need to save to complete loan target:  </li>
                        </ul>
            </td>
                         <td class="auto-style3" style="border-style: double; border-width: medium; background-color: #FFFFFF">
                        <asp:TextBox ID="AddSaveAmount" runat="server" MaxLength="15" TextMode="Number" BackColor="White" ></asp:TextBox>
                        <br /></td>
                    </tr>
           <tr>
            <td  colspan="2" class="auto-style5" style="background-color: #FFFFFF; color: #000066">
                        To pay the total loan amount in target period, you may follow following smart financial plan:  </td>
                        
                         
                    </tr>
        <tr>  
              
            <td class="auto-style7" >  
      
    <asp:GridView ID="GridFinancialPlanResult" runat="server"   
        BackColor="#33CCFF" BorderColor="Tan" BorderWidth="1px"   
        CellPadding="2" ForeColor="Black" GridLines="None" Caption="Smart Financial Plan" >  
        <AlternatingRowStyle BackColor="#CCCCFF" />  
         
        <FooterStyle BackColor="Tan" />  
        <HeaderStyle BackColor="#9900FF" Font-Bold="True" BorderStyle="Solid" BorderWidth="2px" />  
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue"   
            HorizontalAlign="Center" />  
        <RowStyle BackColor="#CCCCFF" BorderStyle="Solid" BorderWidth="2px" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />  
        <SortedAscendingCellStyle BackColor="#FAFAE7" />  
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />  
        <SortedDescendingCellStyle BackColor="#E1DB9C" />  
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />  
    </asp:GridView>  
            </td>  
            
        </tr>  
    </table>  
            
        </body>
    </html>
</asp:Content>
