<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinanceReport.aspx.cs" Inherits="Banking_Advisor_bot.FinanceReport" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #CCCCCC; color: #000066">
        
       
       
        <strong><span class="auto-style1">Report of Last month&#39;s Expenses</span></strong></div>
        <div>  
        <script type="text/javascript" src="https://www.google.com/jsapi"></script>  
        <br />  
        <asp:GridView ID="gvData" runat="server">
            <AlternatingRowStyle BackColor="#336699" />
            <RowStyle BackColor="#99CCFF" />
        </asp:GridView>  
        <br />  
          
    </div>  
        <div>
        <asp:Chart ID="Chart1" runat="server" Width="724px" Height="313px">
            <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisY Title="Expenses Amount">
                    </AxisY>
                    <AxisX Title="Expenses">
                    </AxisX>
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
            <asp:Chart ID="Chart2" runat="server" Height="427px" Width="577px">
                <series>
                    <asp:Series ChartType="Pie" CustomProperties="PieLabelStyle=Outside" IsValueShownAsLabel="True" Legend="Legend1" Name="Series1" YValueType="Double">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                        <Area3DStyle Enable3D="True" />
                    </asp:ChartArea>
                </chartareas>
                <Legends>
                    <asp:Legend Name="Legend1">
                    </asp:Legend>
                </Legends>
            </asp:Chart>
        </div>
    </form>
</body>
</html>
