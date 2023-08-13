<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashboardFaculty.aspx.cs" Inherits="WebApplication2.DashboardFaculty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<meta name="viewport" content="width=device-width, initial-scale=1" />
    <style>
        body.dashboard {
            background-color: lightgrey;
            color: black;
            font-family: Arial;
            font-size: medium;
        }

        table.centertable {
            margin-left: auto;
            margin-right: auto;
            width: 1200px;
            border: 6px solid groove #5B6098;
            background-color: white;
            height: 30%;
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

        .dropbtn {
            background-color: #04AA6D;
            color: white;
            padding: 16px;
            font-size: 16px;
            border: none;
            width:200px
        }

        .dropdown {
            position: relative;
            display: inline-block;
        }

        .dropdown-content {
            display: none;
            position: absolute;
            background-color: #f1f1f1;
            min-width: 160px;
            box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
            z-index: 1;
        }

            .dropdown-content a {
                color: black;
                padding: 12px 16px;
                text-decoration: none;
                display: block;
            }

                .dropdown-content a:hover {
                    background-color: #ddd;
                }

        .dropdown:hover .dropdown-content {
            display: block;
        }

        .dropdown:hover .dropbtn {
            background-color: #3e8e41;
        }
    </style>
</head>
<body class="dashboard">
    <h1 style="text-align:center;color:white;font-size:40px;border-bottom:solid white; border-top:solid white; background-color: #5B6098">Welcome <%=HttpContext.Current.Session["username"]%></h1>
    <form id="form1" runat="server">
    <div>

        <table class="centertable">
                <tr>
                    <td>
                        <div class="dropdown">
                            <button class="dropbtn">Get Information</button>
                            <div class="dropdown-content">
                                <a href="Scholarships.aspx">Student Scholarships</a>
                                <a href="AandFInfo.aspx">Admin and Faculty Information</a>
                                
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class="dropdown">
                            <button class="dropbtn">Student Related</button>
                            <div class="dropdown-content">
                                <a href="Grade.aspx">Grade Students</a>
                                <a href="StudentInfo.aspx">Check Student Information</a>
                                
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class="dropdown">
                            <button class="dropbtn">Course Related</button>
                            <div class="dropdown-content">
                                <a href="Section.aspx">Students in Section</a>
                                <a href="ChoosenTrans.aspx">Student Transcript</a>
                                
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class="dropdown">
                            <button class="dropbtn">Account</button>
                            <div class="dropdown-content">
                                <a href="updatePassF.aspx">Change Password</a>
                                
                                
                            </div>
                        </div>
                    </td>
                  </tr>
            </table>

        <table class="centertable">
                <tr class="auto-style3">
                    <td>Faculty Information</td>
                </tr>
            </table>
        <table class="centertable">
            <tr>
                <td class="auto-style1">
        <b>First Name: </b>
        <asp:Label runat="server" ID="FName"></asp:Label>
                    </td>
                <td class="auto-style1">
        <b>Last Name:</b>
        <asp:Label runat="server" ID="Lname"></asp:Label>
                    </td>
                <td class="auto-style1">
        <b>Phone Number:</b>
        <asp:Label runat="server" ID="PhoneNo"></asp:Label>
                    </td>
                <td class="auto-style1">
        <b> CNIC:</b>
        <asp:Label runat="server" ID="CNIC"></asp:Label>
                    </td>
        <td class="auto-style1"> 
        <b> Joining Date:</b>
        <asp:Label runat="server" ID="JoinDate"></asp:Label>
            </td>
                <td class="auto-style1">
        <b> Address:</b>
        <asp:Label runat="server" ID="Address"></asp:Label>
                    </td>
         
        </tr>
        </table>
        <table class="auto-style2"><tr ><td style="width:100px"><asp:Button id="logout" runat="server" OnClick="logout_Click" Text="Logout"/></td></tr></table>
        <table class="auto-style2">
            <tr>
                <td>
                    <asp:HiddenField ID="HiddenField1" runat="server"  Value="1"/>
                </td>
                <td>
                    <asp:ImageButton ID="prev" runat="server" Height="100px" Width="100px" ImageUrl="https://icons-for-free.com/download-icon-arrow+back+back+left+previous+stroke+arrow+icon-1320185739200187742_512.png" OnClick="prev_Click"/></td>
                <td>
                    <asp:Image runat="server" id="img" Height="900px" Width="1100px" ForeColor="WhiteSmoke" ImageUrl="https://s.hdnux.com/photos/01/24/11/12/22057661/3/rawImage.jpg" />
            </td>
                <td >
                    <asp:ImageButton ID="next"  runat="server" Height="100px" Width="100px" ImageUrl="https://cdn-icons-png.flaticon.com/512/1246/1246222.png?w=360" OnClick="next_Click"/></td>
                </tr>
        </table>
    </div>
    </form>
</body>
</html>
