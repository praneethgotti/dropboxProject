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
    public partial class DashBoard : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        FPSVC.AddFiles pxy = new FPSVC.AddFiles();



        CVS.Delete hi = new CVS.Delete();



       // AddFiles af = new AddFiles();

       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["username"]==null)
            {
                Server.Transfer("LoginPage.aspx");
            }
            else {
                Label1.Text = Session["username"].ToString(); ;
            }
            if (!IsPostBack)
            {
                bindGridView();
            }

            

        }

        public void bindGridView() {
            DataSet ds = hi.displayByUser(Label1.Text);
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else {
                GridView1.Visible = false;
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Server.Transfer("LoginPage.aspx");
            
        }

        protected void BtnUpload_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath("Uploads/") + fileName);
            DataSet ds=hi.size(Label1.Text);
            DataSet ds1 = hi.planValidate(Label1.Text);
            string plan;
            double totalsize;
            if (ds1.Tables[0].Rows.Count != 0)
            {
                plan = (ds1.Tables[0].Rows[0][0]).ToString();
            }
            else {
                plan = "";
            }
            
            string plan1 = "100MB";
            string plan2 = "200MB";
            string plan3 = "Unlimited";
            if (ds.Tables[0].Rows.Count != 0)
            {
                var qr = ds.Tables[0].Rows[0][0];
                if (qr != DBNull.Value)
                {
                    totalsize = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                }
                else {
                    totalsize = 0;
                }
                
                
            }
            else {
                totalsize = 0;
            }
            FileInfo fi = new FileInfo(FileUpload1.FileName);
            double filesize = (FileUpload1.PostedFile.ContentLength / 1024) / 1024;
            double totalfilesize = totalsize + filesize;
            byte[] document = FileUpload1.FileBytes;
            string name = fi.Name;
            string user = Label1.Text;
            
            if (totalfilesize > 2.0 && totalfilesize < 6.0 && plan.Equals(plan1) || plan.Equals(plan2) || plan.Equals(plan3))
            {
                hi.addFile(name, document, DateTime.Now, user);
                bindGridView();
            }
            
            else if (totalfilesize >= 6.0 && totalfilesize < 10.0 && plan.Equals(plan2) || plan.Equals(plan3))
            {
                hi.addFile(name, document, DateTime.Now, user);
                bindGridView();
            }
            
            else if (totalfilesize >= 10.0 && plan.Equals(plan3))
            {
                hi.addFile(name, document, DateTime.Now, user);
                bindGridView();
            }
            
            else if (totalsize <= 2.0)
            {
                hi.addFile(name, document, DateTime.Now, user);
                bindGridView();
            }
            else {
                Label4.Text = "You have used allocated space. Please purchase a plan.";
            }
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            bindGridView();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            bindGridView();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            FileUpload fp1 = (FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUpload2");
            DataSet ds = hi.size(Label1.Text);
            DataSet ds1 = hi.planValidate(Label1.Text);
            string plan;
            double totalsize;
            if (ds1.Tables[0].Rows.Count != 0)
            {
                plan = (ds1.Tables[0].Rows[0][0]).ToString();
            }
            else
            {
                plan = "";
            }
            string plan1 = "100MB";
            string plan2 = "200MB";
            string plan3 = "Unlimited";
            if (ds.Tables[0].Rows.Count != 0)
            {
                var qr = ds.Tables[0].Rows[0][0];
                if (qr != DBNull.Value)
                {
                    totalsize = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                }
                else
                {
                    totalsize = 0;
                }


            }
            else
            {
                totalsize = 0;
            }
            double filesize = (fp1.PostedFile.ContentLength / 1024) / 1024;
            double totalfilesize = totalsize + filesize;
            string name = fp1.PostedFile.FileName;
            byte[] document = fp1.FileBytes;
            
            Label lbl = (Label)GridView1.Rows[e.RowIndex].FindControl("Label3");
            int id = Convert.ToInt32(lbl.Text);
            if (totalfilesize > 10.0 && totalfilesize < 100.0 && plan.Equals(plan1) || plan.Equals(plan2) || plan.Equals(plan3))
            {
                hi.updateFile(name, document, DateTime.Now, id);
                GridView1.EditIndex = -1;
                bindGridView();
            }
            else if (totalfilesize >= 100.0 && totalfilesize < 200.0 && plan.Equals(plan2) || plan.Equals(plan3))
            {
                hi.updateFile(name, document, DateTime.Now, id);
                GridView1.EditIndex = -1;
                bindGridView();
            }
            else if (totalfilesize >= 200.0 && plan.Equals(plan3))
            {
                hi.updateFile(name, document, DateTime.Now, id);
                GridView1.EditIndex = -1;
                bindGridView();
            }
            else if (totalsize <= 10.0)
            {
                hi.updateFile(name, document, DateTime.Now, id);
                GridView1.EditIndex = -1;
                bindGridView();
            }
            else
            {
                GridView1.EditIndex = -1;
                bindGridView();
                Label4.Text = "You have used allocated space. Please purchase a plan.";
            }
        }

        protected void btnRecycleBin_Click(object sender, EventArgs e)
        {
            Session["username"] = Label1.Text;
            Server.Transfer("DeletedFile.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lbl = (Label)GridView1.Rows[e.RowIndex].FindControl("Label3");
            int id = Convert.ToInt32(lbl.Text);
            hi.saveDeletedFile(id);
            hi.deleteFile(id);
            bindGridView();
        }

        public void Downloadfiles(int id) {
            DataSet get = hi.downloadFile(id);
            
            string name = get.Tables[0].Rows[0]["FileName"].ToString();
            byte[] documentBytes = (byte[])get.Tables[0].Rows[0]["Document"];
            Response.ClearContent();
            
            Response.AddHeader("Content-Disposition", string.Format("attachment; filename=" + name));
            Response.AddHeader("Content-Length", documentBytes.Length.ToString());

            Response.BinaryWrite(documentBytes);
            Response.Flush();
            Response.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = Label1.Text;
            Server.Transfer("Transaction.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName== "Download") { 
            GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
            Label lbl = row.FindControl("Label3") as Label;
            int id = Convert.ToInt32(lbl.Text);
            Downloadfiles(id);
            }
        }
    }
}