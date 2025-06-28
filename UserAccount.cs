using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserAccount
{
    internal abstract class UserAccount
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

        public bool ValidateLogin(string uName, string password)
        {
            return user_name.Equals(uName, StringComparison.Ordinal)
                   && user_password.Equals(password, StringComparison.Ordinal);
        }

        public abstract string getFullName(string fullname);
    }
}
