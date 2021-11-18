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
    public partial class Contact : Page
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
                        GridView1.FooterRow.Cells[5].Text = "Grand Total (£)";
                        //cell 5 within the gridview footer is being given the above string
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        //the above totalprice will be converted to string and displayed within the footer cell 6

                    }
                }
            }
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
    

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = new DataTable();
            //creating a new data table and giving it a name
            dt = (DataTable)Session["buyitems"];
            //filling the data table with the data held in the above session


            for (int i = 0; i <= dt.Rows.Count - 1; i++)
                //integer equals zero and if it's smaller than or equal to the row count then ++ needs to be added
            {
                int sr;
                int sr1;
                //declaring new ints
                string qdata;
                string dtdata;
                //declaring new strings
                sr = Convert.ToInt32(dt.Rows[i]["idProduct"].ToString());
                //converting the value stored in the data table to int and then to string
                TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];
                //the row index of the grid view is equal to the table cell
                qdata = cell.Text;
                dtdata = sr.ToString();
                //the data stored in the table is being converted to string
                sr1 = Convert.ToInt32(qdata);
                //qdata which is from the data tables is being converted to int

                if (sr == sr1)
                    //if the integers are equal to each other...
                {
                    dt.Rows[i].Delete();
                    //delete the data in the data row
                    dt.AcceptChanges();
                    //changes are saved and not restored
                    break;

                }
            }

            for (int i = 1; i <= dt.Rows.Count; i++)
            //integer equals zero and if it's smaller than or equal to the row count then ++ needs to be added
            {
                dt.Rows[i - 1]["idProduct"] = i;
                dt.AcceptChanges();
                //changes are saved and not restored
            }

            Session["buyitems"] = dt;
            //the values within the data table are being stored within a session
            Response.Redirect("Contact.aspx");
            //page is being redirected
         }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("ModifyCart.aspx?idProduct=" + GridView1.SelectedRow.Cells[0].Text);
            //Page is being redirected from within the gridview control to a new page
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlaceOrder.aspx");
            //page is being redirected
        }
    }
    }
