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
    /// Summary description for Admin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Admin : System.Web.Services.WebService
    {

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
    }
}
