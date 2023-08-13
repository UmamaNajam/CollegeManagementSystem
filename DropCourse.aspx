<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropCourse.aspx.cs" Inherits="WebApplication2.DropCourse" %>

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
            <h1 style="text-align: center; color: white; font-size: 40px; border-bottom: solid white; border-top: solid white; background-color: #5B6098">Drop Course by <%=HttpContext.Current.Session["username"]%></h1>
    <form id="form1" runat="server">
    <div>
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Courses Information</td>
                </tr>
            </table>
             <asp:GridView runat="server" ID="Grid3" BackColor="White" BorderColor="#5B6098" BorderWidth="5px" HorizontalAlign="Center"></asp:GridView>
       <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td>Courses to be Dropped</td>
                </tr>
            </table>
        <table style="margin-left: auto; margin-right: auto;">
            <tr>
                <td>
                    <asp:Label ID="course" runat="server" Text="Select Course:"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="cid" runat="server">
                    </asp:DropDownList>
                </td>

            </tr>
            <tr >
        <td><asp:Label ID="slot" runat="server" Text="Select Slot Number:" ></asp:Label></td>
        <td><asp:DropDownList ID="slotid" runat="server">   
        </asp:DropDownList> </td>

                </tr>
              <tr>
        <td><asp:Label ID="year" runat="server" Text="Select Year:" ></asp:Label></td>
        <td><asp:DropDownList ID="yearID" runat="server">   
        </asp:DropDownList> </td>

                  </tr>
            

        </table>
        <br />
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td><asp:Button runat="server" ID="drop" Text="Drop Course" OnClick="drop_Click"/></td>

                </tr>
               
            </table>
        <br />
        <table style="margin-left:auto;margin-right:auto;">
                <tr class="auto-style3">
                    <td><asp:Label runat="server" ID="Submitted" Text="" ></asp:Label></td>

                </tr>
               
            </table>
      <asp:TextBox runat="server" id="txt" Visible="false"></asp:TextBox>
    </div>
    </form>
</body>
</html>

