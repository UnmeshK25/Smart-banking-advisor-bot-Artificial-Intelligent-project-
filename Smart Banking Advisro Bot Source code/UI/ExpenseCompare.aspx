<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExpenseCompare.aspx.cs" Inherits="Banking_Advisor_bot.ExpenseCompare" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 141px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="color: #000066; border-style: double; border-width: medium; caption-side: top;">
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
            <td class="auto-style1"> Travel :</td>
            <td> Transportation, traveling expenses </td>
            </tr>
        <tr>
            <td class="auto-style1"> Lifestyle :</td>
            <td> Entertainment, outside eating expenses, other EMI, other expenses </td>
            </tr>
        </table>
    </div>
        
        <div>  
        <script type="text/javascript" src="https://www.google.com/jsapi"></script>  
        <asp:GridView ID="gvData" runat="server">
            <AlternatingRowStyle BackColor="#336699" />
            <RowStyle BackColor="#99CCFF" />
        </asp:GridView>  
          
    
        <asp:Chart ID="Chart1" runat="server" Width="937px" Height="321px" style="margin-left: 276px">
            <series>
                <asp:Series Name="Last month expences amount" IsValueShownAsLabel="True" Legend="Legend1">
                </asp:Series>
                <asp:Series ChartArea="ChartArea1" IsValueShownAsLabel="True" Legend="Legend1" Name="Ideal expenses amount">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisY Title="Expense Amount">
                    </AxisY>
                    <AxisX Title="Expenses Types">
                    </AxisX>
                </asp:ChartArea>
            </chartareas>
            <Legends>
                <asp:Legend Name="Legend1">
                </asp:Legend>
            </Legends>
        </asp:Chart>       
        <br />  
        <br />  
          
    
        </div>
         <div>  
        
          
    
        <asp:Chart ID="Chart2" runat="server" Width="936px" Height="252px" style="margin-left: 276px">
            <series>
                <asp:Series Name="Last month expenses percentages" IsValueShownAsLabel="True" Legend="Legend1">
                </asp:Series>
                <asp:Series ChartArea="ChartArea1" IsValueShownAsLabel="True" Legend="Legend1" Name="Ideal expenses percentages">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisY Title="Expense percentages">
                    </AxisY>
                    <AxisX Title="Expense Types">
                    </AxisX>
                </asp:ChartArea>
            </chartareas>
            <Legends>
                <asp:Legend Name="Legend1">
                </asp:Legend>
            </Legends>
            <Titles>
                <asp:Title Name="Comparision of Expense Types percentages between actual expences percentages and Ideal expences percentage">
                </asp:Title>
            </Titles>
        </asp:Chart>       
        <br />  
        <br />  
          
    
        </div>
    </form>
</body>
</html>
