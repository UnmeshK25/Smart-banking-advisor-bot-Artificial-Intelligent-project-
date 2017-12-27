<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Banking_Advisor_bot.Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
    <!DOCTYPE html>

<html>
<head >
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
            height: 82px;
        }
        .auto-style2 {
            width: 201px;
            text-align: center;
            height: 71px;
        }
        .auto-style3 {
            height: 71px;
        }
        .auto-style5 {
            height: 82px;
            width: 201px;
        }
        .auto-style6 {
            width: 201px;
            text-align: center;
            height: 76px;
        }
        .auto-style7 {
            height: 76px;
        }
    </style>
</head>
<body>
    
        <div class="page">
      
            <div style="height: 481px; margin-right: 0px;">
     <table style="border-style: double; border-width: medium; width:60%; position: fixed; background-color: #993333; top: 131px; left: 109px; height: 319px; margin-right: 0px;">
                <tr>
                    <td style="border-style: groove; border-width: medium;" class="auto-style6" colspan="2">
                        <h4 class="style2" style="color: #000066"> For first time user</h4></td>
                    <td  colspan="2" class="auto-style7" style="border-style: groove; border-width: medium">
                       <h4 class="style2" style="color: #000066"> Already existing users (Note: Update financial information before getting financial plan or financial decision help)</h4></td>
                </tr>
          <tr>
                   
             <td colspan="2" class="auto-style5" style="border-style: groove; border-width: medium">
                        <asp:Button ID="Enterfinancial" class="button_example" runat="server" Text="Enter Financial Information"
                            onclick="SubmitFinancial_Click"  Height="38px" Width="176px" /></td>
                    
                     <td colspan="2" class="auto-style1" style="border-style: groove; border-width: medium">
                        <asp:Button ID="UpdateFinancialInfo" class="button_example" runat="server" Text="Update Financial Info"
                            onclick="UpdateFinancialInfo_Click"  Height="38px" Width="174px" /></td>
                </tr>
         <tr>
             <td class="auto-style2" colspan="2">
                        &nbsp;</td>
                     <td class="auto-style3" style="border-style: groove; border-width: medium">
                        <asp:Button ID="viewFinancialPlan" class="button_example" runat="server" Text="Get Financial Plan"
                            onclick="ViewPlan_Click"  Height="38px" />
                     </td>
             <td class="auto-style3" style="border-style: groove; border-width: medium">
                        <asp:Button ID="financialPlanPriority" class="button_example" runat="server" Text="Priority based financial plan"
                            onclick="FinancialPriorityPlan_Click"  Height="36px" Width="185px" />
                     </td>
             </tr>
         <tr>
             <td class="auto-style2" colspan="2">
                        &nbsp;</td>
                     <td class="auto-style3" style="border-style: groove; border-width: medium">
                        <asp:Button ID="Button2" class="button_example" runat="server" Text="Get Financial Decision Help"
                            onclick="FinancialDecisionHelp_Click"  Height="35px" Width="193px" />
                     </td>
             <td class="auto-style3">
                        &nbsp;</td>
             </tr>
         <tr>
             <td class="auto-style2" colspan="2">
                        &nbsp;</td>
             <td style="border-style: groove; border-width: medium">
                        <asp:DropDownList ID="ReportTypeDDL" runat="server">
                            <asp:ListItem Text="Select Report type" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Income Report" Value="Income"></asp:ListItem>
                            <asp:ListItem Text="Expense Report" Value="Expense"></asp:ListItem>
                            <asp:ListItem Text="Expense comparision report" Value="Compare"></asp:ListItem>
                        </asp:DropDownList>
                        </td><td style="border-style: groove; border-width: medium">
                        <asp:Button ID="ExpenseReport" class="button_example" runat="server" Text="Get Report"
                            onclick="ExpenseReport_Click"  Height="38px" Width="177px" />
                     </td>
             </tr>
    </table>
    </div>
    </div>
   
</body>
</html>
    </asp:Content>
