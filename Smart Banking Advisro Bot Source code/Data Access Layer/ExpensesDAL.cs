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
    public class ExpensesDAL
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString);
        ExpensesBO expenseB = new ExpensesBO();
        UserRegisterBO user = new UserRegisterBO();
        public Int32 InsertExpenseDetail(ExpensesBO expense)
        {
            connection.Open();
            SqlDataReader data;
            int result;
            try
            {
                user.emailID = HttpContext.Current.Session["userName"].ToString();
                SqlCommand cmd = new SqlCommand("select registration_no from customer_register where customer_mail_Id='" + user.emailID + "'", connection);
                data = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                data.Read();
                SqlCommand command = new SqlCommand("sp_insert_Expenses", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@registration_no", data.GetValue(0));
                command.Parameters.AddWithValue("@house_rent", expense.houseRent);
                command.Parameters.AddWithValue("@utilities", expense.utilities);
                command.Parameters.AddWithValue("@education", expense.education);
                command.Parameters.AddWithValue("@health", expense.health);
                command.Parameters.AddWithValue("@shopping", expense.shopping);
                command.Parameters.AddWithValue("@transport", expense.transport);
                command.Parameters.AddWithValue("@entertainment", expense.entertainment);
                command.Parameters.AddWithValue("@hotel_bill", expense.hotelBill);
                command.Parameters.AddWithValue("@EMI_loans", expense.emiLoans);
                command.Parameters.AddWithValue("@other_expenses", expense.otherExp);
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

        public Int32 UpdateExpenseDetail(ExpensesBO expense)
        {
            int result;
            connection.Open();
            try
            {

                SqlCommand command = new SqlCommand("sp_update_expenses", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@house_rent", expense.houseRent);
                command.Parameters.AddWithValue("@utilities", expense.utilities);
                command.Parameters.AddWithValue("@education", expense.education);
                command.Parameters.AddWithValue("@health", expense.health);
                command.Parameters.AddWithValue("@shopping", expense.shopping);
                command.Parameters.AddWithValue("@transport", expense.transport);
                command.Parameters.AddWithValue("@entertainment", expense.entertainment);
                command.Parameters.AddWithValue("@hotel_bill", expense.hotelBill);
                command.Parameters.AddWithValue("@EMI_loans", expense.emiLoans);
                command.Parameters.AddWithValue("@other_expenses", expense.otherExp);


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
        public ExpensesBO GetExpenseDetail()
        {
            SqlDataReader data;
            connection.Open();
            try
            {
                string name = HttpContext.Current.Session["userName"].ToString();
                SqlCommand cmd = new SqlCommand("select * from Expenses where registration_no= (select registration_no from customer_register where customer_mail_Id='" + name + "')",connection);
                data = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                data.Read();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                expenseB.houseRent = (decimal)data["house_rent"];
                expenseB.utilities = (decimal)data["utilities"];
                expenseB.education = (decimal)data["education"];
                expenseB.health = (decimal)data["health"];
                expenseB.shopping = (decimal)data["shopping"];
                expenseB.transport = (decimal)data["transport"];
                expenseB.entertainment = (decimal)data["entertainment"];
                expenseB.hotelBill = (decimal)data["hotel_bill"];
                expenseB.emiLoans = (decimal)data["EMI_loans"];
                expenseB.otherExp = (decimal)data["other_expenses"];
                data.Close();
                return expenseB;

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
        public decimal[] getExpenseData()
        {
            decimal []array1=new decimal[10];
            SqlDataReader data1;
            try
            {
                connection.Open();
                string name1 = HttpContext.Current.Session["userName"].ToString();
              
                SqlCommand command = new SqlCommand("select house_rent as 'house Rent',utilities as 'Utilities', education as 'Education', health as 'Health', shopping as 'Shopping', transport as 'Transport/Travel', entertainment as 'Entertainment',hotel_bill as 'Outside eating', EMI_loans as 'EMI', other_expenses as 'Other' from Expenses where registration_no= (select registration_no from customer_register where customer_mail_Id='" + name1 + "')", connection);
                
                data1 = command.ExecuteReader(CommandBehavior.CloseConnection);
                data1.Read();
                for (int i = 0; i < 10; i++)
                {
                    array1[i] = System.Convert.ToDecimal(data1.GetValue(i));
                }
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                data1.Close();
                DataSet data2 = new DataSet();
                sqlData.Fill(data2);
                
                return array1;

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

        public DataTable getDataOfExpense()
        {
           
            SqlDataReader data1;
            try
            {
                connection.Open();
                string name1 = HttpContext.Current.Session["userName"].ToString();

                SqlCommand command = new SqlCommand("select house_rent as 'house Rent',utilities as 'Utilities', education as 'Education', health as 'Health', shopping as 'Shopping', transport as 'Transport/Travel', entertainment as 'Entertainment',hotel_bill as 'Outside eating', EMI_loans as 'EMI', other_expenses as 'Other' from Expenses where registration_no= (select registration_no from customer_register where customer_mail_Id='" + name1 + "')", connection);

                data1 = command.ExecuteReader(CommandBehavior.CloseConnection);
                data1.Read();
               
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