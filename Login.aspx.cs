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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
                Functions F1= new Functions();
                Student S= new Student();
                S.password = txtPassword.Text.Trim();
                S.username = txtUserName.Text.Trim();
                int count = F1.LoginStudent(S); 
               if (count == 0)
               {
                   Session["username"] = txtUserName.Text.Trim();
                   
                   Response.Redirect("DashBoardStudent.aspx");
                   
               }
               else { lblError.Visible = true; }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentSignUp.aspx");
        }
    }
}