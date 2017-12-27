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
    public class UserRegisterDAL
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString);
        public Int32 InsertUserDetail(UserRegisterBO user, LoginBO login)
        {
            int result;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_insert_customer", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@customer_name", user.customerName);
                command.Parameters.AddWithValue("@customer_address", user.address);
                command.Parameters.AddWithValue("@customer_contact_no", user.contactNumber);
                command.Parameters.AddWithValue("@customer_mail_Id", user.emailID);
                command.Parameters.AddWithValue("@password", login.password);

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

        //Update user details
        public Int32 UpdateUserDetail(UserRegisterBO user)
        {
            int result;
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand("sp_update_customer", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@customer_name", user.customerName);
                command.Parameters.AddWithValue("@customer_address", user.address);
                command.Parameters.AddWithValue("@customer_contact_no", user.address);
                command.Parameters.AddWithValue("@customer_mail_Id", user.address);


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

    }
}