<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsFee.aspx.cs" Inherits="WebApplication2.AsFee" %>

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
            <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Assignment of Fee by <%=HttpContext.Current.Session["username"]%></h1>
    <form id="form1" runat="server">
    <div>

        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Fee Information</td>
                </tr>
            </table>
             <asp:GridView runat="server" ID="Grid3" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
        <br /><br />
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Enter Information</td>
                </tr>
            </table>
    
        <table style="border-color: white; border-width:2px;margin-left:auto;margin-right:auto;">
        
            <tr >
        <td><asp:Label ID="slot" runat="server" Text="Select Slot:" ></asp:Label></td>
        <td><asp:DropDownList ID="cid" runat="server">   
        </asp:DropDownList> </td>

                </tr>
            <tr>
                <td><asp:Label ID="money" runat="server" Text="Select Amount:" ></asp:Label></td>
                <td><asp:TextBox ID="mon" runat="server"></asp:TextBox></td>
            </tr>
            </table>

        <table style="margin-left:auto;margin-right:auto;">
            <tr>
                <td><asp:Button ID="Save" runat="server" Text="Save"  OnClick="Save_Click"/></td>
            </tr>
        </table>
        <table style="margin-left:auto;margin-right:auto;">
            <tr>
                <td><asp:Label ID="Submitted" runat="server"/></td>
            </tr>
        </table>


    </div>
    </form>
</body>
</html>
