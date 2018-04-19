using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FinalProject;
using Utilities;
using FinalProjectLib;

namespace FinalProject
{
    
    public partial class SignUpPage : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand cmd = new SqlCommand();
        int val = 0;
        string msg;
        int userval = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //UserRegistration_password.Attributes["type"] = "password";
        }
        protected void UserRegistration_submit_Click(object sender, EventArgs e)
        {
            RegisterUser reg = new RegisterUser(objDB, cmd);
            if (!UserRegistration_username.Text.Equals("") && !UserRegistration_password.Text.Equals("") && !UserRegistration_address.Text.Equals(""))
            {
                if (!reg.validateUserName(UserRegistration_username.Text, UserRegistration_address.Text))
                {
                    reg.registerUser(UserRegistration_fname.Text, UserRegistration_lname.Text, UserRegistration_username.Text, UserRegistration_password.Text, UserRegistration_address.Text, UserRegistration_contactnumber.Text);
                    Response.Redirect("LoginPage.aspx");

                }
                else
                {
                    Label1.Text = "Username or Email already Exist already exist";
                }
            }
            else
            {
                Label1.Text = "Username,Password and Email must not be empty!!";
            }
            

        }
        

    }
}