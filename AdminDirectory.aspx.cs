using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WBL2_Project
{
    public partial class AdminDirectory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
            //command to redirec to the following page upon click event
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditCustDetails.aspx");
            //command to redirec to the following page upon click event
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditStockDetails.aspx");
            //command to redirec to the following page upon click event
        }
    }
}