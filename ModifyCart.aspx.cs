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
    public partial class ModifyCart : System.Web.UI.Page
    {
        DataTable dt;
        //declaring a new data table and giving it the above name

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                //gets a value which indicates whether the page is being loaded for the first time or not
            {
            }
            else
            {
                if (Request.QueryString["idProduct"] != null)
                {
                    dt = (DataTable)Session["buyitems"];
                    //data table fetching data that is stored within the session


                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                        /*integer i is equal to zero and if the integer is smaller than or equal to the row count of the data table
                         then data needs to be added*/
                    {
                        int sr;
                        int sr1;
                        //new integers being declared
                        sr = Convert.ToInt32(dt.Rows[i]["idProduct"].ToString());
                        //the value within the data table is being converted to int32 and then converted to string
                        Label2.Text = Request.QueryString["idProduct"];
                        //the label is filled with the data held in idProduct
                        sr1 = Convert.ToInt32(Label2.Text);
                        //text in the label is converted to int
                        sr1 = sr1 + 1;


                        if (sr == sr1)
                            //if the integers are equal to one another
                        {
                            Label2.Text = dt.Rows[i]["idProduct"].ToString();
                            Label3.Text = dt.Rows[i]["P_Name"].ToString();
                            Label4.Text = dt.Rows[i]["Weight"].ToString();
                            Label5.Text = dt.Rows[i]["Price"].ToString();
                            DropDownList1.Text = dt.Rows[i]["quantity"].ToString();
                            Label6.Text = dt.Rows[i]["totalprice"].ToString();
                            //fetching values from the following parameters within the data table

                            break;

                        }
                    }
                }
                else
                //next part of the statement will be executed if the above requirements aren't met
                {
                }

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int cost;
                //declaring a new int named cost
                cost = Convert.ToInt32(Label5.Text.Trim());
                //the value of the new int is taken from the label which is then converted to int type

                int q;
                //declaring a new int named q
                q = Convert.ToInt32(DropDownList1.Text);
                //the value of the new int is taken from the DDL which is then converted to int type

                int totalcost;
                //declaring a new int totalcost
                totalcost = cost * q;
                //the value of total cost is quantity multiplied by cost
                Label6.Text = totalcost.ToString();
                //the above label will be filled with the output of cost multiplied by quantity to achieve the total cost
            }
            catch(Exception ex)
            //catching exceptions used as a method of debugging
            {
                Console.WriteLine("{0} Exception caught.", ex);
                //any errors caught will be written to the console in the form of an error log
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
            //button click event
        {
            dt = (DataTable)Session["buyitems"];
            //the data table is fetching its values from the session


            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            /*integer i is equal to zero and if the integer is smaller than or equal to the row count of the data table
                     then data needs to be added*/
            {
                int sr;
                int sr1;
                //declaring new integers
                sr = Convert.ToInt32(dt.Rows[i]["idProduct"].ToString());
                //the value within the data table is being converted to int32 and then converted to string
                sr1 = Convert.ToInt32(Label2.Text);
                //text in the label is converted to int


                if (sr == sr1)
                //if the integers are equal to one another
                {
                    dt.Rows[i]["idProduct"] = Label2.Text;
                    dt.Rows[i]["P_Name"] = Label3.Text;
                    dt.Rows[i]["Weight"] = Label4.Text;
                    dt.Rows[i]["Price"] = Label5.Text;
                    dt.Rows[i]["quantity"] = DropDownList1.Text;
                    dt.Rows[i]["totalprice"] = Label6.Text;
                    //fetching values from the following parameters within the data table
                    dt.AcceptChanges();
                    //changes made being saved and not able to be restored

                    break;

                }
            }
            Response.Redirect("Contact.aspx");
            //page will be redirected
         }
        }
    }
