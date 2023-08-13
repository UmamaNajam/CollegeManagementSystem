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
    public partial class AandFInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlCon().getCon();
            string query = "select Fname,LName,PhoneNo, [Description] from [Admin] join AdminInfo on [Admin].AdminID= AdminInfo.AdID order by Fname asc";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Grid1.DataSource = reader;
            Grid1.DataBind();
            con.Close();

        }

        protected void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlCon().getCon();
            string query = "select Fname, LName, PhoneNo from faculty where FName='" + sfname.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            Grid2.DataSource = reader;
            Grid2.DataBind();
            reader.Close();
            string query2 = "select Fname, LName, CourseName from faculty f join Teacher t on f.FacID=t.FacID join Course C on t.CID=C.CourseID  where FName='" + sfname.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            
            SqlDataReader reader2 = cmd2.ExecuteReader();

            Grid3.DataSource = reader2;
            Grid3.DataBind();

            con.Close();
            
        }
    }
}