using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Banking_Advisor_bot.Data_Access_Layer;
using Banking_Advisor_bot.Business_objects;

namespace Banking_Advisor_bot.Business_Access_Layer
{
    
    public class LoginBAL
    {
        LoginDAL login = new LoginDAL();
        public void LoginAccess(LoginBO loginB)
        {
            try
            {
                login.UpdateLoginDetail(loginB);
            }
            catch (Exception ex)
            {
                ex.GetType();
            }
          
        }
        public int CheckLogin(LoginBO loginB)
        {
            int result = login.checkLogin(loginB);
            return result;
        }
    }
}