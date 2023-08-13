using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
namespace WebApplication2
{
    public partial class Dashboard_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions f = new Functions();
            DataSet ds = f.AdminInfoForAdmin(Session["username"].ToString());
            FName.Text = ds.Tables[0].Rows[0]["FName"].ToString();
            Lname.Text = ds.Tables[0].Rows[0]["LName"].ToString();
            CNIC.Text = ds.Tables[0].Rows[0]["CNIC"].ToString();
            PhoneNo.Text = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
            des.Text = ds.Tables[0].Rows[0]["Description"].ToString();
             
        }
        protected void prev_Click(object sender, ImageClickEventArgs e)
        {
            if (HiddenField1.Value == "1")
            {
                img.ImageUrl = "https://i0.wp.com/www.bridgedetroit.com/wp-content/uploads/2021/12/Main-Photo-1.jpg?fit=1200%2C800&ssl=1";
                prev.Visible = false;
                next.Visible = true;
                HiddenField1.Value = "3";
            }
            else if (HiddenField1.Value == "2")
            {
                img.ImageUrl = "https://s.hdnux.com/photos/01/24/11/12/22057661/3/rawImage.jpg";
                next.Visible = true;
                prev.Visible = true;
                HiddenField1.Value = "1";
            }
        }
        protected void next_Click(object sender, ImageClickEventArgs e)
        {
            if (HiddenField1.Value == "1")
            {
                img.ImageUrl = "https://www.gerflor.asia/media/jobrefs/hungary/ose-lions-basketball-court/gerflor-ose-lions-basketball-court-hungary-02.png";
                next.Visible = false;
                prev.Visible = true;
                HiddenField1.Value = "2";
            }
            else if (HiddenField1.Value == "3")
            {
                img.ImageUrl = "https://s.hdnux.com/photos/01/24/11/12/22057661/3/rawImage.jpg";
                next.Visible = true;
                prev.Visible = true;
                HiddenField1.Value = "1";
            }

        }

        protected void logout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
           
            Session.Clear();
            Response.Redirect("Main.aspx");
        }
    }

}