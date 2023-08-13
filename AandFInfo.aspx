<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AandFInfo.aspx.cs" Inherits="WebApplication2.AandFInfo" %>

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
            <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Review Form Submition by <%=HttpContext.Current.Session["username"]%></h1>
    <form id="form1" runat="server">
    <div>
       <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Admin Information</td>
                </tr>
            </table>
        <asp:GridView runat="server" ID="Grid1" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
        <br />
        <br />
         <table style="margin-left:auto;margin-right:auto;" >
            <tr style="text-align:center">
        <td ><asp:label ID="fname" runat="server" Text="Search the name of Faculty Member" ></asp:label></td></tr>
        <tr><td><asp:textbox ID="sfname" runat="server" Width="600px" BorderColor="#5B6098"></asp:textbox></td>
                <td><asp:Button ID="search" runat="server" OnClick="search_Click" Text="Search"/></td>
            </tr></table>
    <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Faculty Information</td>
                </tr>
            </table>
             <asp:GridView runat="server" ID="Grid2" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Courses Information</td>
                </tr>
            </table>
             <asp:GridView runat="server" ID="Grid3" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
    </div>
    </form>
</body>
</html>
