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
    public partial class Grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Submitted.Visible = false;
            txtUserName2.Text = Session["username"].ToString(); 
            if (!IsPostBack)
            {
                FillDropDownList();
            }
        }
        protected void newform_Click(object sender, EventArgs e)
        {
            cid.SelectedValue = "0";
            yearID.SelectedValue = "0";
            gpatxt.Text = "0";
            rollnum.Text = "0";
            
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
            FillDropDownYear();
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
        protected void submit_Click(object sender, EventArgs e)
        {

            Functions f = new Functions();
            //string rn = txtUserName2.Text;
            string year = yearID.SelectedItem.Text;
            string c = cid.SelectedItem.Text;
            float gpa = float.Parse(gpatxt.Text);
            string rn = rollnum.Text;
            int count = f.Grade(rn,c, year, gpa);
            if (count != -1)
            {
                Submitted.Text = "Successfully Submitted";
                Session["username"] = txtUserName2.Text.Trim();
                Submitted.Visible = true;

            }
            else
            {
                Submitted.Text = "Given Information does not matach any record";
                Submitted.Visible = true;
                
            }
        }
    }
}