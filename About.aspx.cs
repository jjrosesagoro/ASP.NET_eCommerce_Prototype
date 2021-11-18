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
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
                //creating a session which will be used to store data
            {
                Label3.Text = "Hello, " + Session["username"].ToString();
                //The label is being filled with the dtaa held in the session after it's being converted to string
                HyperLink1.Visible = false;
                //visibility of the hyperlink set to false under certain conditions
                LinkButton1.Visible = true;
                //visibility of the linkbutton set to true under certain conditions
            }
            else
            {
                Label3.Text = "Hello visitor, Welcome!";
                //else part of the if statement in which the label will be filled with the above text if requirements aren't met
                HyperLink1.Visible = true;
                //visibility of the hyperlink set to true under certain conditions
                LinkButton1.Visible = false;
                //visibility of the linkbutton set to false under certain condition

            }

            DataTable dt = new DataTable();
            //creating a new data table
            dt = (DataTable)Session["buyitems"];
            //creating a session within the data table
            if (dt != null)
            {
                //if the data table is empty the amount of rows will be counted and converted to string
                Label5.Text = dt.Rows.Count.ToString();
            }
            else
            {
                Label5.Text = "0";
                //if not the value of 0 will be output
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "addtocart")
                //unique command name given within the data list that can be executed
            {

                DropDownList dlist = (DropDownList)(e.Item.FindControl("DropDownList1"));
                //within the data list the find control method is being used to fetch a value stored within a DDL
                Response.Redirect("Contact.aspx?id=" + e.CommandArgument.ToString() + "&quantity=" + dlist.SelectedItem.ToString());
                //if so then the page will be redirected and the argument converted to string

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            //upon click event the session will be abandoned thus dumping all data held within currently
            Response.Redirect("Default.aspx");
            //the page will be redirected
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}