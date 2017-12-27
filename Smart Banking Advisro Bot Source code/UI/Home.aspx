<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Banking_Advisor_bot.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
    <!DOCTYPE html>

<html>
<head>
    <title></title>
    <meta charset="utf-8"/>
   <meta name="viewport" content="width=device-width, initial-scale=1">
 
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>

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
        .clear {
            margin-top: 0px;
        }
        .page {
            height: 387px;
        }
    </style>
</head>
<body>
    <%--<form id="Form1" runat="server">--%>
    <div class="page" >
      
        
         
        
           
            
            <table style="width:40%; background-color: #C0C0C0; position: fixed; top: 125px; left: 180px; height: 171px;">
                <tr>
                    <td style="color: #0033CC" class="style1" colspan="2">
                        <h4 class="style2" style="color: #000066">Existing User's Login</h4></td>
                </tr>
                    <tr>
            <td class="style15" style="color: #000066">
                        Username:  </td>
                         <td class="col-sm-4">
                        <asp:TextBox ID="UserName"  runat="server" 
                            MaxLength="20" ForeColor="#707070"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="rfvUser" runat="server" ControlToValidate="UserName" ErrorMessage="Please enter Username"  ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpValid" runat="server" ControlToValidate="UserName"
                                        ErrorMessage="Invalid Username."     
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"
                                            Display="Dynamic">
                                    </asp:RegularExpressionValidator>
                        <br /> <tr>
                                <td class="style15" style="color: #000066">
                        Password:  </td><td class="col-sm-4">
                        <asp:TextBox ID="PassLog" runat="server" 
                             ForeColor="#707070"
                            MaxLength="10" TextMode="Password"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="PassLog" ErrorMessage="Please enter Password"  ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td> 
                    
                </tr>
                
                <tr>
                    <td class="style17" colspan="2">
                        <asp:Button ID="Login" class="button_example" runat="server" Text="Login"
                            onclick="Login_Click" ValidationGroup="login_gr" Height="38px" BackColor="Gray" ForeColor="#000066" />
                    </td>
                  
                    
                </tr>
             
                
            
            </table>
        </div>
   
    

</body>
</html>
    </asp:Content>
