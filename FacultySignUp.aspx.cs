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
    public partial class FacultySignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError2.Visible = false;
        }
        protected void txtUserName2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlCon().getCon();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from facultyLogin where username='" + txtUserName2.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblError2.Visible = true;
                lblError2.Text = "UserName taken";

            }
            else
            {
                lblError2.Visible = true;
                lblError2.Text = "UserName is Available";

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            Functions fs = new Functions();
            facultyLogin S = new facultyLogin();
            Faculty S2 = new Faculty();
            S.username = txtUserName2.Text.Trim();
            S.password = txtPassword2.Text.Trim();
            S2.FacID= txtUserName2.Text.Trim();
            S2.FName = FName.Text.Trim();
            S2.LName = LName.Text;
            S2.CNIC = cnic.Text.Trim();
            S2.JoinDate = Convert.ToDateTime(jd.Text);
            S2.PhoneNo = PhoneNo.Text;
            S2.Address = Address.Text;
            int count = fs.SignupFaculty(S, S2);
                if (count != -1)
                {
                    Session["username"] = txtUserName2.Text.Trim();
                    Response.Redirect("DashboardFaculty.aspx");

                }
                else
                {
                    lblError2.Visible = true;
                    lblError2.Text = "Error in Information";

                }
            
        }

        
    }
}