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
    public class ExpensePlan_resultDAL
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString);
        //Code for inserting user details and login details into database


        public Int32 UpdateExpense_PlanDetail(ExpenseTypes exp)
        {
            int result;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_update_expenses_management", connection);
                command.CommandType = CommandType.StoredProcedure;
                 command.Parameters.AddWithValue("@Expenses", "Household");
                command.Parameters.AddWithValue("@Threshold_value", exp.householdTh_value);
                command.Parameters.AddWithValue("@Actual_expense_percentages", exp.householdActual_percentage);
                command.Parameters.AddWithValue("@Actual_expense_value", exp.householdActual_value);
                            
                result = command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();


                connection.Open();
                SqlCommand command1 = new SqlCommand("sp_update_expenses_management", connection);
                command1.CommandType = CommandType.StoredProcedure;
                command1.Parameters.AddWithValue("@Expenses", "Health");
                command1.Parameters.AddWithValue("@Threshold_value", exp.healthTh_value);
                command1.Parameters.AddWithValue("@Actual_expense_percentages", exp.healthActual_percentage);
                command1.Parameters.AddWithValue("@Actual_expense_value", exp.healthActual_value);
             
                result = command1.ExecuteNonQuery();
                command1.Dispose();
                connection.Close();


                connection.Open();
                SqlCommand command2 = new SqlCommand("sp_update_expenses_management", connection);
                command2.CommandType = CommandType.StoredProcedure;
                command2.Parameters.AddWithValue("@Expenses", "Education");
                command2.Parameters.AddWithValue("@Threshold_value", exp.educationTh_value);
                command2.Parameters.AddWithValue("@Actual_expense_percentages", exp.educationActual_percentage);
                command2.Parameters.AddWithValue("@Actual_expense_value", exp.educationActual_value);
                
                result = command2.ExecuteNonQuery();
                command2.Dispose();
                connection.Close();


                connection.Open();
                SqlCommand command3 = new SqlCommand("sp_update_expenses_management", connection);
                command3.CommandType = CommandType.StoredProcedure;
                command3.Parameters.AddWithValue("@Expenses", "Travel");
                command3.Parameters.AddWithValue("@Threshold_value", exp.travelTh_value);
                command3.Parameters.AddWithValue("@Actual_expense_percentages", exp.travelActual_percentage);
                command3.Parameters.AddWithValue("@Actual_expense_value", exp.travelActual_value);
                
                result = command3.ExecuteNonQuery();
                command3.Dispose();
                connection.Close();

                
                connection.Open();
                SqlCommand command4 = new SqlCommand("sp_update_expenses_management", connection);
                command4.CommandType = CommandType.StoredProcedure;
                command4.Parameters.AddWithValue("@Expenses", "Lifestyle");
                command4.Parameters.AddWithValue("@Threshold_value", exp.lifestyleTh_value);
                command4.Parameters.AddWithValue("@Actual_expense_percentages", exp.lifestyleActual_percentage);
                command4.Parameters.AddWithValue("@Actual_expense_value", exp.lifestyleActual_value);

                result = command4.ExecuteNonQuery();
                command4.Dispose();
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

        public Int32 UpdateExpense_PlanResult(FinancialPlanResult finPlan)
        {
            int result;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_update_Result_expense_plan", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Expenses", "Household");
                command.Parameters.AddWithValue("@Percentage_of_total_income_on_expense", finPlan.householdPlan_percentage);
                command.Parameters.AddWithValue("@Amount_of_total_income_on_expense", finPlan.householdPlan_value);
                command.Parameters.AddWithValue("@Possible_saving_percentage", finPlan.householdSavingPersentages);
                command.Parameters.AddWithValue("@Possible_saving_amount", finPlan.householdSavingAmount);
               

                result = command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();


                connection.Open();
                SqlCommand command1 = new SqlCommand("sp_update_Result_expense_plan", connection);
                command1.CommandType = CommandType.StoredProcedure;
                command1.Parameters.AddWithValue("@Expenses", "Health");
                command1.Parameters.AddWithValue("@Percentage_of_total_income_on_expense", finPlan.healthPlan_percentage);
                command1.Parameters.AddWithValue("@Amount_of_total_income_on_expense", finPlan.healthPlan_value);
                command1.Parameters.AddWithValue("@Possible_saving_percentage", finPlan.healthSavingPersentages);
                command1.Parameters.AddWithValue("@Possible_saving_amount", finPlan.healthSavingAmount);


                result = command1.ExecuteNonQuery();
                command1.Dispose();
                connection.Close();


                connection.Open();
                SqlCommand command2 = new SqlCommand("sp_update_Result_expense_plan", connection);
                command2.CommandType = CommandType.StoredProcedure;
                command2.Parameters.AddWithValue("@Expenses", "Education");
                command2.Parameters.AddWithValue("@Percentage_of_total_income_on_expense", finPlan.educationPlan_percentage);
                command2.Parameters.AddWithValue("@Amount_of_total_income_on_expense", finPlan.educationPlan_value);
                command2.Parameters.AddWithValue("@Possible_saving_percentage", finPlan.educationSavingPersentages);
                command2.Parameters.AddWithValue("@Possible_saving_amount", finPlan.educationSavingAmount);


                result = command2.ExecuteNonQuery();
                command2.Dispose();
                connection.Close();


                connection.Open();
                SqlCommand command3 = new SqlCommand("sp_update_Result_expense_plan", connection);
                command3.CommandType = CommandType.StoredProcedure;
                command3.Parameters.AddWithValue("@Expenses", "Travel");
                command3.Parameters.AddWithValue("@Percentage_of_total_income_on_expense", finPlan.travelPlan_percentage);
                command3.Parameters.AddWithValue("@Amount_of_total_income_on_expense", finPlan.travelPlan_value);
                command3.Parameters.AddWithValue("@Possible_saving_percentage", finPlan.travelSavingPersentages);
                command3.Parameters.AddWithValue("@Possible_saving_amount", finPlan.travelSavingAmount);


                result = command3.ExecuteNonQuery();
                command3.Dispose();
                connection.Close();


                connection.Open();
                SqlCommand command4 = new SqlCommand("sp_update_Result_expense_plan", connection);
                command4.CommandType = CommandType.StoredProcedure;
                command4.Parameters.AddWithValue("@Expenses", "Lifestyle");
                command4.Parameters.AddWithValue("@Percentage_of_total_income_on_expense", finPlan.lifestylePlan_percentage);
                command4.Parameters.AddWithValue("@Amount_of_total_income_on_expense", finPlan.lifestylePlan_value);
                command4.Parameters.AddWithValue("@Possible_saving_percentage", finPlan.lifestyleSavingPersentages);
                command4.Parameters.AddWithValue("@Possible_saving_amount", finPlan.lifestyleSavingAmount);


                result = command4.ExecuteNonQuery();
                command4.Dispose();
               
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
        public DataSet getFinancialPlanData()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select Expenses,Threshold_percentage as 'Ideal saving percentage on expense type',Actual_expense_percentages as 'Last month expense percentage',Actual_expense_value as 'Last month expense amount' from Expenses_management", connection);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                sqlData.Fill(data);
                return data;
                
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

        public DataSet getFinancialPlanResult()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select Expenses,Percentage_of_total_income_on_expense as 'Percentage of Income',Amount_of_total_income_on_expense as 'Amount of total Income',Possible_saving_percentage 'Possible Saving Percentage',Possible_saving_amount as 'Possible Saving Amount' from Result_expense_plan", connection);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                sqlData.Fill(data);
                return data;

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

        public DataTable getDataOfFinancialPlan()
        {
            
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select Expenses,Threshold_percentage as 'Ideal expense percentage',Threshold_value as'Ideal expense value' ,Actual_expense_percentages as 'Last month expense percentage',Actual_expense_value as 'Last month expense amount' from Expenses_management", connection);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                
                DataSet data = new DataSet();
                sqlData.Fill(data);
                return data.Tables[0];

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