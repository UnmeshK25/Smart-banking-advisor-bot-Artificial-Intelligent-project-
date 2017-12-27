using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking_Advisor_bot.Business_objects
{
    public class UserRegisterBO
    {
        private string _customerName;
        public string customerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        private string _address;
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _contactNumber;
        public string contactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }
        private string _emailID;
        public string emailID
        {
            get { return _emailID; }
            set { _emailID = value; }
        }
    }
}