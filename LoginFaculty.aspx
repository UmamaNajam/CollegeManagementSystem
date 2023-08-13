<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginFaculty.aspx.cs" Inherits="WebApplication2.LoginFaculty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
  

    <h1 style="text-align:center;color:white;font-size:60px; border-bottom:solid white; border-top:solid white">Welcome Faculty Member</h1>
    <form id="form1" runat="server">
        <br />
        <br />

        <p style="text-align:center;color:darkblue;font-size:20px;font-family:Arial; background-color:white" >Enter your credentials to login or Sign up to create a new account</p>
     <br />
        <div>
    <table class="centertable">
        <tr class="auto-style1">
            <td class="auto-style1" >
                <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label></td>
            <td class="auto-style1">
                <asp:TextBox ID="txtUserName2" runat="server"></asp:TextBox></td>
        </tr>
        <tr class="auto-style1">
            <td class="auto-style1" >
                <asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr class="auto-style1">
            <td></td>
            <td>
                <asp:Button ID="btnLogin2" runat="server" Text="Login" OnClick="btnLogin_Click2" />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Up" />
            </td>
        </tr>

        <tr >
            <td></td>
            <td>
               <asp:Label ID="lblError2" runat="server" Text="Oops! Incorrect Credentials." ForeColor="Maroon"></asp:Label>
                 
            </td>
           
        </tr>

    </table>
    </div>
        <br />
        
            
            
           </form>
</body>
</html>

