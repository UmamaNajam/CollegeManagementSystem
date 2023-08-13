<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiveFeedback.aspx.cs" Inherits="WebApplication2.GiveFeedback" %>

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
        <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Review Form Submition by <%=HttpContext.Current.Session["username"]%></h1>
    <form id="form1" runat="server">
    <div>
        <table style="border-color: white; border-width:2px">
        <tr >
                <td >
        <asp:Label ID="teacher" runat="server" Text="First Name:" ></asp:Label></td>
        <td><asp:DropDownList ID="Fname" runat="server"> 
        </asp:DropDownList></td>
        </tr>
            <tr >
        <td><asp:Label ID="lastname" runat="server" Text="Last Name:" ></asp:Label></td>
        <td><asp:DropDownList ID="Lname" runat="server">   
        </asp:DropDownList></td>

                </tr>
            <tr >
        <td><asp:Label ID="slot" runat="server" Text="Select Slot Number:" ></asp:Label></td>
        <td><asp:DropDownList ID="slotid" runat="server">   
        </asp:DropDownList> </td>

                </tr>
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
            <tr>
        <td><asp:Label ID="Satisfied" runat="server" Text="Are you Satified? (Yes or No):" ></asp:Label></td>
        <td><asp:TextBox ID="sat" runat="server"></asp:TextBox> </td>
         </tr>
            <tr >
        <td><asp:Label ID="imp" runat="server" Text="Comments:" ></asp:Label> </td>
        <td><asp:TextBox ID="imptxt" runat="server" TextMode="MultiLine"></asp:TextBox> </td>
         
                </tr>
        </table>
        <table>
            <tr>
                <td><asp:button ID="newform" runat="server" Text="Reset" OnClick="newform_Click"/></td>
                <td><asp:Button ID="submit" Text="Submit Feedback" runat="server" OnClick="submit_Click"/></td>
            </tr>
            <tr></tr>
            </table>
        <table>
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
