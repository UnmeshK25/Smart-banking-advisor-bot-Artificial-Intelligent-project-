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
    public class IncomeDAL
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString);
        //Code for inserting user details and login details into database
        IncomeSourceBO incomeB = new IncomeSourceBO();
        UserRegisterBO user = new UserRegisterBO();
        decimal[] incomeArray = new decimal[5];
        public Int32 InsertIncomeDetail(IncomeSourceBO income)
        {
            
            int result;
            try
            {
                connection.Open();
                user.emailID = HttpContext.Current.Session["userName"].ToString();
                SqlCommand cmd = new SqlCommand("select registration_no from customer_register where customer_mail_Id='" + user.emailID+"'",connection);
                SqlDataReader data = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                data.Read();
                SqlCommand command = new SqlCommand("sp_insert_financial_income", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@registration_no", data.GetValue(0));
                command.Parameters.AddWithValue("@bank_account", income.bankAccount);
                command.Parameters.AddWithValue("@job_income", income.jobIncome);
                command.Parameters.AddWithValue("@rental_income", income.rentalIncome);
                command.Parameters.AddWithValue("@retirement_pension", income.retirementPension);
                command.Parameters.AddWithValue("@social_security", income.socialSecurity);
                command.Parameters.AddWithValue("@other_sources", income.otherSources);
                data.Close();

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                result = command.ExecuteNonQuery();
                command.Dispose();
                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
                
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

        public Int32 UpdateIncomeDetail(IncomeSourceBO income)
        {
            int result;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_update_financial_income", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bank_account", income.bankAccount);
                command.Parameters.AddWithValue("@job_income", income.jobIncome);
                command.Parameters.AddWithValue("@rental_income", income.rentalIncome);
                command.Parameters.AddWithValue("@retirement_pension", income.retirementPension);
                command.Parameters.AddWithValue("@social_security", income.socialSecurity);
                command.Parameters.AddWithValue("@other_sources", income.otherSources);


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                result = command.ExecuteNonQuery();
                command.Dispose();
                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
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
        public IncomeSourceBO GetIncomeDetail()
        {
            SqlDataReader data1;
            connection.Open();
            try
            {
                string name=HttpContext.Current.Session["userName"].ToString();
                SqlCommand cmd = new SqlCommand("select * from financial_income where registration_no= (select registration_no from customer_register where customer_mail_Id='" + name+"')",connection);
                data1 = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                data1.Read();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                incomeB.bankAccount = (decimal)data1["bank_account"];
                incomeB.jobIncome = (decimal)data1["job_income"];
                incomeB.rentalIncome = (decimal)data1["rental_income"];
                incomeB.retirementPension = (decimal)data1["retirement_pension"];
                incomeB.socialSecurity = (decimal)data1["social_security"];
                incomeB.otherSources = (decimal)data1["other_sources"];
                data1.Close();
                return incomeB;
                
             
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

        public decimal[] getDataOfIncome()
        {

            SqlDataReader data1;
            try
            {
                connection.Open();
                string name1 = HttpContext.Current.Session["userName"].ToString();

                SqlCommand command = new SqlCommand("select job_income as 'Job/Business Income',rental_income as 'Rental Income', retirement_pension as 'Retirement Pension', social_security as 'Social Security', other_sources as 'Other sources' from financial_income where registration_no= (select registration_no from customer_register where customer_mail_Id='" + name1 + "')", connection);

                data1 = command.ExecuteReader(CommandBehavior.CloseConnection);
                data1.Read();
                for (int i = 0; i < 5; i++)
                {
                    incomeArray[i] = System.Convert.ToDecimal(data1.GetValue(i));
                }
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                data1.Close();
                DataSet data2 = new DataSet();
                sqlData.Fill(data2);

                return incomeArray;

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

        public DataTable getDataOfIncome1()
        {

            SqlDataReader data1;
            try
            {
                connection.Open();
                string name1 = HttpContext.Current.Session["userName"].ToString();

                SqlCommand command = new SqlCommand("select job_income as 'Job/Business Income',rental_income as 'Rental Income', retirement_pension as 'Retirement Pension', social_security as 'Social Security', other_sources as 'Other sources' from financial_income where registration_no= (select registration_no from customer_register where customer_mail_Id='" + name1 + "')", connection);

                data1 = command.ExecuteReader(CommandBehavior.CloseConnection);
                data1.Read();
                for (int i = 0; i < 5; i++)
                {
                    incomeArray[i] = System.Convert.ToDecimal(data1.GetValue(i));
                }
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                data1.Close();
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