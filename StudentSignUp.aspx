<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentSignUp.aspx.cs" Inherits="WebApplication2.StudentSignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            
            background-image:url(https://wallpapercave.com/wp/wp2763918.gif);
        }
        table.centertable{
            margin-left: 30%;
            margin-top:1%;
            border:6px solid grey;
            background-color:white;
        }
        .auto-style1 {
            height:33px;
        }
    </style>
</head>
<body>
    <br />
    <br />
    <h1 style="margin-left:33% ;color:darkblue;font-size:60px;">Sign Up</h1>
    <form id="form1" runat="server">
    <div>
    <table class="centertable">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label></td>
            <td class="auto-style1">
                <asp:TextBox ID="txtUserName2" runat="server" AutoPostBack="true" OnTextChanged="txtUserName2_TextChanged"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label></td>
            <td class="auto-style1">
                <asp:TextBox ID="FName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Last Name" ></asp:Label></td>
            <td>
                <asp:TextBox ID="LName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" Text="CNIC"></asp:Label></td>
            <td class="auto-style1">
                <asp:TextBox ID="cnic" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Date Of Birth" ></asp:Label></td>
            <td>
                <asp:TextBox ID="dob" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label7" runat="server" Text="Phone Number"></asp:Label></td>
            <td class="auto-style1">
                <asp:TextBox ID="PhoneNo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Address" ></asp:Label></td>
            <td>
                <asp:TextBox ID="Address" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Batch" ></asp:Label></td>
            <td>
                <asp:TextBox ID="batch" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
               
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Up" />
            </td>
        </tr>

        <tr>
            <td></td>
            <td>
                 <asp:Label ID="lblError2" runat="server" Text="Failure." ForeColor="Maroon"></asp:Label>
            </td>
           
        </tr>

    </table>
    </div>
    </form>
</body>
</html>
