<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transcript.aspx.cs" Inherits="WebApplication2.Transcript" %>

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
    <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Transcript of <%=HttpContext.Current.Session["username"]%></h1>>
    <form id="form1" runat="server">
    <div>
       <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Transcript for A1</td>
                </tr>
        </table>
        <asp:GridView runat="server" ID="Grid1" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
        <br />
        <br />

        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Transcript for A2</td>
                </tr>
        </table>
        <asp:GridView runat="server" ID="Grid2" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
    </div>
    </form>
</body>
</html>
