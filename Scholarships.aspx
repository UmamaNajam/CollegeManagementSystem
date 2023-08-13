<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Scholarships.aspx.cs" Inherits="WebApplication2.Scholarships" %>

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
        <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Scholarships</h1>

    <form id="form1" runat="server">
    <div>
    <asp:GridView runat="server" ID="Grid1" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
    </div>
    </form>
</body>
</html>
