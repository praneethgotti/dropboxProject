using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using Utilities;


namespace FinalProject
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Harshad") && txtPassword.Text.Equals("Patel"))
            {
                Session["username"] = txtUsername.Text;
                Server.Transfer("AdminDashBoard.aspx");
            }
            else if (txtUsername.Text.Equals("Praneeth") && txtPassword.Text.Equals("Gottipati"))
            {
                Session["username"] = txtUsername.Text;
                Server.Transfer("AdminDashBoard.aspx");
            }
            else {
                Label1.Text = "Invalid Credential";
            }
            
        }
    }
}