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
    public partial class ExpenseCompare : System.Web.UI.Page
    {
        ExpensePlan_resultDAL exPlan = new ExpensePlan_resultDAL();
       
        decimal[] incomeArray = new decimal[10];
        IncomeDAL incDAL = new IncomeDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            var val2 = Session["Value2"];

            
            BindGvData();
            getDataBarChart();
            getDataBarChart1();
        }
        private void BindGvData()
        {
            gvData.DataSource = exPlan.getDataOfFinancialPlan();
            gvData.DataBind();
        }

        protected void getDataBarChart()
        {

            string[] cat1 = new string[5];
            decimal[] Values = new decimal[5];
            decimal[] Values1 = new decimal[5];
            string[] expenseType = new string[] { "Household", "Health", "Education", "Travel/Transport", "Lifestyle" };



            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataTable data1=new DataTable();
           
            dt = exPlan.getDataOfFinancialPlan();
          

            int i;
           
            for (i = 0; i < 5; i++)
            {

                cat1[i] = expenseType[i];
                Values[i] = (decimal)dt.Rows[i][2];
                Values1[i] = (decimal)dt.Rows[i][4];


            }
            Chart1.Series[0].Points.DataBindXY(cat1, Values);
            Chart1.Series[1].Points.DataBindXY(cat1, Values1);

        }

        protected void getDataBarChart1()
        {

            string[] cat1 = new string[5];
            decimal[] Values2 = new decimal[5];
            decimal[] Values3 = new decimal[5];
            string[] expenseType = new string[] { "Household", "Health", "Education", "Travel/Transport", "Lifestyle" };



            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt = exPlan.getDataOfFinancialPlan();
            

            int i;
           
            for (i = 0; i < 5; i++)
            {

                cat1[i] = expenseType[i];
                Values2[i] = (decimal)dt.Rows[i][1];
                Values3[i] = (decimal)dt.Rows[i][3];


            }
            Chart2.Series[0].Points.DataBindXY(cat1, Values2);
            Chart2.Series[1].Points.DataBindXY(cat1, Values3);

            
        }


    }
}