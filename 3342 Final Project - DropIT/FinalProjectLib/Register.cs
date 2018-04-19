using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace FinalProjectLib
{
    public class RegisterUser
    {
        private DBConnect objDB;
        private SqlCommand cmd;
        public RegisterUser(DBConnect objDB1, SqlCommand cmd1) {
            objDB = objDB1;
            cmd = cmd1;
        }

        public bool validateUserName(string username, string email) {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Check_UsernameEmail";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@email", email);

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
        public void registerUser(string fname, string lname, string uname, string pass, string email, string pno)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "Register_User";
            cmd1.Parameters.AddWithValue("@firstname", fname);
            cmd1.Parameters.AddWithValue("@lastname", lname);
            cmd1.Parameters.AddWithValue("@uname", uname);
            cmd1.Parameters.AddWithValue("@pwd", pass);
            cmd1.Parameters.AddWithValue("@email", email);
            cmd1.Parameters.AddWithValue("@contact", pno);
            objDB.DoUpdateUsingCmdObj(cmd1);
        }



    }
}
