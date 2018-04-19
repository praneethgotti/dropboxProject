using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace WebServicesFile
{
    /// <summary>
    /// Summary description for Delete
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Delete : System.Web.Services.WebService
    {


        [WebMethod]
        public void updateFile(string name, byte[] document, DateTime date, int id)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateDocument";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@document", document);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@id", id);
            objDB.DoUpdateUsingCmdObj(cmd);
        }


        [WebMethod]
        public DataSet displayByUser(string user)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ShowFiles";
            cmd.Parameters.AddWithValue("@USER", user);
            return objDB.GetDataSetUsingCmdObj(cmd);
        }


        [WebMethod]
        public void deleteFile(int id)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteDocument";
            cmd.Parameters.AddWithValue("@id", id);
            objDB.DoUpdateUsingCmdObj(cmd);
        }


        [WebMethod]
        public void saveDeletedFile(int id)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SaveDeletedFile2";
            cmd.Parameters.AddWithValue("@pid", id);
            objDB.DoUpdateUsingCmdObj(cmd);
        }


        [WebMethod]
        public void addFile(string fileName, byte[] document, DateTime date, string user)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddFile";
            cmd.Parameters.AddWithValue("@filename", fileName);
            cmd.Parameters.AddWithValue("@document", document);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@user", user);
            objDB.DoUpdateUsingCmdObj(cmd);
        }


        [WebMethod]
        public void addFiles(string cardno, string exdt, string cvv, string name, string plan, string price, string user)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Trans";
            cmd.Parameters.AddWithValue("@cardno", cardno);
            cmd.Parameters.AddWithValue("@exdt", exdt);
            cmd.Parameters.AddWithValue("@cvv", cvv);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@plan", plan);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@user", user);
            objDB.DoUpdateUsingCmdObj(cmd);
        }




        [WebMethod]
        public DataSet getUser()
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ShowUsers";
            return objDB.GetDataSetUsingCmdObj(cmd);
        }

        [WebMethod]
        public DataSet getUserFiles()
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ShowFiles";
            return objDB.GetDataSetUsingCmdObj(cmd);
        }



        [WebMethod]
        public void deleteUser(int id)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteUser";
            cmd.Parameters.AddWithValue("@id", id);
            objDB.DoUpdateUsingCmdObj(cmd);
        }



        [WebMethod]
        public void updateuser(string user, string pwd, string email, string pno, int id)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateUserDetail";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pno", pno);
            cmd.Parameters.AddWithValue("@id", id);
            objDB.DoUpdateUsingCmdObj(cmd);

        }

        

        [WebMethod]
        public DataSet size(string user)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CountSize";
            cmd.Parameters.AddWithValue("@user", user);
            return objDB.GetDataSetUsingCmdObj(cmd);
        }






        [WebMethod]

        public DataSet planValidate(string user)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Check_Plan";
            cmd.Parameters.AddWithValue("@user", user);
            return objDB.GetDataSetUsingCmdObj(cmd);
        }

        

        [WebMethod]
        public DataSet downloadFile(int id)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DownloadFile";
            cmd.Parameters.AddWithValue("@id", id);
            return objDB.GetDataSetUsingCmdObj(cmd);
        }



    }
}
