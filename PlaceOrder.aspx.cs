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
    public partial class PlaceOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            //fetches value which indicates whether the page is being loaded for the first time or not
            {
                DataTable dt = new DataTable();
                //creating a new data table
                DataRow dr;
                dt.Columns.Add("idProduct");
                dt.Columns.Add("P_Name");
                dt.Columns.Add("Weight");
                dt.Columns.Add("Price");
                dt.Columns.Add("quantity");
                dt.Columns.Add("totalprice");
                dt.Columns.Add("Image");
                //adding the above data rows to the new data table that was created

                if (Request.QueryString["id"] != null)
                //if the query string named id is not empty then the following will be executed
                {
                    if (Session["Buyitems"] == null)
                    //if the session is empty, the following will be executed
                    {

                        dr = dt.NewRow();
                        String mycon = "Data Source=MSI;Initial Catalog=WBL2;Integrated Security=True";
                        //connection string to the database
                        SqlConnection scon = new SqlConnection(mycon);
                        //giving the connection a physical name
                        String myquery = "select * from Product where idProduct=" + Request.QueryString["id"];
                        //query to select specific data from the database and input it
                        SqlCommand cmd = new SqlCommand();
                        //declaring a new sequel command
                        cmd.CommandText = myquery;
                        cmd.Connection = scon;
                        //name of the connection that needs to be executed
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        //creating a new data set with the bellow parameters
                        da.Fill(ds);
                        //filling the new data set ^

                        dr["idProduct"] = ds.Tables[0].Rows[0]["idProduct"].ToString();
                        dr["P_Name"] = ds.Tables[0].Rows[0]["P_Name"].ToString();
                        dr["Weight"] = ds.Tables[0].Rows[0]["Weight"].ToString();
                        dr["Price"] = ds.Tables[0].Rows[0]["Price"].ToString();
                        dr["quantity"] = Request.QueryString["quantity"];
                        dr["Image"] = ds.Tables[0].Rows[0]["Image"].ToString();
                        //the data set will be filled with the above parameters

                        int price = Convert.ToInt16(ds.Tables[0].Rows[0]["Price"].ToString());
                        //declaring a new int which will take the above parameter and convert it to string
                        int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                        //declaring a new int which will take the above parameter and convert it to string
                        int totalprice = price * quantity;
                        //delcaring an int which will multiply the price by the quantity to find the grand total
                        dr["totalprice"] = totalprice;
                        //new data row being declared and given the above value

                        dt.Rows.Add(dr);
                        //adding a new data row for all of the above parameters
                        GridView1.DataSource = dt;
                        //giving the gridview a data source, being the data table
                        GridView1.DataBind();
                        //binding the data to the gridview

                        Session["buyitems"] = dt;
                        //the values within the data table are being stored within a session
                        GridView1.FooterRow.Cells[5].Text = "Grand Total (£)";
                        //cell 5 within the gridview footer is being given the above string
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        //the above totalprice will be converted to string and displayed within the footer cell 6
                        Response.Redirect("Contact.aspx");
                        //page will be redirected

                    }
                    else
                    //if the above is not executed, then the following will be as the next part of the if statement
                    {

                        dt = (DataTable)Session["buyitems"];
                        //the data table is being filled with the data stored within the session
                        int sr;
                        //new int being declared
                        sr = dt.Rows.Count;

                        dr = dt.NewRow();
                        //creating a new row within the data table
                        String mycon = "Data Source=MSI;Initial Catalog=WBL2;Integrated Security=True";
                        //connection string to the databse
                        SqlConnection scon = new SqlConnection(mycon);
                        //physical connection given a name
                        String myquery = "select * from Product where idProduct=" + Request.QueryString["id"];
                        //Sequel query to select the above parameters from the Product table within the database
                        SqlCommand cmd = new SqlCommand();
                        //declaring a new sequel command
                        cmd.CommandText = myquery;
                        cmd.Connection = scon;
                        //name of the connection that needs to be executed
                        SqlDataAdapter da = new SqlDataAdapter();
                        //new data adapter
                        da.SelectCommand = cmd;
                        //giving the select command a command name
                        DataSet ds = new DataSet();
                        //creating a new data set and giving it a name
                        da.Fill(ds);
                        //filling the data set with the below parameters

                        dr["idProduct"] = ds.Tables[0].Rows[0]["idProduct"].ToString();
                        dr["P_Name"] = ds.Tables[0].Rows[0]["P_Name"].ToString();
                        dr["Weight"] = ds.Tables[0].Rows[0]["Weight"].ToString();
                        dr["Price"] = ds.Tables[0].Rows[0]["Price"].ToString();
                        dr["quantity"] = Request.QueryString["quantity"];
                        dr["Image"] = ds.Tables[0].Rows[0]["Image"].ToString();
                        //the data set will be filled with the above parameters

                        int price = Convert.ToInt16(ds.Tables[0].Rows[0]["Price"].ToString());
                        //declaring a new int which will take the above parameter and convert it to string
                        int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                        //declaring a new int which will take the above parameter and convert it to string
                        int totalprice = price * quantity;
                        //delcaring an int which will multiply the price by the quantity to find the grand total
                        dr["totalprice"] = totalprice;
                        //new data row being declared and given the above value
                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        //grid view being given a data source
                        GridView1.DataBind();
                        //binding the data to the gridview

                        Session["buyitems"] = dt;
                        //the values within the data table are being stored within a session
                        GridView1.FooterRow.Cells[5].Text = "Grand Total (£)";
                        //cell 5 within the gridview footer is being given the above string
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        //the above totalprice will be converted to string and displayed within the footer cell 6
                        Response.Redirect("Contact.aspx");
                        //page will be redirected

                    }
                }
                else
                //second else to the if statement
                {
                    dt = (DataTable)Session["buyitems"];
                    //the data table is being filled with the data stored within the session
                    GridView1.DataSource = dt;
                    //grid view being given a data source
                    GridView1.DataBind();
                    //binding the data to the gridview
                    if (GridView1.Rows.Count > 0)
                    //if the row count of the grid view is more than 0 the following will be executed
                    {
                        GridView1.FooterRow.Cells[3].Text = "Grand Total (£)";
                        //cell 5 within the gridview footer is being given the above string
                        GridView1.FooterRow.Cells[4].Text = grandtotal().ToString();
                        //the above totalprice will be converted to string and displayed within the footer cell 6

                    }


                }
                // Label2.Text = GridView1.Rows.Count.ToString();

            }
            Label3.Text = DateTime.Now.ToShortDateString();
            //function to fetch real time date and place it within the label
            Session["Date"] = Label3.Text;
            //taking the data within the label and storing it within a session to be accessed at a later stage
            Findorderid();
            //calling the mthod i created earlier
        }

        public int grandtotal()
        {
            DataTable dt = new DataTable();
            //creating a new data table and giving it a name
            dt = (DataTable)Session["buyitems"];
            //filling the data table with the data held in the above session
            int nrow = dt.Rows.Count;
            //int declared to count the rows in the dt
            int i = 0;
            int gtotal = 0;
            //declared integers being given values
            while (i < nrow)
            //while integer is smaller than the row count
            {
                gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["totalprice"].ToString());
                //the grand total is being conerted to int and then to string

                i = i + 1;
            }
            return gtotal;
            //returning the grand total value at the end of the statement
        }
        public void Findorderid()
            //method being created to create a random Order ID number
        {
            String pass = "123456789";
            //range of numbers used to create the array
            Random r = new Random();
            //using the random function to call a random array of numbers
            char[] mypass = new char[5];
            //the array is set to be 5 characters long
            for (int i = 0; i < 5; i++)
                //integer i is equal to zero, if i is smaller than 5 then data should be added
            {
                mypass[i] = pass[(int)(5 * r.NextDouble())];
                //array of 5 number multiplied by random.double

            }
            String orderid;
            //declaring a new string
            orderid = new string(mypass);
            //giving the new string a value which is the array I created above

            Label2.Text = orderid;
            //setting the value of label 2 to that of the new string declared

            Session["Order"] = Label2.Text;
            //creating a session and storing the data within label 2 in the session


        }

        protected void Button1_Click(object sender, EventArgs e)
            //button click event
        {
            DataTable dt;
            //calling the data table created above
            dt = (DataTable)Session["buyitems"];


            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            /*integer i is equal to zero and if the integer is smaller than or equal to the row count of the data table
             then data needs to be added*/
            {
                String updatepass = "insert into BulkOrder(OrderID,DateCreated,OrderStatus) values('" + Label2.Text + "','" + Label3.Text + "','" + Label4.Text + "')";
                //sequel query to insert the data from the data table into the invoice table within the database
                String mycon1 = "Data Source=MSI;Initial Catalog=WBL2;Integrated Security=True";
                //connection string of the database
                SqlConnection s = new SqlConnection(mycon1);
                //establishing a physical connection to the database and giving it a name
                s.Open();
                //opening the connection
                SqlCommand cmd1 = new SqlCommand();
                //new sql command which will later be executed
                cmd1.CommandText = updatepass;
                //executing the string query updatepass which was declared above
                cmd1.Connection = s;
                //executing the connection based on the name it was given above
                cmd1.ExecuteNonQuery();
                //executing the insert query
                s.Close();
                //closing rhe connection

            }
            Response.Redirect("OrderSuccess.aspx");
            //redirects the page

        }
    }
}