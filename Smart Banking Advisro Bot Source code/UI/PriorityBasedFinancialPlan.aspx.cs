using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Banking_Advisor_bot.Data_Access_Layer;
using Banking_Advisor_bot.Business_objects;
using Banking_Advisor_bot.Business_Access_Layer;
using System.Data;
using System.Data.SqlClient;

namespace Banking_Advisor_bot
{
    public partial class PriorityBasedFinancialPlan : System.Web.UI.Page
    {
       
            ExpensePlan_resultDAL expDAL = new ExpensePlan_resultDAL();
        ExpensesDAL expenseD = new ExpensesDAL();
        FinancialPlan_computation finCompute = new FinancialPlan_computation();
        updateThreshold upTH = new updateThreshold();
        FinancialPlanResult planResult = new FinancialPlanResult();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dataS= finCompute.BindfinancialData_grid();
            DataSet ds = finCompute.BindfinancialPlan_grid();
            if (dataS.Tables.Count > 0)
            {
                FinancialDataGrid.DataSource = dataS;
                FinancialDataGrid.DataBind();

            }
            else
            {
                ShowAlert("No record found");

            }

            if (ds.Tables.Count > 0)
            {
                GridFinancialPlanResult.DataSource = ds;
                GridFinancialPlanResult.DataBind();

            }
            else
            {
                ShowAlert("No record found");

            }
        }
        public void ShowAlert(string message)
        {
            string st = "<script language= 'javascript' type= 'text/javascript'> alert('" + message + "');</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "JS", st);
        }
        
    }
}