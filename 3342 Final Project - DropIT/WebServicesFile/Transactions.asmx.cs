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
    /// Summary description for Transaction
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Transactions : System.Web.Services.WebService
    {

        [WebMethod]
        public void addFile(string cardno, string exdt, string cvv, string name, string plan, string price, string user)
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

    }
}
