using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Banking_Advisor_bot.Data_Access_Layer;
using Banking_Advisor_bot.Business_objects;

namespace Banking_Advisor_bot.Business_Access_Layer
{
    public class ExpenseBAL
    {
        ExpensesDAL expense = new ExpensesDAL();
        public void InsertExpense(ExpensesBO expenseB)
        {
            try
            {
                expense.InsertExpenseDetail(expenseB);
            }
            catch (Exception ex)
            {
                ex.GetType();
            }
            
        }
        public void UpdateExpense(ExpensesBO expenseB)
        {
            try
            {
                expense.UpdateExpenseDetail(expenseB);
            }
            catch (Exception ex)
            {
                ex.GetType();
            }
            
        }
    }
}