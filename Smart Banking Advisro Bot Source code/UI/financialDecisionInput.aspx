<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="financialDecisionInput.aspx.cs" Inherits="Banking_Advisor_bot.financialDecisionInput" %>
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
        .style16
        {
            height: 30px;
            color: #0066CC;
            text-align: left;
        }
        .auto-style1 {
            height: 47px;
            color: #0066CC;
            width: 256px;
            text-align: center;
        }
        .auto-style4 {
            height: 47px;
        }
        .auto-style5 {
            height: 52px;
            color: #0066CC;
            width: 256px;
            text-align: center;
        }
        .auto-style6 {
            height: 52px;
            color: #0066CC;
            text-align: left;
        }
        .auto-style7 {
            height: 50px;
            color: #0066CC;
            width: 256px;
            text-align: center;
        }
        .auto-style8 {
            height: 50px;
            color: #0066CC;
            text-align: left;
        }
        .auto-style10 {
            height: 50px;
        }
        .auto-style11 {
            height: 61px;
            color: #0066CC;
            width: 256px;
            text-align: center;
        }
        .auto-style12 {
            height: 61px;
            color: #0066CC;
            text-align: left;
        }
        </style>
 </head>
    <body>
       
    <div>
        <fieldset>
            <h4 style="color: #000066; background-color: #808080;">User's input for loan type and loan amount</h4>
                <table style="width:58%; background-color: #999999; height: 351px; margin-left: 167px; margin-top: 29px;">
                <tr>
                    <td class="auto-style1" style="color: #000066">
                        Loan Type:  </td><td class="auto-style4">
            <asp:DropDownList ID="ddlLoan" runat="server" Width="200px" BackColor="Silver" AutoPostBack="true"
onselectedindexchanged="ddlLoanType_SelectedIndexChanged">
                <asp:ListItem Text="Select Loan Type" Value="0"></asp:ListItem>
                <asp:ListItem Text="Home Loan" Value="Household"></asp:ListItem>
                <asp:ListItem Text="Car Loan" Value="Health"></asp:ListItem>
                <asp:ListItem Text="Education Loan" Value="Education"></asp:ListItem>
                <asp:ListItem Text="Personal Loan" Value="Personal"></asp:ListItem>
               
            </asp:DropDownList>
            </td>
                    </tr>
                     <tr>
            <td class="auto-style5" style="color: #000066">
                        Loan Amount:  </td>
                         <td class="auto-style6">
                        <asp:TextBox ID="loanAmount" runat="server" MaxLength="15" TextMode="Number" BackColor="Silver"></asp:TextBox>
                        <br /></td>
                    </tr>
                     <tr>
            <td class="auto-style7" style="color: #000066">
                        Target loan period(months):  </td>
                         <td class="auto-style8">
                        <asp:TextBox ID="loanPeriod" runat="server" MaxLength="15" TextMode="Number" BackColor="Silver"></asp:TextBox>
                        <br /></td>
                    </tr>
                    <tr>
                    <td class="auto-style7" style="color: #000066">
                        Bank name:  </td><td class="auto-style10">
            <asp:DropDownList ID="ddlBankname" runat="server" Width="200px" BackColor="Silver" >
                
            </asp:DropDownList>
            </td>
                    </tr>
                    <tr>
            <td class="auto-style11" style="color: #000066">
                        Interest Rate:  </td>
                         <td class="auto-style12">
                        <asp:TextBox ID="TxtInterest" runat="server" MaxLength="15" TextMode="Number" BackColor="Silver"></asp:TextBox>
                        <br /></td>
                    </tr>
                 <tr>
                      
                   <td colspan="2">
                        <asp:Button ID="FinancialDecision" class="button_example" runat="server" Text="Get Financial Decision Help"
                            onclick="SubmitInput_Click"  Height="38px" BackColor="Silver" /></td>
                     
             
                    
                </tr>           
            </table>
            
            <div style="height: 420px">
    </div>
            </fieldset>
    </div>
    
</body>
</html>
</asp:Content>
