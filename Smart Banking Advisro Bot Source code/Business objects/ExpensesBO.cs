using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking_Advisor_bot.Business_objects
{
    public class ExpensesBO
    {
        private decimal _houseRent;
        public decimal houseRent
        {
            get { return _houseRent; }
            set { _houseRent = value; }
        }
        private decimal _utilities;
        public decimal utilities
        {
            get { return _utilities; }
            set { _utilities = value; }

        }
        private decimal _education;
        public decimal education
        {
            get { return _education; }
            set { _education = value; }
        }
        private decimal _health;
        public decimal health
        {
            get { return _health; }
            set { _health = value; }
        }
        private decimal _shopping;
        public decimal shopping
        {
            get { return _shopping; }
            set { _shopping = value; }
        }
        private decimal _transport;
        public decimal transport
        {
            get { return _transport; }
            set { _transport = value; }
        }
        private decimal _entertainment;
        public decimal entertainment
        {
            get { return _entertainment; }
            set { _entertainment = value; }
        }
        private decimal _hotelBill;
        public decimal hotelBill
        {
            get { return _hotelBill; }
            set { _hotelBill = value; }
        }
        private decimal _emiLoans;
        public decimal emiLoans
        {
            get { return _emiLoans; }
            set { _emiLoans = value; }
        }
        private decimal _otherExp;
        public decimal otherExp
        {
            get { return _otherExp; }
            set { _otherExp = value; }
        }
        
    }
}