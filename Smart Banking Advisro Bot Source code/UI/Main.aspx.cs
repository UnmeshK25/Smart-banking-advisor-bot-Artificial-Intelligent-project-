using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banking_Advisor_bot
{
    public partial class Main : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateFinancialInfo_Click(object sender, EventArgs e)
        {
            Session["var1"] = "SecondTime";
            Response.Redirect("FinancialPlan.aspx");
            
        }

        protected void SubmitFinancial_Click(object sender, EventArgs e)
        {
            Session["var1"] = "FirstTime";
            Response.Redirect("FinancialPlan.aspx");
            
        }

        protected void ViewPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("FinancialPlanView.aspx");
        }

        protected void FinancialDecisionHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("financialDecisionInput.aspx");
        }

        protected void ExpenseReport_Click(object sender, EventArgs e)
        {
            
            if (ReportTypeDDL.SelectedItem.Text == "Income Report")
            {
                //Session["Value2"] = PeriodDDL.Text;
                Response.Redirect("IncomeReport.aspx");
            }
            else if (ReportTypeDDL.SelectedItem.Text == "Expense Report")
            {
                //Session["Value2"] = PeriodDDL.Text;
                Response.Redirect("FinanceReport.aspx");
            }
            else if (ReportTypeDDL.SelectedItem.Text == "Expense comparision report")
            {
                //Session["Value2"] = PeriodDDL.Text;
                Response.Redirect("ExpenseCompare.aspx");
            }

        }

        protected void FinancialPriorityPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("financialPlanPriority.aspx");
        }

       
    }
}