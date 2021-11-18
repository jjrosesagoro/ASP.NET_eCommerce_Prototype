using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WBL2_Project
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                String mycon1 = "Data Source=MSI;Initial Catalog=WBL2;Integrated Security=True";
                //connection string to the database
                SqlConnection s = new SqlConnection(mycon1);
                //creating a new physical connection and naming it
                string uname = TextBox1.Text;
                string pass = TextBox2.Text;
                //converting the values stored within the two text boxes to string type
                s.Open();
                //opening the connection to the database
                string qry = "select * from LoginDetails where Username='" + uname + "' and Password='" + pass + "'";
                //query which is selecting certain data from a table within the database
                SqlCommand cmd = new SqlCommand(qry, s);
                SqlDataReader sdr = cmd.ExecuteReader();
                //executing the data reader command to perform the following tasks
                if (uname == "jshagoro@gmail.com" && pass == "qwe123")
                    //certain conditions that need to be met for the if statement
                {
                    //if those certain conditions are met the page will be redirected
                    Response.Redirect("AdminDirectory.aspx");
                }
                else
                {
                    Label4.Text = "Your credentials have not been authorised to access the following page";
                    //if the conditions are not met then the following error message will be output

                }
                s.Close();
                //closing the connection to the database
            }
            catch (Exception ex)
            //method for debugging in order to catch any errors which may be occuring
            {
                Response.Write(ex.Message);
                //any errors caught will as a result be written to the error log
            }
        }
    }
}
