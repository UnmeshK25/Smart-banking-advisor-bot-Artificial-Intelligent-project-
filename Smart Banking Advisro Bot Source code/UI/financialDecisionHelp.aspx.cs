using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Banking_Advisor_bot.Business_Access_Layer;
using Banking_Advisor_bot.Business_objects;
using Banking_Advisor_bot.Data_Access_Layer;
using System.Data;
using System.Data.SqlClient;

namespace Banking_Advisor_bot
{
    public partial class financialDecisionHelp : System.Web.UI.Page
    {
        FinancialDecisionLogic finLogic = new FinancialDecisionLogic();
        FinancialDecisionBO finB = new FinancialDecisionBO();
        protected void Page_Load(object sender, EventArgs e)
        {
            var loanType = Session["var1"];
            var loanAmount = Session["var2"];
            var loanperiod = Session["var3"];
            var interestRate = Session["var4"];
            finB=finLogic.financialDecision(System.Convert.ToString(loanType),System.Convert.ToDecimal(loanAmount),System.Convert.ToInt32(loanperiod),System.Convert.ToDecimal(interestRate));
            loanPeriod.Text =System.Convert.ToString(finB.targetMonths1);
            
            totalLoanAmount.Text = System.Convert.ToString(finB.totalAmountwithInterest);
            loanEMI.Text = System.Convert.ToString(finB.EMIamount);
            AddSavingper.Text = System.Convert.ToString(finB.savingDiffPercentage);
            AddSaveAmount.Text = System.Convert.ToString(finB.savingDiffAmount);
             DataSet dataS= finLogic.BindfinancialData_grid();
            DataSet ds = finLogic.BindfinancialPlan_grid();
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