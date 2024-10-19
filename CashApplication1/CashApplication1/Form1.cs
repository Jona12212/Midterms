using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashApplication1
{
    public partial class Form1 : Form
    {
        private DiscountedItem currentItem;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve input values
            string itemName = tb_item.Text;
            double price = Convert.ToDouble(tb_price.Text);
            double discount = Convert.ToDouble(tb_discount.Text) * 0.01; // Convert discount to double
            int quantity = Convert.ToInt32(tb_quantity.Text);

            // Create a DiscountedItem object
            currentItem = new DiscountedItem(itemName, price, quantity, discount);

            // Compute the total amount
            double totalAmount = currentItem.GetTotalPrice();
            lb_totalAmount.Text = $"Total Amount: {totalAmount}";
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (currentItem == null)
            {
                MessageBox.Show("Please compute the total amount first.");
                return;
            }

            // Get the payment amount
            double payment = Convert.ToDouble(tb_paymentReceived.Text);
            currentItem.SetPayment(payment);

            // Compute and display change
            double change = currentItem.GetChange();
            lb_change.Text = $"Change: {change}";
        }
    }
}
