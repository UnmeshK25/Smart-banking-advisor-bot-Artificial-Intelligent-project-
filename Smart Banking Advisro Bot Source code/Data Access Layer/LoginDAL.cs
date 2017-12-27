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
    public class LoginDAL
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString);
        string username1, password1;
        public Int32 UpdateLoginDetail(LoginBO login)
        {
            int result;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_update_login", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", login.userName);
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
        public int checkLogin(LoginBO login)
        {

            int chk;
           

            connection.Open();


            SqlCommand command = new SqlCommand("select * from Login where username='" + login.userName + "'", connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection))
            {
                Boolean abc = dr.HasRows;

                
                if (abc==false)
                {
                    //                   criteria = reader.GetString(0);
                    return
                    chk = 0;
                }
                else {
                    dr.Read();
                    username1 = dr.GetString(0);
                    password1 = dr.GetString(1);
                }
                    if (login.userName == username1 && login.password == password1)
                    {
                        chk = 1;
                    }
                    else
                        return
                            chk = 0;
                    return chk;
                
            }
        }
    }
}