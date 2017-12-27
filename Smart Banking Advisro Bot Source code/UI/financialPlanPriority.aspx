<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="financialPlanPriority.aspx.cs" Inherits="Banking_Advisor_bot.financialPlanPriority" %>
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
        </style>
 </head>
    <body>
       
    <div>
        <fieldset>
            <h4 style="color: #000066; background-color: #808080;">User's input for expenses priority</h4>
                <table style="width:58%; background-color: #999999; height: 147px; margin-left: 167px; margin-top: 29px;">
                <tr>
                    <td class="style15" style="color: #000066">
                        First Expense Priority:  </td><td>
            <asp:DropDownList ID="ddlFirstPriority" runat="server" Width="200px" BackColor="Silver">
                <asp:ListItem Text="Select Expense pririty" Value="0"></asp:ListItem>
                <asp:ListItem Text="Household" Value="Household"></asp:ListItem>
                <asp:ListItem Text="Health" Value="Health"></asp:ListItem>
                <asp:ListItem Text="Education" Value="Education"></asp:ListItem>
                <asp:ListItem Text="Travel" Value="Education"></asp:ListItem>
                <asp:ListItem Text="Lifestyle" Value="Education"></asp:ListItem>
               
            </asp:DropDownList>
            </td>
                      <tr>
                    <td class="style15" style="color: #000066">
                        Second Expense Priority:  </td><td>
            <asp:DropDownList ID="ddlSecondPriority" runat="server" Width="200px" BackColor="Silver">
                <asp:ListItem Text="Select Expense pririty(different than 1st priority)" Value="0"></asp:ListItem>
               
                <asp:ListItem Text="Household" Value="Household"></asp:ListItem>
                <asp:ListItem Text="Health" Value="Health"></asp:ListItem>
                <asp:ListItem Text="Education" Value="Education"></asp:ListItem>
                <asp:ListItem Text="Travel" Value="Education"></asp:ListItem>
                <asp:ListItem Text="Lifestyle" Value="Education"></asp:ListItem>
             
            </asp:DropDownList>
            </td>
                    </tr>
                 <tr>
                   <td colspan="2">
                        <asp:Button ID="FinancialPlanPriority" class="button_example" runat="server" Text="Get Priority based financial plan"
                            onclick="SubmitInput_Click"  Height="38px" BackColor="Silver" /></td>
             
                    
                </tr>           
            </table>
            
            <div style="height: 295px">
    </div>
            </fieldset>
    </div>
    
</body>
</html>
</asp:Content>
