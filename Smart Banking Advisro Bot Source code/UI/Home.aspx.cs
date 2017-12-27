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
    public partial class Home : System.Web.UI.Page
    {
        UserRegisterBO userB = new UserRegisterBO();
        UserRegisterDAL userD = new UserRegisterDAL();
        LoginBO loginB = new LoginBO();
        LoginBAL lb = new LoginBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRegister.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            loginB.userName=UserName.Text;
            loginB.password=PassLog.Text;
            UserName.Text = "";
            PassLog.Text = "";
            int res = lb.CheckLogin(loginB);
            if (res == 0)
            {
                string script = "<script type=\"text/javascript\">alert('Incorrect username or password!!!');</script>";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script);
                
                Response.Redirect("Home.aspx");
            }
            else
            {
                Session["userName"] = loginB.userName;
                Response.Redirect("Main.aspx");
            }

        }
    }
}