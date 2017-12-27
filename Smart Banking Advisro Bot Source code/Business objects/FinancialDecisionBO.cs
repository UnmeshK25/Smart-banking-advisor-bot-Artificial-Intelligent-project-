using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking_Advisor_bot.Business_objects
{
    public class FinancialDecisionBO
    {
        private int _targetMonths1;
        public int targetMonths1
        {
            get { return _targetMonths1; }
            set { _targetMonths1 = value; }
        }

        private decimal _interestRate;
        public decimal interestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        private decimal _totalAmountwithInterest;
        public decimal totalAmountwithInterest
        {
            get { return _totalAmountwithInterest; }
            set { _totalAmountwithInterest = value; }
        }

        private decimal _EMIamount;
        public decimal EMIamount
        {
            get { return _EMIamount; }
            set { _EMIamount = value; }
        }

        private decimal _savingDiffPercentage;
        public decimal savingDiffPercentage
        {
            get { return _savingDiffPercentage; }
            set { _savingDiffPercentage = value; }
        }

        private decimal _savingDiffAmount;
        public decimal savingDiffAmount
        {
            get { return _savingDiffAmount; }
            set { _savingDiffAmount = value; }
        }
    }
}