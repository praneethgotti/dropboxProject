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
    /// Summary description for AddFiles
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AddFiles : System.Web.Services.WebService
    {
       

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
        public DataSet size(string user) {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CountSize";
            cmd.Parameters.AddWithValue("@user", user);
            return objDB.GetDataSetUsingCmdObj(cmd);
        }


        [WebMethod]
        public void updateFile(string name,byte[] document, DateTime date, int id) {
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
        public void deleteFile(int id) { 
                DBConnect objDB = new DBConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDocument";
                cmd.Parameters.AddWithValue("@id", id);
                objDB.DoUpdateUsingCmdObj(cmd);
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
        public void saveDeletedFile(int id)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SaveDeletedFile";
            cmd.Parameters.AddWithValue("@pid", id);
            objDB.DoUpdateUsingCmdObj(cmd);
        }

        [WebMethod]
        public DataSet downloadFile(int id) {
            DBConnect objDB = new DBConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DownloadFile";
            cmd.Parameters.AddWithValue("@id", id);
            return objDB.GetDataSetUsingCmdObj(cmd);  
        }

        [WebMethod]
        public void deleteUser(string username, string password, int LoginID)
        {
            if (username == "admin" && password == "1234")
            {
                DBConnect objDB = new DBConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeletePerson";
                cmd.Parameters.AddWithValue("@LoginID", LoginID);
                objDB.DoUpdateUsingCmdObj(cmd);
            }
            else
            {

            }
        }



        [WebMethod]
        public DataSet GetPersons()
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Login";
            DataSet myDS;

            myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }

        [WebMethod]
        public void updateUser(string username, string password, int LoginID, string FirstName, string LastName,
          string Username, string Password, string Email,
          string PhoneNumber)
        {
            if (username == "admin" && password == "1234")
            {
                DBConnect objDB = new DBConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdatePersons";


                SqlParameter inputparameter = new SqlParameter("@LoginID", LoginID);

                inputparameter.Direction = ParameterDirection.Input;
                inputparameter.SqlDbType = SqlDbType.Int;
                //  inputparameter.Size = 50;
                cmd.Parameters.Add(inputparameter);


                inputparameter = new SqlParameter("@FirstName", FirstName);

                inputparameter.Direction = ParameterDirection.Input;
                inputparameter.SqlDbType = SqlDbType.VarChar;
                //  inputparameter.Size = 50;
                cmd.Parameters.Add(inputparameter);
                //objDB.DoUpdateUsingCmdObj(objCommand);


                inputparameter = new SqlParameter("@LastName", LastName);

                inputparameter.Direction = ParameterDirection.Input;
                inputparameter.SqlDbType = SqlDbType.VarChar;
                //     inputparameter.Size = 50;
                cmd.Parameters.Add(inputparameter);
                // objDB.DoUpdateUsingCmdObj(objCommand);





                inputparameter = new SqlParameter("@Username", Username);
                inputparameter.Direction = ParameterDirection.Input;
                inputparameter.SqlDbType = SqlDbType.VarChar;
                //  inputparameter.Size = 50;
                cmd.Parameters.Add(inputparameter);
                //    objDB.DoUpdateUsingCmdObj(objCommand);

                inputparameter = new SqlParameter("@Password", Password);
                inputparameter.Direction = ParameterDirection.Input;
                inputparameter.SqlDbType = SqlDbType.VarChar;
                //    inputparameter.Size = 50;
                cmd.Parameters.Add(inputparameter);
                //  objDB.DoUpdateUsingCmdObj(objCommand);


                inputparameter = new SqlParameter("@Email", Email);
                inputparameter.Direction = ParameterDirection.Input;
                inputparameter.SqlDbType = SqlDbType.VarChar;
                //    inputparameter.Size = 50;
                cmd.Parameters.Add(inputparameter);
                // objDB.DoUpdateUsingCmdObj(objCommand);

                inputparameter = new SqlParameter("@PhoneNumber", PhoneNumber);
                inputparameter.Direction = ParameterDirection.Input;
                inputparameter.SqlDbType = SqlDbType.VarChar;
                //   inputparameter.Size = 50;
                cmd.Parameters.Add(inputparameter);
                objDB.DoUpdateUsingCmdObj(cmd);
            }
            else
            {

            }


        }


    }
}
