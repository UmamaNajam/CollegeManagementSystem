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
    public partial class Enroll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlCon().getCon();
            string query = "select CourseName, YearName,SecName as Slot from Course join Enrolled e on CID=CourseID join SectionInfo on SecID=SlotID join YearInfo y on e.YearID=y.YearID where RollNo='" + Session["username"].ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Grid1.DataSource = reader;
            Grid1.DataBind();
            con.Close();
            Submitted.Visible = false;
            if (!IsPostBack)
            {
                FillDropDownList();
            }
        }
        private void FillDropDownList()
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
            FillDropDownCourse();
        }
        private void FillDropDownCourse()
        {
            SqlConnection con = new SqlCon().getCon();
            con.Open();

            DataSet ds2 = new DataSet();
            SqlDataAdapter myda2 = new SqlDataAdapter("Select CourseName,CourseID from Course ", con);
            myda2.Fill(ds2);
            cid.DataSource = ds2;
            cid.DataValueField = "CourseName";
            cid.DataBind();
            cid.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void enroll_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            
            string year = yearID.SelectedItem.Text;
            string c = cid.SelectedItem.Text;
            
            string rn = Session["username"].ToString();
            int count = f.Enroll(rn, year, c);
            if (count != -1)
            {
                Submitted.Text = "CONGRATULATIONS! Enrolled Successfully!";
                Session["username"] = rn;
                Submitted.Visible = true;
                yearID.SelectedValue = "0";
                cid.SelectedValue = "0";
            }
            else{
                Submitted.Text = "Sorry! Enable to Enroll. Kindly check your Fee Status. If the problem persists, please visit academic office";
                Session["username"] = rn;
                Submitted.Visible = true;


            }
        }
    }
}