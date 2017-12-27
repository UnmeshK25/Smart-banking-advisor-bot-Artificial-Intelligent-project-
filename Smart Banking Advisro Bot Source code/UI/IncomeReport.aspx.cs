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
    public partial class IncomeReport : System.Web.UI.Page
    {
        ExpensesDAL expDAL = new ExpensesDAL();
       // string Category = "";
        decimal[] incomeArray = new decimal[10];
        IncomeDAL incDAL = new IncomeDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGvData();
            getDataBarChart();
            getDataPieChart();
        }

        private void BindGvData()
        {
            gvData.DataSource = incDAL.getDataOfIncome1();
            gvData.DataBind();
        }

         protected void getDataBarChart()
       {
          
           string[] cat1 = new string[10];
           decimal[] Values = new decimal[10];
           string[] income = new string[] { "Job/Business Income", "Rental Income", "Retirement Pension", "Social Security", "Other sources" };
           
          

           DataSet ds = new DataSet();
           DataTable dt = new DataTable();
           incomeArray = incDAL.getDataOfIncome();
          

           int i;
         
           for (i = 0; i < 5; i++)
           {

               cat1[i] = income[i];
               Values[i] = incomeArray[i];


           }
           Chart1.Series[0].Points.DataBindXY(cat1, Values);
       }

       protected void getDataPieChart()
       {
           decimal[] incomeArr1 = new decimal[5];
           string[] incomeCat = new string[5];
           decimal[] incomevValues = new decimal[5];
           decimal[] incomePercentages = new decimal[10];
           string[] income = new string[] { "Job/Business Income", "Rental Income", "Retirement Pension", "Social Security", "Other sources" };
           ExpensesDAL expDAL = new ExpensesDAL();
            IncomeSourceBO incB = new IncomeSourceBO();
           IncomeDAL incDAL = new IncomeDAL();
           incB=incDAL.GetIncomeDetail();
           decimal totalIncome = incB.jobIncome + incB.rentalIncome + incB.retirementPension + incB.socialSecurity + incB.otherSources;
           DataSet ds = new DataSet();
           DataTable dt = new DataTable();
           incomeArr1 = incDAL.getDataOfIncome();
           for (int j = 0; j < 5; j++)
           {
               incomePercentages[j] = (decimal)(incomeArr1[j] / totalIncome) * 100;
           }

           int i;
           
           for (i = 0; i < 5; i++)
           {

               incomeCat[i] = income[i];
               incomevValues[i] = incomePercentages[i];


           }
           Chart2.Series[0].Points.DataBindXY(incomeCat, incomevValues);
           Chart2.Series[0].Label = "#PERCENT{P2}";
           Chart2.Series[0].LegendText = "#VALX (#PERCENT)";
       }
    
    }
}