using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Banking_Advisor_bot.Data_Access_Layer;
using Banking_Advisor_bot.Business_objects;
using Banking_Advisor_bot.Business_Access_Layer;

namespace Banking_Advisor_bot
{
    public partial class FinancialPlan : System.Web.UI.Page
    {
        IncomeBAL incomeBAL = new IncomeBAL();
        IncomeDAL incomeD = new IncomeDAL();
        IncomeSourceBO incomeB = new IncomeSourceBO();
        ExpenseBAL expenseBAL = new ExpenseBAL();
        ExpensesDAL expenseD = new ExpensesDAL();
        ExpensesBO expenseB = new ExpensesBO();
        FinancialPlan_computation finplan = new FinancialPlan_computation();
        protected void Page_Load(object sender, EventArgs e)
        {

            var var2 = Session["var1"];

            if (var2.Equals("FirstTime"))
            {

                UpdateExpense.Enabled = false;
                Session["var1"] = "UK";

            }
            else if (var2.Equals("SecondTime"))
            {
                SubmitIncome.Enabled = false;

                incomeB = incomeD.GetIncomeDetail();
                expenseB = expenseD.GetExpenseDetail();
                Txtsaving.Text = incomeB.bankAccount.ToString();
                Txtjob.Text = incomeB.jobIncome.ToString();
                Txtrent.Text = incomeB.rentalIncome.ToString();
                Txtpension.Text = incomeB.retirementPension.ToString();
                Txtsocial.Text = incomeB.socialSecurity.ToString();
                Txtother.Text = incomeB.otherSources.ToString();
                Txthouserent.Text = expenseB.houseRent.ToString();
                Txtutility.Text = expenseB.utilities.ToString();
                Txteducation.Text = expenseB.education.ToString();
                Txthealth.Text = expenseB.health.ToString();
                Txtshopping.Text = expenseB.shopping.ToString();
                Txttravel.Text = expenseB.transport.ToString();
                Txtenter.Text = expenseB.entertainment.ToString();
                Txthotel.Text = expenseB.hotelBill.ToString();
                TxtEMI.Text = expenseB.emiLoans.ToString();
                Txtotherexp.Text = expenseB.otherExp.ToString();
                Session["var1"] = "UK";


            }
        }

        protected void SubmitIncome_Click(object sender, EventArgs e)
        {
            incomeB.bankAccount = System.Convert.ToDecimal(Txtsaving.Text);
            incomeB.jobIncome = System.Convert.ToDecimal(Txtjob.Text);
            incomeB.rentalIncome = System.Convert.ToDecimal(Txtrent.Text);
            incomeB.retirementPension = System.Convert.ToDecimal(Txtpension.Text);
            incomeB.socialSecurity = System.Convert.ToDecimal(Txtsocial.Text);
            incomeB.otherSources = System.Convert.ToDecimal(Txtother.Text);
            expenseB.houseRent = System.Convert.ToDecimal(Txthouserent.Text);
            expenseB.utilities = System.Convert.ToDecimal(Txtutility.Text);
            expenseB.education = System.Convert.ToDecimal(Txteducation.Text);
            expenseB.health = System.Convert.ToDecimal(Txthealth.Text);
            expenseB.shopping = System.Convert.ToDecimal(Txtshopping.Text);
            expenseB.transport = System.Convert.ToDecimal(Txttravel.Text);
            expenseB.entertainment = System.Convert.ToDecimal(Txtenter.Text);
            expenseB.hotelBill = System.Convert.ToDecimal(Txthotel.Text);
            expenseB.emiLoans = System.Convert.ToDecimal(TxtEMI.Text);
            expenseB.otherExp = System.Convert.ToDecimal(Txtotherexp.Text);
            incomeBAL.InsertIncome(incomeB);
            expenseBAL.InsertExpense(expenseB);
            finplan.InsertExpenseManage(expenseB, incomeB);
            Response.Redirect("Main.aspx");
        }


        protected void UpdateExpense_Click(object sender, EventArgs e)
        {
            incomeB.bankAccount = System.Convert.ToDecimal(Txtsaving.Text);
            incomeB.jobIncome = System.Convert.ToDecimal(Txtjob.Text);
            incomeB.rentalIncome = System.Convert.ToDecimal(Txtrent.Text);
            incomeB.retirementPension = System.Convert.ToDecimal(Txtpension.Text);
            incomeB.socialSecurity = System.Convert.ToDecimal(Txtsocial.Text);
            incomeB.otherSources = System.Convert.ToDecimal(Txtother.Text);
            expenseB.houseRent = System.Convert.ToDecimal(Txthouserent.Text);
            expenseB.utilities = System.Convert.ToDecimal(Txtutility.Text);
            expenseB.education = System.Convert.ToDecimal(Txteducation.Text);
            expenseB.health = System.Convert.ToDecimal(Txthealth.Text);
            expenseB.shopping = System.Convert.ToDecimal(Txtshopping.Text);
            expenseB.transport = System.Convert.ToDecimal(Txttravel.Text);
            expenseB.entertainment = System.Convert.ToDecimal(Txtenter.Text);
            expenseB.hotelBill = System.Convert.ToDecimal(Txthotel.Text);
            expenseB.emiLoans = System.Convert.ToDecimal(TxtEMI.Text);
            expenseB.otherExp = System.Convert.ToDecimal(Txtotherexp.Text);
            expenseBAL.UpdateExpense(expenseB);
            incomeBAL.UpdateIncome(incomeB);
            finplan.InsertExpenseManage(expenseB, incomeB);
            Response.Redirect("Main.aspx");
        }

        protected void CancleUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}