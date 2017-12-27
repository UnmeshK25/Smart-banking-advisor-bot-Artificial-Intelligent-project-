<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="Banking_Advisor_bot.UserRegister" %>
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
            height: 24px;
            color: #0066CC;
            width: 256px;
            text-align: center;
        }
        .auto-style2 {
            height: 24px;
            color: #0066CC;
            text-align: left;
        }
        </style>
</head>
<body>
    
   <div class="page">
      
            <table style="color: #000066; background-color: #C0C0C0; table-layout: auto; width: 598px; empty-cells: hide; height: 354px; margin-left: 92px;">
              <tr>
                  
                    
                      <td class="style9" style="color: #000066">
                        Name:</td>
                    <td class="style7">
                        <asp:TextBox ID="Txtname" runat="server" BackColor="Silver" ></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                            ControlToValidate="Txtname" Display="Dynamic"
                            ErrorMessage="Please enter name" ForeColor="Red"
                            ValidationGroup="signUp"></asp:RequiredFieldValidator>
                    </td></tr>
                <tr>
                <td class="style15" style="color: #000066">
                        Address</td><td>
                    <asp:TextBox ID="Txtaddress" runat="server" BackColor="Silver" ></asp:TextBox>
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                            ControlToValidate="Txtaddress" Display="Dynamic"
                            ErrorMessage="Please enter address" ForeColor="Red"
                            ValidationGroup="signUp"></asp:RequiredFieldValidator></td></tr><tr>
                <td class="auto-style1" style="color: #000066">
                        Email Id</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="eMail" runat="server" BackColor="Silver"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                            ControlToValidate="eMail" Display="Dynamic"
                            ErrorMessage="Please Enter the Email" ForeColor="Red" ValidationGroup="signUp"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="eMail" Display="Dynamic"
                            ErrorMessage="Enter the Valid Email Id" ForeColor="Red"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            ValidationGroup="signUp"></asp:RegularExpressionValidator></td></tr><tr>
                <td class="style15" style="color: #000066">
                        Contact number</td>
                    <td class="style16">
                        <asp:TextBox ID="Txtcontact" runat="server" BackColor="Silver" ></asp:TextBox>
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="Txtcontact"  
                            Display="Dynamic"
                            ErrorMessage="Please enter contact number" ForeColor="Red" ValidationExpression="[0-9]{10}" 
                            ValidationGroup="signUp"></asp:RequiredFieldValidator></td></tr><tr>
                <td class="style15" style="color: #000066">
                        Enter new password</td>
                    <td class="style16">
                        <asp:TextBox ID="Password" runat="server" MaxLength="8" TextMode="Password" BackColor="Silver"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                            ControlToValidate="Password" Display="Dynamic"
                            ErrorMessage="Please Enter the Password" ForeColor="Red"
                            ValidationGroup="signUp"></asp:RequiredFieldValidator>
                    </td></tr>
                   
                    
                <tr>
                    
                    <td class="style8" colspan="2">
                        <asp:Button ID="Button1" class="button_example" runat="server" Text="Sign Up"
                            onclick="Button1_Click" ValidationGroup="signUp" BackColor="Silver"
                            />
                    </td>

                </tr>
                
            </table>
       </div>
</body>
</html>
    </asp:Content>
