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
    public partial class DropCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt.Text = Session["username"].ToString();
            if (!IsPostBack)
            {
                FillDropDownCourse();
            }
            
        }
        private void FillDropDownCourse()
        {
            SqlConnection con = new SqlCon().getCon();
            con.Open();

            DataSet ds2 = new DataSet();
            SqlDataAdapter myda2 = new SqlDataAdapter("Select CourseName from Course ", con);
            myda2.Fill(ds2);
            cid.DataSource = ds2;
            cid.DataValueField = "CourseName";
            cid.DataBind();
            cid.Items.Insert(0, new ListItem("--Select--", "0"));
            FillDropDownSlot();
            con.Close();
            SqlConnection con2 = new SqlCon().getCon();
            con2.Open();
            string query2 = "select CourseName, y.YearName, SecName as Slot from Enrolled E join Course on CID=CourseID join YearInfo y on e.YearID= y.YearID join SectionInfo i on SlotID=SecID where RollNo='" + Session["username"].ToString() + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con2);

            SqlDataReader reader2 = cmd2.ExecuteReader();

            Grid3.DataSource = reader2;
            Grid3.DataBind();
            
            con2.Close();
        }
        private void FillDropDownSlot()
        {
            SqlConnection con = new SqlCon().getCon();
            con.Open();

            DataSet ds2 = new DataSet();
            SqlDataAdapter myda2 = new SqlDataAdapter("Select SecName from SectionInfo ", con);
            myda2.Fill(ds2);
            slotid.DataSource = ds2;
            slotid.DataValueField = "SecName";
            slotid.DataBind();
            slotid.Items.Insert(0, new ListItem("--Select--", "0"));
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

        protected void drop_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            
            string slot = slotid.SelectedItem.Text;
            string year = yearID.SelectedItem.Text;
            string c = cid.SelectedItem.Text;

            string rn = txt.Text;
            
            int count = f.Dropcourse(rn, slot, year, c);
            if (count != -1)
            {
                Submitted.Text = "Successfully Dropped";
                
                Submitted.Visible = true;
                SqlConnection con2 = new SqlCon().getCon();
                con2.Open();
                string query2 = "select CourseName, y.YearName, SecName as Slot from Enrolled E join Course on CID=CourseID join YearInfo y on e.YearID= y.YearID join SectionInfo i on SlotID=SecID where RollNo='" + Session["username"].ToString() + "'";
                SqlCommand cmd2 = new SqlCommand(query2, con2);

                SqlDataReader reader2 = cmd2.ExecuteReader();

                Grid3.DataSource = reader2;
                Grid3.DataBind();

                con2.Close();

            }
            else
            {
                Submitted.Text = "Error! Given Information does not match any record";
                Submitted.Visible = true;

            }
        }
    }
}