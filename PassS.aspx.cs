﻿using System;
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
    public partial class PassS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pass.Visible = false;
        }
        protected void search_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            string rn= Session["username"].ToString();
            string passw = sfname.Text;
            int count = f.updatePassS(rn,passw);
            
            if (count != -1)
            {
                pass.Text = " Changed Successfully!";
                pass.Visible = true;

            }
            else
            {
                pass.Text = "Unable to change password!";
                pass.Visible = true;
            }

        }

      


    }
}