using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Banking_Advisor_bot.Business_objects;
namespace Banking_Advisor_bot.Data_Access_Layer
{
    
    public class BankInterestDAL
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString);
        ExpensesBO expenseB = new ExpensesBO();
        UserRegisterBO user = new UserRegisterBO();

        public DataTable getBankInterestDetails(string loanType)
        {

           
            try
            {
                connection.Open();


                SqlCommand command = new SqlCommand("select * from Bank_interest where Loan_Type='" + loanType + "' and Interest_rate=(select MIN(Interest_rate) from Bank_interest where Loan_Type='"+ loanType+"')", connection);
                //command.ExecuteNonQuery();

                SqlDataAdapter sqlData = new SqlDataAdapter(command);
               
                DataSet data2 = new DataSet();
                sqlData.Fill(data2);

                return data2.Tables[0];

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
    }
}