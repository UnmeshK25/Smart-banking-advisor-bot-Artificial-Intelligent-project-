using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Banking_Advisor_bot.Business_objects;
using Banking_Advisor_bot.Data_Access_Layer;
using Banking_Advisor_bot.Business_Access_Layer;

namespace Banking_Advisor_bot
{
    public partial class UserRegister : System.Web.UI.Page
    {
        UserRegisterBO userB = new UserRegisterBO();
        UserRegisterDAL userD = new UserRegisterDAL();
        UserRegisterBAL userBAL = new UserRegisterBAL();
        LoginBO loginB = new LoginBO();
        LoginBAL lb = new LoginBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            userB.customerName=Txtname.Text;
            userB.address=Txtaddress.Text;
            userB.emailID=eMail.Text;
            userB.contactNumber=Txtcontact.Text;
            loginB.userName=eMail.Text;
            loginB.password=Password.Text;
            userBAL.UserReg(userB, loginB);
            string script = "<script type=\"text/javascript\">alert('Registered successfully. Now login to system with your login credentials!!!');</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script);
            Response.Redirect("Home.aspx");
        }
    }
}