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
    public partial class Section1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            none.Text=Session["username"].ToString();
           
            if (!IsPostBack)
            {
                FillDropDownSlot();
            }
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
            FillDropDownCourse();
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
        }

        protected void Generate_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            string rn = none.Text;
            string slot = slotid.Text;
            string year = yearID.Text;
            string cid2 = cid.Text;
            SqlConnection con = new SqlCon().getCon();
            string query = "select * from Enrolled where SlotID in (select SecID from SectionInfo where SecName='" + slot + "') and CID in (select CourseID from Course where CourseName='" + cid2 + "') and YearID in (select YearID from YearInfo where YearName='" + year + "')";
            
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            count = f.InfoSection(rn, slot, year, cid2);
            if (count != -1)
            {
                
                
                notfound.Text = "Students found whom you teach";
                notfound.Visible = true ;
            }
            else
            {
                notfound.Text = "No student found whom your teach";
                notfound.Visible = false;
            }
            Grid1.DataSource = reader;
            Grid1.DataBind();
            con.Close();
        }

    }
}
