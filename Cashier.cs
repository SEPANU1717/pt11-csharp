using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAccount;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserAccount
{
    internal class Cashier : UserAccount
    {
        private string department;
        public Cashier(string name, string uName, string password, string department) : base(name, uName, password)
        {
            this.department = department;
        }
        public new bool ValidateLogin(string uName, string password)
        {
            return uName == this.user_name && password == this.user_password;
        }

        public string getDepartment() => department;
        public override string getFullName(string fullname) => "Mark Manalo";



    }
}
