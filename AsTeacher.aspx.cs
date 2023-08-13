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
    public partial class AsTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            DataSet ds = new DataSet();
            SqlDataAdapter myda = new SqlDataAdapter("Select CourseName from Course", con);
            myda.Fill(ds);
            cid.DataSource = ds;
            cid.DataValueField = "CourseName";
            cid.DataBind();
            cid.Items.Insert(0, new ListItem("--Select--", "0"));
            con.Close();
            FillDropDownSlot();
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
            con.Close();
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
            con.Close();
           
        }
        protected void gen_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlCon().getCon();
            string query = "select FName, LName, SecName,YearName from Teacher t join Faculty f on t.FacID=f.FacID join SectionInfo s on s.SecID= t.SecID join YearInfo y on t.YearID= y.YearID where CID in (select CourseID from Course where CourseName='" + cid.SelectedValue.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Grid3.DataSource = reader;
            Grid3.DataBind();
            reader.Close();
            con.Close();

        }
        protected void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlCon().getCon();
            string query = "select * from Faculty where FName='" + sfname.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Grid2.DataSource = reader;
            Grid2.DataBind();
            reader.Close();
            con.Close();

        }
        protected void Grid2_SelectedIndexChanged(object sender, EventArgs e)
        {
            num.Text = Grid2.SelectedRow.Cells[1].Text;
            string slot = slotid.SelectedItem.Text;
            string year = yearID.SelectedItem.Text;
            string c = cid.SelectedItem.Text;
            string rn = num.Text;
            Functions f = new Functions();

            int count = f.AsTeacherS(rn, c, year, slot);
            if (count != -1)
            {
                Submitted.Text = "Successfully assigned";

                Submitted.Visible = true;

            }
            else
            {
                Submitted.Text = "Failed to assign the Faculty Member";
                Submitted.Visible = true;
            }
        }
        
    }
}