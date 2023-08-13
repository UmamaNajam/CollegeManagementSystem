<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDelCourse.aspx.cs" Inherits="WebApplication2.AddDelCourse" %>

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
            <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Adding Course by <%=HttpContext.Current.Session["username"]%></h1>
    <form id="form1" runat="server">
    <div>
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Add Course</td>
                </tr>
            </table>
        <table style="margin-left: auto; margin-right: auto;">
            <tr style="text-align:center">
                <td>
                    <asp:Label ID="cid" runat="server" Text="Course ID:"></asp:Label></td></tr>
                <tr><td>
                    <asp:textbox ID="courseid" runat="server" Width="600px" BorderColor="#5B6098"></asp:textbox>
                </td>

            </tr>
        </table>
        <table style="margin-left: auto; margin-right: auto;">
            <tr style="text-align:center">
                <td>
                    <asp:Label ID="course" runat="server" Text="Course Name:"></asp:Label></td></tr>
                <tr><td>
                    <asp:textbox ID="coursename" runat="server" Width="600px" BorderColor="#5B6098"></asp:textbox>
                </td>

            </tr>
        </table>
        <table style="margin-left: auto; margin-right: auto;"><tr><td><asp:Button ID="Add" runat="server" Text="Add Course" OnClick="Add_Click"></asp:Button></td></tr></table>
       
        <table style="margin-left: auto; margin-right: auto;"><tr><td><asp:Label ID="Submitted" runat="server"></asp:Label></td></tr></table>
    
    </div>
    </form>
</body>
</html>
