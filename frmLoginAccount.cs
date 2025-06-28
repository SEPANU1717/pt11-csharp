using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccount;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Cashier cashier = new Cashier(Name, username, password, "Accounting");

                if (username == "Cashier101" && password == "cashier123")
                {
                    string fullName = cashier.getFullName(username);
                    MessageBox.Show($"Welcome {fullName}", "Login Successful", MessageBoxButtons.OK);

                    frmPurchaseDiscountedItem purchase = new frmPurchaseDiscountedItem();
                    purchase.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Error","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
        }
        }
    }

