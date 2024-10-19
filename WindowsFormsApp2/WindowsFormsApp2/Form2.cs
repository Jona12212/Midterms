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
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        string name;
        double price;
        double discount;
        int quantity;
        double change;
        double total_price;
        double total_discount;
        double payment_amount;

        public Form2()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { name = tb_item.Text;

            if (double.TryParse(tb_price.Text, out price) && 
                double.TryParse(tb_discount.Text, out discount) && 
                int.TryParse(tb_quantity.Text, out quantity))
            {
                // Correct instantiation based on Discount class constructor
                Discount item = new Discount(name, price, quantity, discount);

                // Get the total price after discount
                total_price = item.getTotalPrice();
                lb_totalAmount.Text = $"Total Amount: {total_price:F2}";
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
        

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_paymentReceived.Text, out payment_amount))
            {
                Discount dis = new Discount(name, price, quantity, discount);

                // Set payment and compute change
                dis.setPayment(payment_amount);

                // Get and display the change
                change = dis.getChange();

                if (payment_amount >= total_price)
                {
                    lb_change.Text = $"Change: {change:F2}";  // Show change in Label
                }
                else
                {
                    MessageBox.Show("Payment is less than the total price.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for payment amount.");
            }

        }
    }
}
