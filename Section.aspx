<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Section.aspx.cs" Inherits="WebApplication2.Section1" %>

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
            <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Slot Information for <%=HttpContext.Current.Session["username"]%></h1>
    <form id="form1" runat="server">
    <div>
       <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Enter Information</td>
                </tr>
            </table>
        <table style="border-color: white; border-width:2px;margin-left:auto;margin-right:auto;"">
        
            <tr >
        <td><asp:Label ID="slot" runat="server" Text="Select Slot:" ></asp:Label></td>
        <td><asp:DropDownList ID="slotid" runat="server">   
        </asp:DropDownList> </td>

                </tr>
              <tr>
        <td><asp:Label ID="year" runat="server" Text="Select your Year:" ></asp:Label></td>
        <td><asp:DropDownList ID="yearID" runat="server">   
        </asp:DropDownList> </td>

                  </tr>
            <tr >
        <td><asp:Label ID="course" runat="server" Text="Select Course:" ></asp:Label></td>
        <td><asp:DropDownList ID="cid" runat="server">   
        </asp:DropDownList> </td>
                </tr></table>


        <table style="margin-left:auto;margin-right:auto;">
            <tr style="text-align:center">
                <td><asp:Button id="Generate" runat="server" Text="Generate" OnClick="Generate_Click"/></td>
            </tr>
        </table>
        <br />
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Students Information</td>
                </tr>
            </table>
        <asp:GridView runat="server" ID="Grid1" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
    <asp:textbox ID="none" runat="server" Visible="false"></asp:textbox>
        <table style="margin-left:auto;margin-right:auto;">
            <tr style="text-align:center">
                <td><asp:Label ID="notfound" runat="server"></asp:Label></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
