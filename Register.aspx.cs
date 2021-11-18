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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
            //button click event

            /*two part insert statement that's taking the name of the customer along with their email
             and storing it within specific table and at the same time the email address of the customer
             is being used as their login username long with the unique password they created*/
        {
            String register = "insert into Customer(Name, Email) values('" + TextBox3.Text + "','" + TextBox1.Text + "')";
            //sql insert string inserting data into a table within my database
            String mycon = "Data Source=MSI;Initial Catalog=WBL2;Integrated Security=True";
            //connection string
            SqlConnection s = new SqlConnection(mycon);
            //creating a new physical connection and naming it
            s.Open();
            //opening the connection
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = register;
            //name of the command query that needs to be executed
            cmd.Connection = s;
            //executing the connection
            cmd.ExecuteNonQuery();
            //executing the query insert string
            s.Close();
            //closing the connection

            String register1 = "insert into LoginDetails(Username, Password) values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            //sql insert string inserting data into a table within my database
            String mycon1 = "Data Source=MSI;Initial Catalog=WBL2;Integrated Security=True";
            //connection string
            SqlConnection s1 = new SqlConnection(mycon1);
            //creating a new physical connection and naming it
            s1.Open();
            //opening the connection
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = register1;
            //name of the command query that needs to be executed
            cmd1.Connection = s1;
            //executing the connection
            cmd1.ExecuteNonQuery();
            //executing the query insert string
            s1.Close();
            //closing the connection

            Label4.Text = "You have successfully registered a new account!";
            //label output with the above text
        }
    }
}