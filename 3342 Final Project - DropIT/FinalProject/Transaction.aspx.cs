using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.IO;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using WebServicesFile;
using System.Configuration;

namespace FinalProject
{
    public partial class Transaction : System.Web.UI.Page
    {

        CVS.Delete proxyy = new CVS.Delete();

        //Transactions tr = new Transactions();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
            if (Session["username"] == null)
            {
                Server.Transfer("LoginPage.aspx");
            }
            else
            {
                Label2.Text = Session["username"].ToString(); ;
            }


            

        }





        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Value.Equals("100MB"))
            {
                Label1.Text = "5.00$";
            }
            else if (DropDownList1.SelectedItem.Value.Equals("200MB"))
            {
                Label1.Text = "10.00$";
            }
            else if (DropDownList1.SelectedItem.Value.Equals("Unlimited"))
            {
                Label1.Text = "20.00$";
            }
            else
            {
                Label1.Text = "Choose a Plan";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cardno = TextBox1.Text;
            string exdt = TextBox2.Text + "/" + TextBox3.Text;
            string cvv = TextBox4.Text;
            string name = TextBox5.Text;
            string plan = DropDownList1.Text;
            string price = Label1.Text;
            string user = Label2.Text;
            if (!TextBox1.Text.Equals("") && !TextBox1.Text.Equals("") && !TextBox1.Text.Equals("") && !TextBox1.Text.Equals("") && !TextBox1.Text.Equals("") && !DropDownList1.Text.Equals("") && !Label1.Text.Equals(""))
            {
                proxyy.addFiles(cardno, exdt, cvv, name, plan, price, user);
                Session["username"] = Label2.Text;
                Server.Transfer("DashBoard.aspx");
            }
            else
            {
                Label3.Text = "Please fill all the fields";
            }
            

        }
    }
}