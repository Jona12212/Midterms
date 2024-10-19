using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string dept, string uName, string password) : base(name, uName, password)
        {
            this.department = dept;

        }
        public override bool validateLogin(string uName, string password)
        {
            uName = "cashier101";
            password = "password123";

            return user_name.Equals(uName) && user_password.Equals(password);
        }
        public string getDepartment()
        {
            return department = "Finance";
        }
    }
}