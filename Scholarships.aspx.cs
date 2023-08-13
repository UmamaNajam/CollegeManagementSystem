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
    public partial class Scholarships : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlCon().getCon();
            string query = "select RollNumber,FName, LName, batch from scholarships join Student on scholarships.RollNo=Student.RollNumber";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Grid1.DataSource = reader;
            Grid1.DataBind();
            con.Close();

        }
    }
}