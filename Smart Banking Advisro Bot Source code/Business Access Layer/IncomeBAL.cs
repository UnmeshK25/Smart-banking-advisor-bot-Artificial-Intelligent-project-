using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Banking_Advisor_bot.Data_Access_Layer;
using Banking_Advisor_bot.Business_objects;

namespace Banking_Advisor_bot.Business_Access_Layer
{
    public class IncomeBAL
    {
        IncomeDAL income = new IncomeDAL();
        public void InsertIncome(IncomeSourceBO incomeB)
        {
            try
            {
               income.InsertIncomeDetail(incomeB);
            }
            catch (Exception ex)
            {
                ex.GetType();
            }
            
        }
        public void UpdateIncome(IncomeSourceBO incomeB)
        {
            try
            {
               income.UpdateIncomeDetail(incomeB);
            }
            catch (Exception ex)
            {
                ex.GetType();
            }
            
        }
    }
}