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
using System.Web.Services;
using System.Web.UI.DataVisualization.Charting;

namespace Banking_Advisor_bot
{
    public partial class FinanceReport : System.Web.UI.Page
    {
        ExpensesDAL expDAL = new ExpensesDAL();
        string Category="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            
                BindGvData();
                getDataBarChart();
                getDataPieChart();
            }
        }
        private void BindGvData()
        {
            gvData.DataSource = expDAL.getDataOfExpense();
            gvData.DataBind();
        }
      
       protected void getDataBarChart()
       {
           decimal[] arr2 = new decimal[10];
           string[] cat1 = new string[10];
           decimal[] Values = new decimal[10];
           string[] expenses = new string[] { "House Rent", "Utilities", "Education", "Health", "Shopping", "Transport/Travel", "Entertainment", "Outside Eating", "EMI", "Other Expenses" };
           ExpensesDAL expDAL = new ExpensesDAL();
          

           DataSet ds = new DataSet();
           DataTable dt = new DataTable();
           arr2 = expDAL.getExpenseData();
           

           int i;
       
           for (i = 0; i < 10; i++)
           {

               cat1[i] = expenses[i];
               Values[i] = arr2[i];


           }
           Chart1.Series[0].Points.DataBindXY(cat1, Values);
       }

       protected void getDataPieChart()
       {
           decimal[] arr2 = new decimal[10];
           string[] cat1 = new string[10];
           decimal[] Values = new decimal[10];
           decimal[] percentages = new decimal[10];
           string[] expenses = new string[] { "House Rent", "Utilities", "Education", "Health", "Shopping", "Transport/Travel", "Entertainment", "Outside Eating", "EMI", "Other Expenses" };
           ExpensesDAL expDAL = new ExpensesDAL();
            IncomeSourceBO incB = new IncomeSourceBO();
           IncomeDAL incDAL = new IncomeDAL();
           incB=incDAL.GetIncomeDetail();
           decimal totalIncome = incB.bankAccount + incB.jobIncome + incB.rentalIncome + incB.retirementPension + incB.socialSecurity + incB.otherSources;
           DataSet ds = new DataSet();
           DataTable dt = new DataTable();
           arr2 = expDAL.getExpenseData();
           for (int j = 0; j < 10; j++)
           {
               percentages[j] = (decimal)(arr2[j] / totalIncome) * 100;
           }
           

           int i;
           
           for (i = 0; i < 10; i++)
           {

               cat1[i] = expenses[i];
               Values[i] = percentages[i];


           }
           Chart2.Series[0].Points.DataBindXY(cat1,Values);
           this.Chart2.Series[0]["PieLabelStyle"] = "Outside";
           Chart2.Series[0].Label = "#PERCENT{P2}";
           Chart2.Series[0].LegendText = "#VALX (#PERCENT)";

       }
    }

    

}