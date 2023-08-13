<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FeeinfoStudent.aspx.cs" Inherits="WebApplication2.FeeinfoStudent" %>

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
        </style>
</head>
<body class="dashboard">
        <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Fee Information</h1>

    <form id="form1" runat="server">
    <div>
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Fee Information</td>
                </tr>
        </table>

        <asp:GridView runat="server" ID="Grid1" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
        <br />
        <br />
        <table style="margin-left:auto; margin-right:auto"><tr><td>
    <asp:Label ID="y1" runat="server" Text="Amount Due in A1:"></asp:Label>
        <asp:TextBox runat="server" ID="amy1"></asp:TextBox><br />
        <asp:Label ID="y2" runat="server" Text="Amount Due in A2:"></asp:Label>
        <asp:TextBox runat="server" ID="amy2"></asp:TextBox><br />
        <asp:Button id="generate"  Text="Generate" runat="server" OnClick="generate_Click"/>
        <br /><br /><br />
        <asp:Label ID="y11" runat="server" Text="Status in A1:"></asp:Label>
        <asp:TextBox runat="server" ID="dy1"></asp:TextBox> <br />
        <asp:Label ID="y22" runat="server" Text="Status in A2:"></asp:Label>
        <asp:TextBox runat="server" ID="dy2"></asp:TextBox><br />
        <asp:Button id="Show"  Text="Status" runat="server" OnClick="Button1_Click"/>
            </td></tr></table>
    </div>
    </form>
</body>
</html>
