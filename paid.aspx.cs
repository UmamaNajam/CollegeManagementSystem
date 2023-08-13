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
    public partial class paid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Submitted.Visible = false;
            
            if (!IsPostBack)
            {
                FillDropDownYear();
            }
        }
        private void FillDropDownYear()
        {
            SqlConnection con = new SqlCon().getCon();
            con.Open();

            DataSet ds2 = new DataSet();
            SqlDataAdapter myda2 = new SqlDataAdapter("Select YearName from YearInfo ", con);
            myda2.Fill(ds2);
            yearID.DataSource = ds2;
            yearID.DataValueField = "YearName";
            yearID.DataBind();
            yearID.Items.Insert(0, new ListItem("--Select--", "0"));
            
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

        protected void pay_Click(object sender, EventArgs e)
        {
            
            Functions f = new Functions();
            int count=f.Payment(num.Text, yearID.Text);
            if (count != -1)
            {
                Submitted.Text = "Payment Updated";
                Submitted.Visible = true;

            }
            else
            {
                Submitted.Text = "Unable to update payment!";
                Submitted.Visible = true;
            }
            
        }

        protected void Grid2_SelectedIndexChanged(object sender, EventArgs e)
        {
            num.Text = Grid2.SelectedRow.Cells[1].Text;
        }
    }
}