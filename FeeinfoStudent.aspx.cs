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
    public partial class FeeinfoStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlCon().getCon();
            string query = "select CourseName as Course, Fee as FeeInRupee from Course join FeeInfo on CID=CourseID";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Grid1.DataSource = reader;
            Grid1.DataBind();
            con.Close();
        }

        protected void generate_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            Functions f2 = new Functions();
            int fee = f.CalcFee(Session["username"].ToString(), "1");
            int fee2 = f2.CalcFee(Session["username"].ToString(), "2");
            amy1.Text = fee.ToString();
            amy2.Text = fee2.ToString();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            Functions f2 = new Functions();
            DataSet ds = f.CheckFee(Session["username"].ToString(), "1");
            DataSet ds2 = f2.CheckFee(Session["username"].ToString(), "2");
            if (ds.Tables.Count != 0)
            {
                dy1.Text = ds.Tables[0].Rows[0]["Status"].ToString();

                dy2.Text = ds2.Tables[0].Rows[0]["Status"].ToString();
            }
            else
            {
                dy1.Text = "None";
                dy2.Text = "None";
            }
        }
    }
}