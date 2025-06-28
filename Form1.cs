using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem() => InitializeComponent();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            double discount = Convert.ToDouble(txtDiscount.Text);
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);

            DiscountedItem discounted = new DiscountedItem(item, price, quantity, discount);
            double totalPrice = discounted.getTotalPrice();

            lblTotalAmount.Text = $"Total Price: {totalPrice}";
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            double discount = Convert.ToDouble(txtDiscount.Text);
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double paymentReceived = Convert.ToDouble(txtpymntReceived.Text);
            DiscountedItem discounted = new DiscountedItem(item, price, quantity, discount);
            discounted.setPayment(paymentReceived);

            lblChange.Text = $"Change: {discounted.getChange()}";

        }

        

        private void exit_Click(object sender, EventArgs e) => Application.Exit();
        private void logout_Click(object sender, EventArgs e)
        {
            frmLoginAccount login = new frmLoginAccount();
            login.Show();
            this.Hide();
        }
    }
}

