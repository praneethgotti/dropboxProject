using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class AccountSettings : System.Web.UI.Page
    {

        FPSVC.AddFiles pxy = new FPSVC.AddFiles();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = pxy.GetPersons();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = pxy.GetPersons();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox TBox;

            int rowIndex = e.RowIndex;


            TBox = (TextBox)GridView1.Rows[rowIndex].Cells[0].Controls[0];
            int LoginID = int.Parse(TBox.Text);





            //int SSN = Convert.ToInt32(gvCustomersDisplay.Rows[rowIndex].Cells[0].Text);
            //int SSN = int.Parse(gvCustomersDisplay.Rows[rowIndex].Cells[0].Text);


            TBox = (TextBox)GridView1.Rows[rowIndex].Cells[1].Controls[0];
            string FirstName = TBox.Text;
            TBox = (TextBox)GridView1.Rows[rowIndex].Cells[2].Controls[0];
            string LastName = TBox.Text;
            TBox = (TextBox)GridView1.Rows[rowIndex].Cells[3].Controls[0];
            string Username = TBox.Text;
            TBox = (TextBox)GridView1.Rows[rowIndex].Cells[4].Controls[0];
            string Password = TBox.Text;
            TBox = (TextBox)GridView1.Rows[rowIndex].Cells[5].Controls[0];
            string Email = TBox.Text;
            TBox = (TextBox)GridView1.Rows[rowIndex].Cells[6].Controls[0];
            string PhoneNumber = TBox.Text;
            



            pxy.updateUser("admin","1234",LoginID,FirstName,LastName,Username,Password,Email,PhoneNumber);

            GridView1.EditIndex = -1;

            
            GridView1.DataSource = pxy.GetPersons();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          //  CreditCardSVC.CreditCardService pxy = new CreditCardSVC.CreditCardService();
            //CreditCardSVC.CreditCardService pxy = new CreditCardSVC.CreditCardService();
            GridView1.DataSource = pxy.GetPersons();
            GridView1.DataBind();
        }
    }
}