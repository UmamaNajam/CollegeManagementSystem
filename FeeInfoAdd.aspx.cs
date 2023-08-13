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
    public partial class FeeInfoAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlCon().getCon();
            string query = "select * from Student where FName='" + sfname.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Grid2.DataSource = reader;
            Grid2.DataBind();
            reader.Close();

        }

        protected void Grid2_SelectedIndexChanged(object sender, EventArgs e)
        {
            num.Text = Grid2.SelectedRow.Cells[1].Text;
            SqlConnection con = new SqlCon().getCon();
            con.Open();
            string query2 = "select Status, Due, YearName  from FeeStat f join YearInfo y on f.YearID= y.YearID where RollNo='" + num.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);

            SqlDataReader reader2 = cmd2.ExecuteReader();

            Grid3.DataSource = reader2;
            Grid3.DataBind();

            con.Close();
        }
    }
}