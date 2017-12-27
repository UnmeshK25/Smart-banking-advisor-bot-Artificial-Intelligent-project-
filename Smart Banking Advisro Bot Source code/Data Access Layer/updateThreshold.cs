using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Banking_Advisor_bot.Business_objects;
using Banking_Advisor_bot.Business_Access_Layer;

namespace Banking_Advisor_bot.Data_Access_Layer
{
    public class updateThreshold
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString);
        public void thresholdUpdateforfour(decimal Th1, decimal Th2, decimal Th3, decimal Th4)
        {
            connection.Open();
           
            int result;
            try
            {

                SqlCommand command = new SqlCommand("update Expenses_management SET Threshold_percentage = CASE Expenses WHEN 'Household' THEN '" + Th1 + "' WHEN 'Health' THEN '" + Th2 + "' WHEN 'Travel' THEN '" + Th3 + "' WHEN 'Lifestyle' THEN '" + Th4 + "' END WHERE Expenses IN('Household', 'Health','Travel','Lifestyle')", connection);
               

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                result = command.ExecuteNonQuery();
                command.Dispose();
                
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


        public void UpdateAllThreshold()
        {
            connection.Open();

            int result;
            try
            {

                SqlCommand command = new SqlCommand("update Expenses_management SET Threshold_percentage = CASE Expenses WHEN 'Household' THEN '23.00' WHEN 'Health' THEN '14.00' WHEN 'Education' THEN '10.00' WHEN 'Travel' THEN '10.00' WHEN 'Lifestyle' THEN '9.00' END WHERE Expenses IN('Household', 'Health','Education','Travel','Lifestyle')", connection);


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                result = command.ExecuteNonQuery();
                command.Dispose();

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

        public void UpdatepriorityThreshold(decimal th1,decimal th2, decimal th3, decimal th4, decimal th5)
        {
            connection.Open();

            int result;
            try
            {

                SqlCommand command = new SqlCommand("update Expenses_management SET Threshold_percentage = CASE Expenses WHEN 'Household' THEN '" + th1 + "' WHEN 'Health' THEN '" + th2 + "' WHEN 'Education' THEN '" + th3 + "' WHEN 'Travel' THEN '" + th4 + "' WHEN 'Lifestyle' THEN '" + th5 + "' END WHERE Expenses IN('Household', 'Health','Education','Travel','Lifestyle')", connection);


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                result = command.ExecuteNonQuery();
                command.Dispose();

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