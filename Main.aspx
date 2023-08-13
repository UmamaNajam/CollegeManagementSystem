<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Success College Of Lahore</title>
</head>
<body style="background-color:lightgrey">
    <form id="form1" runat="server">
    <div>
    <h1 style="text-align:center;color:white;font-size:60px;border-bottom:solid white; border-top:solid white; background-color: #5B6098"">FLEX 2.0</h1>
        
        <h3 style="text-align:center;color:white;font-size:30px;"></h3>
        
        <br />
        <table>
            <tr style="text-align:center ;font-family: Arial;">
                <td style="background-color:#04AA6D;padding: 16px; height:20px"><asp:Label ID="Label1" runat="server" Text="Click below to Login as Student" style="text-align: center; color: white; font-size: 20px; "></asp:Label></td>
                <td style="background-color:#04AA6D;padding: 16px;"><asp:Label ID="Label2" runat="server" Text="Click below to Login as faculty Member" style="text-align: center; color: white; font-size: 20px; "></asp:Label></td>
                <td style="background-color:#04AA6D;padding: 16px;"><asp:Label ID="Label3" runat="server" Text="Click below to Login as Admin Member" style="text-align: center; color: white; font-size: 20px;"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="Student" BorderColor="white" BorderStyle="Solid" Height="330px" ImageAlign="Middle" ImageUrl="https://www.icegif.com/wp-content/uploads/reading-icegif-6.gif" OnClick="ImageButton1_Click" Width="440px" />
                </td>
                <td>
                    <asp:ImageButton ID="ImageButton2" runat="server" AlternateText="Faculty" BorderColor="white" BorderStyle="Solid" Height="330px" ImageAlign="Middle" ImageUrl="https://media2.giphy.com/media/26DNeMNwIpXDoXZoQ/giphy.gif?cid=790b76119858d6f84685cf9f08565a476e062e6e42941653&rid=giphy.gif" OnClick="ImageButton2_Click" Width="427px" />

                </td>
                <td>
                    <asp:ImageButton ID="ImageButton3" runat="server" AlternateText="Adminis" BorderColor="white" BorderStyle="Solid" Height="330px" ImageAlign="middle" ImageUrl="https://i.pinimg.com/originals/ef/5e/b6/ef5eb621bba282a76f7c850f4211b8e8.gif" OnClick="ImageButton3_Click" Width="440px" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
