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
    public partial class AsFee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDropDownList();
            }
            SqlConnection con = new SqlCon().getCon();
            string query = "select CourseName, Fee from Course join FeeInfo on CID=CourseID" ;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Grid3.DataSource = reader;
            Grid3.DataBind();
            reader.Close();
        }
        private void FillDropDownList()
        {
            SqlConnection con = new SqlCon().getCon();
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter myda = new SqlDataAdapter("Select CourseName from Course", con);
            myda.Fill(ds);
            cid.DataSource = ds;
            cid.DataValueField = "CourseName";
            cid.DataBind();
            cid.Items.Insert(0, new ListItem("--Select--", "0"));
            con.Close();
            
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            int count=f.ASFee(cid.Text, Convert.ToInt32(mon.Text));
            if (count != -1)
            {
                Submitted.Text = "Updated";
                Submitted.Visible = true;
                SqlConnection con = new SqlCon().getCon();
                string query = "select CourseName, Fee from Course join FeeInfo on CID=CourseID";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Grid3.DataSource = reader;
                Grid3.DataBind();
                reader.Close();
            }
            else
            {
                Submitted.Text = "Unable to update";
                Submitted.Visible = true;
            }
        }
    }
}