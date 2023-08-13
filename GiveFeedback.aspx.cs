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
    public partial class GiveFeedback : System.Web.UI.Page
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
            Fname.SelectedValue = "0";
            Lname.SelectedValue = "0";
            slotid.SelectedValue = "0";
            yearID.SelectedValue = "0";
            cid.SelectedValue = "0";
            sat.Text = "";
            imptxt.Text = "";
        }
        private void FillDropDownList()
         {
            SqlConnection con= new SqlCon().getCon();
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter myda = new SqlDataAdapter("Select Fname from Faculty", con);
            myda.Fill(ds);
            Fname.DataSource = ds;
            Fname.DataValueField = "FName";
            Fname.DataBind();
            Fname.Items.Insert(0, new ListItem("--Select--", "0"));
            con.Close();
            FillDropDownListLastName();
         }
        private void FillDropDownListLastName()
        {
            SqlConnection con = new SqlCon().getCon();
            con.Open();
            string name = Fname.SelectedItem.Text;
            DataSet ds2 = new DataSet();
            SqlDataAdapter myda2 = new SqlDataAdapter("Select Lname from Faculty ", con);
            myda2.Fill(ds2);
            Lname.DataSource = ds2;
            Lname.DataValueField = "LName";
            Lname.DataBind();
            Lname.Items.Insert(0, new ListItem("--Select--", "0"));
            FillDropDownSlot();
        }
        private void FillDropDownSlot()
        {
            SqlConnection con = new SqlCon().getCon();
            con.Open();
            
            DataSet ds2 = new DataSet();
            SqlDataAdapter myda2 = new SqlDataAdapter("Select SecID from SectionInfo ", con);
            myda2.Fill(ds2);
            slotid.DataSource = ds2;
            slotid.DataValueField = "SecID";
            slotid.DataBind();
            slotid.Items.Insert(0, new ListItem("--Select--", "0"));
            FillDropDownYear();
        }
        private void FillDropDownYear()
        {
            SqlConnection con = new SqlCon().getCon();
            con.Open();

            DataSet ds2 = new DataSet();
            SqlDataAdapter myda2 = new SqlDataAdapter("Select YearID from YearInfo ", con);
            myda2.Fill(ds2);
            yearID.DataSource = ds2;
            yearID.DataValueField = "YearID";
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
        protected void submit_Click(object sender, EventArgs e)
        {

            Functions f = new Functions();
            string fname = Fname.SelectedItem.Text;
            string lname = Lname.SelectedItem.Text;
            string slot = slotid.SelectedItem.Text;
            string year = yearID.SelectedItem.Text;
            string c = cid.SelectedItem.Text;
            string sati = sat.ToString();
            string impo = imptxt.Text;
            string rn = Session["username"].ToString();
            int count=f.feedback(rn, fname, lname, slot, year, c, sati, impo);
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
                
                Fname.SelectedValue = "0";
                Lname.SelectedValue = "0";
                slotid.SelectedValue = "0";
                yearID.SelectedValue = "0";
                cid.SelectedValue = "0";
                sat.Text = "";
                imptxt.Text = "";
            }

        }

        
    }
}