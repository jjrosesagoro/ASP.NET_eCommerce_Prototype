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
    public partial class EditStockDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) /*Gets a value that indicates whether the page is being rendered for 
                                the first time or is being loaded in response to a postback*/
            {
                this.Bindrepeater(); //applying ispostback to the bindrepeater 
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "delete") //if the command name within the linkbutton equals 'delete' then the following code will be exeucted
                {
                    //finds button in repeater item that has been clicked
                    LinkButton button = e.CommandSource as LinkButton;
                    //finds label in repeater item that has been clicked 
                    //gives it a variable name
                    Label idstockdetails = e.Item.FindControl("Label1") as Label;
                    //int variable given value from label
                    int stockID = Convert.ToInt32(idstockdetails.Text);
                    //connection string to database
                    string connString = "Data Source=MSI;Initial Catalog=WBL2;Integrated Security=True";
                    //new SqlDB connection command
                    SqlConnection SqlCnn = new SqlConnection(connString);
                    //command given with SQL instruction to delete with parameter set as @idStock
                    SqlCommand SqlCmd = new SqlCommand("DELETE from Stock where idStock = @idStock", SqlCnn);
                    //parameter given value of stockID variable
                    SqlCmd.Parameters.Add("@idStock", SqlDbType.Int).Value = stockID;

                    try
                    {
                        //opens connection to the database
                        SqlCnn.Open();
                        //executes a simple delete statement
                        SqlCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //if any exceptions are caught the output will be displayed here
                        ex.Message.ToString();
                    }
                    finally
                    {
                        //at this point if the connection state is still open then it will be closed as all tasks would have been executed correctly
                        if (SqlCnn.State == ConnectionState.Open)
                        {
                            SqlCnn.Close(); //connection closes
                        }
                    }
                    Bindrepeater(); //binding the task to the repeater, so it can be triggered on page load
                }
            }
            catch { }

            if (e.CommandName == "update") //if the command name within the linkbutton equals 'update' then the following code will be executed
            {
                //finds button in repeater item that has been clicked
                LinkButton button = e.CommandSource as LinkButton;
                Label stockid = e.Item.FindControl("Label1") as Label;
                //finds label in repeater item that has been clicked 
                //gives it a variable name
                int stockdetailsid = Convert.ToInt32(stockid.Text);
                //int variable given value from label

                //connection string to database
                string connString = "Data Source=MSI;Initial Catalog=WBL2;Integrated Security=True";
                SqlConnection SqlCnn = new SqlConnection(connString);
                //new Sql connection command

                TextBox dataupdate2 = e.Item.FindControl("TextBox2") as TextBox;
                TextBox dataupdate3 = e.Item.FindControl("TextBox3") as TextBox;
                //finds textbox in repeater item that matches the parameter of the given textbox 
                //gives it a variable name
                string update2 = dataupdate2.Text;
                string update3 = dataupdate3.Text;

                string query = "UPDATE Stock SET InShop = @InShop, Warehouse = @Warehouse where idStock = @idStock";
                //command given with SQL instruction to update with parameter set as @idStock

                SqlCommand SqlCmd = new SqlCommand(query, SqlCnn);
                SqlCmd.Parameters.AddWithValue("@idStock", stockid.Text);
                SqlCmd.Parameters.AddWithValue("@InShop", dataupdate2.Text);
                SqlCmd.Parameters.AddWithValue("@Warehouse", dataupdate3.Text);
                //parameter given value of data taken from the textbox which it correlates to

                try
                {
                    SqlCnn.Open(); //connection open
                    SqlCmd.ExecuteNonQuery(); //executes a simple update statement

                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    //if any exceptions are caught the output will be displayed here
                }
                finally
                {
                    //at this point if the connection state is still open then it will be closed as all tasks would have been executed correctly
                    if (SqlCnn.State == ConnectionState.Open)
                    {
                        SqlCnn.Close(); //connection close
                    }
                }
                Bindrepeater(); //binding the task to the repeater, so it can be triggered on page load
            }
        }

        private void Bindrepeater()
        {
            string connString = "Data Source=MSI;Initial Catalog=WBL2;Integrated Security=True";
            //connection string to the database
            SqlConnection myConnection1 = new SqlConnection(connString);
            //creating a new physical connection using the connection string listed above
            SqlDataAdapter con = new SqlDataAdapter("SELECT * from Stock", myConnection1);
            //simple select statement which fetches the following parameters from the database

            DataTable dt = new DataTable();
            //creating a new datatable named 'dt'
            con.Fill(dt);
            //filling the new datatable with the parameters listed in the con statement
            Repeater1.DataSource = dt;
            //the datasource for the datatable that appears in the repeater
            Repeater1.DataBind();
            //binding the data in the repeater

        }
    }
}
