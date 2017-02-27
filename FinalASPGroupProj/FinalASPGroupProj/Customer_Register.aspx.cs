using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalASPGroupProj.AppCode;

namespace FinalASPGroupProj
{
    public partial class Customer_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegCust_OnClick(object sender, EventArgs e)
        {
            Customer cust = new Customer();
           // cust.CustomerID;
            cust.CustFirstName = txtBoxFirstName.Text.ToString();
            cust.CustLastName = txtBoxLastName.Text.ToString();
            cust.CustPassword = txtBoxPassword.Text.ToString();
            cust.CustGender = txtBoxGender.Text.ToString();
            cust.CustAddress = txtBoxAddress.Text.ToString();
         //   cust.custAddress1 = txtBoxAddress2.Text.ToString();
            cust.CustCity = txtBoxCity.Text.ToString();
            cust.CustProv = txtBoxProv.Text.ToString();
            cust.CustPostal = txtBoxPostal.Text.ToString();
            cust.Custcountry = txtBoxCountry.Text.ToString();
            cust.CustHomePhone = txtBoxHomePhone.Text.ToString();
            cust.CustBusPhone = txtBoxBusPhone.Text.ToString();
            cust.CustEmail = txtBoxCustEmail.Text.ToString();
            cust.CustAbout = txtBoxCustAbout.Text.ToString();
            //cust.AgentID
            CustomerDB.Registercustomer(cust);
            }

        protected void txtBoxHomePhone_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}