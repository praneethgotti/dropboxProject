using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using FinalProjectLib;

namespace FinalProject
{
    
    
    public partial class LoginPage : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["LoginCookie"] != null)
            {
                HttpCookie gotCookie = Request.Cookies["LoginCookie"];
                inputEmail3.Text = gotCookie.Values["username"].ToString();
                inputPassword3.Text = gotCookie.Values["password"].ToString();
            }
            Control myCtrl = LoadControl("UserControlContact.ascx");
            Form.Controls.Add(myCtrl);


            Control yesCtrl = LoadControl("UserControlAbout.ascx");
            Form.Controls.Add(yesCtrl);
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            LoginUser log = new LoginUser(objDB,cmd);
            if (log.userValidation(inputEmail3.Text,inputPassword3.Text))
            {
                if (CheckBox1.Checked)
                {
                    HttpCookie myLoginCookie = new HttpCookie("LoginCookie");
                    myLoginCookie.Values["username"] = inputEmail3.Text;
                    myLoginCookie.Values["password"] = inputPassword3.Text;
                    myLoginCookie.Expires = new DateTime(2020, 2, 1);
                    Response.Cookies.Add(myLoginCookie);
                    Session["username"] = inputEmail3.Text;
                     Server.Transfer("DashBoard.aspx");
                   
                }
                else if (CheckBox2.Checked)
                {
                    HttpCookie myLoginCookie = new HttpCookie("LoginCookie");
                    HttpContext.Current.Response.Cookies.Remove("LoginCookie");
                    myLoginCookie.Value = null;
                    myLoginCookie.Values["username"] = "";
                    myLoginCookie.Values["password"] = "";
                    myLoginCookie.Expires = DateTime.Now.AddDays(-1);
                    HttpContext.Current.Response.SetCookie(myLoginCookie);
                    Session["username"] = inputEmail3.Text;
                     Server.Transfer("DashBoard.aspx");
                  
                }
                else if (!CheckBox1.Checked && !CheckBox2.Checked)
                {
                    Session["username"] = inputEmail3.Text;
                     Response.Redirect("DashBoard.aspx");
                   
                }
            }
            else {
                Label1.Text = "Invalid Credential";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }
    }
}