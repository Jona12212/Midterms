using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;

        }
        // Method to validate credentials
        public abstract bool validateLogin(string uName, string password);

        public string getFullname()
        {
            return full_name = "Clarisa Castro";
        }
    }
}
