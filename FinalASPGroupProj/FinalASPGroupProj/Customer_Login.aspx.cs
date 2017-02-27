using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalASPGroupProj.AppCode;

namespace FinalASPGroupProj
{
    public partial class Customer_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCustLogin_Click(object sender, EventArgs e)
        {
            int custID = Convert.ToInt32(txtBoxCustPass.Text.ToString());
            string pass = txtBoxCustPass.Text.ToString();
            if (CustomerLoginCheck.checkcustlogin(custID, pass) == true)
            {
                Response.Redirect("Index.aspx");
            }

        }
    }
}