using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace FinalProjectLib
{
    public class LoginUser
    {
        private DBConnect objDB;
        private SqlCommand cmd;
        public LoginUser(DBConnect objDB1, SqlCommand cmd1) {
            objDB = objDB1;
            cmd = cmd1;
        }
        public bool userValidation(string username, string password)
        {
            //string loginU, loginT;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Check_User";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            DataSet ds = objDB.GetDataSetUsingCmdObj(cmd);

            if (ds.Tables[0].Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
