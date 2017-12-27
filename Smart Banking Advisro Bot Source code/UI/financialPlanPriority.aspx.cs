using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banking_Advisor_bot
{
    public partial class financialPlanPriority : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitInput_Click(object sender, EventArgs e)
        {
            Session["priority1"] = ddlFirstPriority.SelectedItem.Text;
            Session["priority2"] = ddlSecondPriority.SelectedItem.Text;
           
            Response.Redirect("FinancialPlanView.aspx");
        }
    }
}