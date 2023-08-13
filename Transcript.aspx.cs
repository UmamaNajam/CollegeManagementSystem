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
    public partial class Transcript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlCon().getCon();
            string query = "select CourseName,GPA,YearID from Course join Grading on CID=CourseID where YearID='1' and RollNumber='"+Session["username"].ToString()+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Grid1.DataSource = reader;
            Grid1.DataBind();
            con.Close();
            SqlConnection con2 = new SqlCon().getCon();
            string query2 = "select CourseName,GPA,YearID from Course join Grading on CID=CourseID where YearID='2' and RollNumber='" + Session["username"].ToString() + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con2);
            con2.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            Grid2.DataSource = reader2;
            Grid2.DataBind();
            con2.Close();
        }
    }
}