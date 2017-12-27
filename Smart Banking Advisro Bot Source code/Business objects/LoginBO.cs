using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking_Advisor_bot.Business_objects
{
    public class LoginBO
    {
        private string _userName;
        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }
      
        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}