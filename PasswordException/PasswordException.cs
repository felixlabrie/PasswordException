using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordException
{
    class PasswordException : ApplicationException
    {
        private string messageDetails = String.Empty;

        public override string Message
        {
            get
            {
                return "A password error occurred: " + messageDetails;
            }
        }

        public string PasswordRuleIssue = String.Empty;

        public int Strength = 0;

        public PasswordException() { }

        public PasswordException(string message, string pwIssue, int strength) 
        {
            messageDetails = message;
            PasswordRuleIssue = pwIssue;
            Strength = strength;
        }





    }
}
