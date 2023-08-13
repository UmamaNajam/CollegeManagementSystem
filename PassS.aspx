<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PassS.aspx.cs" Inherits="WebApplication2.PassS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
<style>
    body.dashboard {
            background-color: lightgrey;
            color: black;
            font-family: Arial;
            font-size: medium;
        }
            .auto-style1 {
            height: 33px;
            border: 0.5px solid grey;
            border-radius: 2px;
            padding: 4px;
        }

        .auto-style2 {
            margin-left: auto;
            margin-right: auto;
            margin-top: 2px;
            margin-bottom: 2px;
        }

        .auto-style3 {
            background-color: #5B6098;
            color: white;
            font-style: italic;
            font-size: larger;
            text-align: center;
        }


</style>
</head>
<body class="dashboard">
            <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Update Password for <%=HttpContext.Current.Session["username"]%></h1>
    <form id="form1" runat="server">
    <div>
       <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>New Password</td>
                </tr>
            </table>
        <table style="margin-left:auto;margin-right:auto;" >
            <tr style="text-align:center">
        <td ><asp:label ID="fname" runat="server" Text="Write new Password below" ></asp:label></td></tr>
        <tr><td><asp:textbox ID="sfname" runat="server" Width="600px" BorderColor="#5B6098"></asp:textbox></td></tr>
               <tr> <td><asp:Button ID="search" runat="server" OnClick="search_Click" Text="Change Password"/></td>
            </tr></table>
        <br />
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td><asp:Label runat="server" ID="pass" Text="" ></asp:Label></td>

                </tr>
               
            </table>
       
    </div>
    </form>
</body>
</html>
