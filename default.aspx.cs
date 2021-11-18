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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            //creating a session which will be used to store data
            {
                Label3.Text = "Hello, " + Session["username"].ToString();
                //The label is being filled with the dtaa held in the session after it's being converted to string
                LinkButton1.Visible = true;
                //visibility of the linkbutton set to true under certain conditions
            }
            else
            {
                Label3.Text = "Hello visitor, Welcome!";
                //else part of the if statement in which the label will be filled with the above text if requirements aren't met
                LinkButton1.Visible = false;
                //visibility of the linkbutton set to false under certain condition

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
            //executed upon button click event
        {
            try
            {
                String mycon1 = "Data Source=MSI;Initial Catalog=WBL2;Integrated Security=True";
                //connection string to the database
                SqlConnection s = new SqlConnection(mycon1);
                //physical connection being established and given a name
                string uname = TextBox1.Text;
                string pass = TextBox2.Text;
                //text box values converted to string
                s.Open();
                //connection being opened

                string qry = "select * from LoginDetails where Username='" + uname + "' and Password='" + pass + "'";
                //Sequel query which selects data from the LoginDetails table within the database
                SqlCommand cmd = new SqlCommand(qry, s);
                //new sequel command being created and given a name
                SqlDataReader sdr = cmd.ExecuteReader();
                //executing the data reader
                if (sdr.Read())
                {
                    Session["username"] = uname;
                    //username details stored in the session have to match what's in the database

                    Response.Redirect("About.aspx");
                    //as a reponse the page will be redirected
                }
                else
                {
                    Label4.Text = "Invalid Username or Password";
                    //if not the following error message will be output

                }
                s.Close();
                //connection to the database being closed
            }
            catch (Exception ex)
            //catching the possible exception as a form of debugging
            {
                Response.Write(ex.Message);
                //outputting the exception in the error log
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            //data being held within the session is abandoned
            Response.Redirect("Default.aspx");
            //page is redirected as a result
        }
      }
    }
