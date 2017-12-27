using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking_Advisor_bot.Business_objects
{
    public class IncomeSourceBO
    {
        private decimal _bankAccount;
        public decimal bankAccount
        {
            get { return _bankAccount; }
            set { _bankAccount = value; }
        }
        private decimal _jobIncome;
        public decimal jobIncome
        {
            get { return _jobIncome; }
            set { _jobIncome = value; }
        }
        private decimal _rentalIncome;
        public decimal rentalIncome
        {
            get { return _rentalIncome; }
            set { _rentalIncome = value; }
        }
        private decimal _retirementPension;
        public decimal retirementPension
        {
            get { return _retirementPension; }
            set { _retirementPension = value; }
        }
        private decimal _socialSecurity;
        public decimal socialSecurity
        {
            get { return _socialSecurity; }
            set { _socialSecurity = value; }
        }
        private decimal _otherSources;
        public decimal otherSources
        {
            get { return _otherSources; }
            set { _otherSources = value; }
        }

    }
}