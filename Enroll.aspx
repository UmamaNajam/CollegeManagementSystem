<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enroll.aspx.cs" Inherits="WebApplication2.Enroll" %>

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
    <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Enrollment Form for <%=HttpContext.Current.Session["username"]%></h1>
    <form id="form1" runat="server">
    <div>
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Previous Enrollment</td>
                </tr>
        </table>
        <asp:GridView runat="server" ID="Grid1" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
        <br />
        <br />
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>New Enrollment</td>
                </tr>
        </table>
                <table style="border-color: white; border-width:2px ;margin-left:auto;margin-right:auto;"">
              <tr>
        <td><asp:Label ID="year" runat="server" Text="Select your Year:" ></asp:Label></td>
        <td><asp:DropDownList ID="yearID" runat="server">   
        </asp:DropDownList> </td>

                  </tr>
            <tr >
        <td><asp:Label ID="course" runat="server" Text="Select Course ID:" ></asp:Label></td>
        <td><asp:DropDownList ID="cid" runat="server">   
        </asp:DropDownList> </td>

                </tr>
           
        </table>
        <table style="margin-left:auto;margin-right:auto;">
            <tr>
                <td><asp:Button Width="120px" id="enroll" runat="server" Text="Enroll" OnClick="enroll_Click" /></td>
            </tr>
        </table>
        
        <table style="margin-left:auto;margin-right:auto;">
            <tr>
                <td>
                    <asp:label ID="Submitted" runat="server" Text=" CONGRATULATIONS! Enrolled Successfully!"></asp:label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
'