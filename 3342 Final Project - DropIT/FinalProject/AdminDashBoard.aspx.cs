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
    public partial class AdminDashBoard : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        FPSVC.AddFiles pxy = new FPSVC.AddFiles();

        CVS.Delete ad = new CVS.Delete();


       // Admin ad = new Admin();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            else
            {
                Label3.Text = Session["username"].ToString(); ;
            }
            if (!IsPostBack)
            {
                bindGridview();
                bindusergrid();
            }
            if (!Label3.Text.Equals("SupHarshad"))
            {
                GridView1.Columns[5].Visible = false;
            }
            
           
        }

        public void bindGridview()
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ShowAllFiles";
            DataSet ds = objDB.GetDataSetUsingCmdObj(cmd);
            if (ds.Tables[0].Rows.Count != 0)
            {
                gvUsers.DataSource = ds;
                gvUsers.DataBind();
            }
            else {
                gvUsers.Visible = false;
            }   
        }

        public void bindusergrid() {
            DataSet ds = ad.getUser();
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else {
                GridView1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ShowFiles";
            cmd.Parameters.AddWithValue("@USER", user);
            DataSet ds = objDB.GetDataSetUsingCmdObj(cmd);
            if (ds.Tables[0].Rows.Count != 0)
            {
                gvUsers.DataSource = ds;
                gvUsers.DataBind();
            }
            else
            {
                gvUsers.Visible = false;
                Label2.Text = "This user has no files.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            pxy.deleteUser("admin", "1234", Convert.ToInt32(txtRemoveUser.Text));

            Label5.Text = "The user is deleted successfully";
            gvUsers.DataBind();

                }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AccountSettings.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            bindusergrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lbl = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            TextBox txt = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt1") as TextBox;
            TextBox txt2 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt2")as TextBox;
            TextBox txt3 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt3")as TextBox;
            TextBox txt4 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt4")as TextBox;
            int id = Convert.ToInt32(lbl.Text);
            string user = txt.Text;
            string pwd = txt2.Text;
            string email = txt3.Text;
            string pno = txt4.Text;
            ad.updateuser(user, pwd, email, pno, id);
            GridView1.EditIndex = -1;
            bindusergrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            bindusergrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lbl = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            int id = Convert.ToInt32(lbl.Text);
            ad.deleteUser(id);
            bindusergrid();
        }
    }
}