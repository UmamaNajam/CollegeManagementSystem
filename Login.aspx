<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            
            background-image:url(https://cdn.dribbble.com/users/3869062/screenshots/10285533/media/abbbe65fc368250a9bd8a67ee47bf22b.gif);
            background-size:1200px 900px;
            background-position:1500px top;
        
        }
        table.centertable{
            margin-left: 8%;
           
            border:6px solid grey;
            background-color:white;
            height:30%
        }
        .auto-style1 {
            height:33px;
            
            
        }
    </style>

</head>
<body>
    <h1 style="text-align:center;color:white;font-size:60px;border-bottom:solid white; border-top:solid white">Welcome Student</h1>
    <br />
        <br />

        <p style="text-align:center;color:white;font-size:20px; font-family:Arial; background-color:cadetblue" >Enter your credentials to login or Sign up to create a new account</p>
     <br />
    <form id="form1" runat="server">
    <div>
    <table class="centertable">
        <tr class="auto-style1">
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label></td>
            <td class="auto-style1">
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
        <tr class="auto-style1">
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr class="auto-style1">
            <td></td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                 <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Up" />
            </td>
        </tr>

        <tr >
            <td></td>
            <td>
               <asp:Label ID="lblError" runat="server" Text="Oops! Incorrect Credentials." ForeColor="Maroon"></asp:Label>
            </td>
        </tr>

    </table>
    </div>
        
    </form>
</body>
</html>
