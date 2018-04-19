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

namespace FinalProject
{
    public partial class DeletedFile : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        FPSVC.AddFiles pxy = new FPSVC.AddFiles();



        CVS.Delete proxy = new CVS.Delete();

       // Delete df = new Delete();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Server.Transfer("LoginPage.aspx");
            }
            else
            {
                Label1.Text = Session["username"].ToString(); ;
            }
            bindGrid();
        }

        public void bindGrid()
        {
            DataSet ds = proxy.displayByUser(Label1.Text);
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                GridView1.Visible = false;
            }
        }


        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            bindGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lbl = (Label)GridView1.Rows[e.RowIndex].FindControl("Label3");
            int id = Convert.ToInt32(lbl.Text);
            proxy.saveDeletedFile(id);
            proxy.deleteFile(id);
            GridView1.EditIndex = -1;
            bindGrid();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            bindGrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = Label1.Text;
            Server.Transfer("DashBoard.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Server.Transfer("LoginPage.aspx");
        }
    }
    
}