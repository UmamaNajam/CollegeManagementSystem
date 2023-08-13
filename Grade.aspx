<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grade.aspx.cs" Inherits="WebApplication2.Grade" %>

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
    <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Grading by <%=HttpContext.Current.Session["username"]%></h1>
    <form id="form1" runat="server">
    <div>
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Grading Form</td>
                </tr>
        </table>
        <table style="margin-left:auto;margin-right:auto;">
            <tr>
                <td>
                    <asp:Label ID="rn" runat="server" Text="Enter Student Roll-Number"></asp:Label></td>
                <td>
                    <asp:TextBox ID="rollnum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="course" runat="server" Text="Select Course:"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="cid" runat="server">
                    </asp:DropDownList>
                </td>

            </tr>
            <tr>
                <td>
                    <asp:Label ID="year" runat="server" Text="Select Year:"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="yearID" runat="server">
                    </asp:DropDownList>
                </td>

            </tr>
            <tr>
                <td>
                    <asp:Label ID="gpa" runat="server" Text="Enter the GPA:"></asp:Label></td>
                <td>
                    <asp:TextBox ID="gpatxt" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table style="margin-left:auto;margin-right:auto;">
            <tr>
                <td><asp:button ID="newform" runat="server" Text="Reset" OnClick="newform_Click"/></td>
                <td><asp:Button ID="submit" Text="Submit Feedback" runat="server" OnClick="submit_Click"/></td>
            </tr>
            <tr></tr>
            </table>
        <table style="margin-left:auto;margin-right:auto;">
            <tr>
                <td><asp:label ID="Submitted" runat="server" Text="Successfully Submitted"></asp:label></td> </tr>
            <tr></tr>
              <tr>  
                  <td></td>
            </tr>
           
        </table>
        <asp:TextBox id="txtUserName2" runat="server" Visible="false"></asp:TextBox>
    </div>
    </form>
</body>
</html>
