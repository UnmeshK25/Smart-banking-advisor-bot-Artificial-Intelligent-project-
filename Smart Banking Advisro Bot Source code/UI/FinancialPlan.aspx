<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinancialPlan.aspx.cs" Inherits="Banking_Advisor_bot.FinancialPlan" %>
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
        .style7
        {
            height: 45px;
            color: #0066CC;
            text-align: left;
        }
        .style8
        {
            height: 45px;
            color: #0066CC;
            text-align: center;
        }
        .style9
        {
            height: 45px;
            color: #0066CC;
            width: 256px;
            text-align: center;
        }
        .style10
        {
            width: 237px;
            text-align: center;
            height: 26px;
        }
        .style11
        {
            width: 225px;
            text-align: center;
            height: 26px;
        }
        .style12
        {
            color: #0066CC;
            width: 256px;
            text-align: center;
        }
        .style13
        {
            color: #0066CC;
            text-align: left;
        }
        .style14
        {
            width: 436px;
            text-align: center;
            height: 30px;
        }
        .style15
        {
            height: 30px;
            color: #0066CC;
            width: 256px;
            text-align: center;
        }
        .style16
        {
            height: 30px;
            color: #0066CC;
            text-align: left;
        }
        .style17
        {
            width: 436px;
            text-align: center;
            height: 38px;
        }
        .auto-style1 {
            height: 30px;
            color: #0066CC;
            text-align: left;
            width: 214px;
        }
        .auto-style2 {
            height: 30px;
            color: #0066CC;
            text-align: left;
            width: 185px;
        }
    </style>
</head>
<body>
    
   
     <table style="padding: 70px; width:90%; height: 567px; margin-left: 1px; margin-top: 41px; margin-right: 168px; color: #000066; background-color: #666633;">
                <tr>
                    <td style="color: #0033CC" class="style1" colspan="2">
                        <h3 class="style2"><strong style="color: #000066"> Income Details</strong></h3></td>
                    <td  colspan="2">
                       <h3 class="style2"> <strong style="color: #000066">Expenses Details</strong></h3></td>
                </tr>
                <tr>
                    
                    <td class="style15" style="color: #000066">
                        Saving/Checkin Account balance</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Txtsaving" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                       
                    </td>
                    
                    <td class="style15" style="color: #000066">
                        House rent (monthly)</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Txthouserent" runat="server" MaxLength="15" TextMode="Number" Width="128px" BackColor="#999966"></asp:TextBox>
                        <br />
                      
                    </td>
                </tr>
                <tr>
                      <td class="style15" style="color: #000066">
                          Job/Business income (monthly)</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Txtjob" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                      
                    </td>
                      <td class="style15" style="color: #000066">
                        Utilities (internet, water, electricity etc.)</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Txtutility" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                       
                    </td>
                </tr>
                <tr>
                    <td class="style15" style="color: #000066">
                        Income from Rent (monthly)</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Txtrent" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                       
                    </td>
                      <td class="style15" style="color: #000066">
                        Education expense (monthly)</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Txteducation" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                      
                    </td>
                </tr>
                <tr>
                    <td class="style15" style="color: #000066">
                        Retirement Pension (monthly)</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Txtpension" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                      
                    </td>
                      <td class="style15" style="color: #000066">
                        Health expense</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Txthealth" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                       
                    </td>
                    
                </tr>
                <tr>
                    <td class="style15" style="color: #000066">
                        Social Security income (monthly)</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Txtsocial" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                      
                    </td>
                      <td class="style15" style="color: #000066">
                        Shopping expense </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Txtshopping" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                        
                    </td>
                    
                </tr>
                <tr>
                    <td class="style15" style="color: #000066">
                        Income from Other sources</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Txtother" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                       
                    </td>
                      <td class="style15" style="color: #000066">
                        Transport/Traveling expense </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Txttravel" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                       
                    </td>
                </tr>
                <tr>
                     
                    
                      <td class="style1" colspan="2">
                          &nbsp;</td>
                    
                      <td class="style15" style="color: #000066">
                        Entertainment expense</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Txtenter" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                       >--%>
                    </td>
                </tr>
                <tr>
                    <td class="style1" colspan="2">
                        &nbsp;</td>
                    
                      <td class="style15" style="color: #000066">
                        Outside eating (Hotel/Restaurants) expense</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Txthotel" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                       
                    </td>
                </tr>
                <tr>
                    <td class="style1" colspan="2">
                        &nbsp;</td>
                    
                      <td class="style15" style="color: #000066">
                        Loan or other EMI (monthly)</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TxtEMI" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                      
                    </td>
                </tr>
         <tr>
                    <td class="style1" colspan="2">
                        &nbsp;</td>
                    
                      <td class="style15" style="color: #000066">
                        Other Expense</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Txtotherexp" runat="server" MaxLength="15" TextMode="Number" BackColor="#999966"></asp:TextBox>
                        <br />
                       
                    </td>
                </tr>
          <tr>
                   <td colspan="2">
                        <asp:Button ID="SubmitIncome" class="button_example" runat="server" Text="Submit"
                            onclick="SubmitIncome_Click"  Height="38px" /></td>
             
                    
                     <td colspan="2">
                        
                        <asp:Button ID="UpdateExpense" class="button_example" runat="server" Text="Update"
                            onclick="UpdateExpense_Click"  Height="38px" />
                        
                        <asp:Button ID="Cancel" class="button_example" runat="server" Text="Cancel Update"
                            onclick="CancleUpdate_Click"  Height="38px" />
                     </td>
                </tr>
            </table>
    
       
</body>
</html>
</asp:Content>
