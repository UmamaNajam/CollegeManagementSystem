using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace WebApplication2
{
    public partial class LoginFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError2.Visible = false;
            
        }

        protected void btnLogin_Click2(object sender, EventArgs e)
        {
           
                Functions F1 = new Functions();
                facultyLogin S = new facultyLogin();
                S.password = txtPassword2.Text.Trim();
                S.username = txtUserName2.Text.Trim();
                int count = F1.LoginFaculty(S); 
                if (count==0)
                {
                    Session["username"] = txtUserName2.Text.Trim();
                    Response.Redirect("DashboardFaculty.aspx");

                }
                else { lblError2.Visible = true; }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FacultySignUp.aspx");
            

        }
    }
}