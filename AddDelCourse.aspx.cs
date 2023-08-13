using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class AddDelCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            string id = courseid.Text;
            string name = coursename.Text;
            int count = f.ACourse(id, name);
            if (count != -1)
            {
                Submitted.Text = "Successfully added";

                Submitted.Visible = true;
            }
            else
            {
                Submitted.Text = "Unable to add Course";

                Submitted.Visible = true;
            }
        }


    }
}