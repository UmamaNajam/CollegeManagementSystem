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
    public partial class LoginAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            Functions F1 = new Functions();
            adminLogin S = new adminLogin();
            S.password = txtPassword.Text.Trim();
            S.username = txtUserName.Text.Trim();
            int count = F1.LoginAdmin(S);
               if (count == 0)
               {
                   Session["username"] = txtUserName.Text.Trim();
                   Response.Redirect("Dashboard Admin.aspx");
                   
               }
               else { lblError.Visible = true; }
            
        }

        protected void checkbox(object sender, EventArgs e)
        {
            txtPassword.TextMode = TextBoxMode.SingleLine;
        }

        
    }
    

}