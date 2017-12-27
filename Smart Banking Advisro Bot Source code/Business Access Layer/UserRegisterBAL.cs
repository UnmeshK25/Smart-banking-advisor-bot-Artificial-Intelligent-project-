using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Banking_Advisor_bot.Data_Access_Layer;
using Banking_Advisor_bot.Business_objects;

namespace Banking_Advisor_bot.Business_Access_Layer
{
    public class UserRegisterBAL
    {
        UserRegisterDAL register = new UserRegisterDAL();
        public void UserReg(UserRegisterBO regBO,LoginBO login)
        {
            try
            {
                register.InsertUserDetail(regBO,login);
            }
            catch (Exception ex)
            {
                ex.GetType();
            }
           
        }
        public void UpdateUserReg(UserRegisterBO regBO)
        {
            try
            {
                register.UpdateUserDetail(regBO);
            }
            catch (Exception ex)
            {
                ex.GetType();
            }
            
        }
    }
}