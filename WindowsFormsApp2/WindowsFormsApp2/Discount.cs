using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public class Discount : Item
    {
        // Fields for DiscountedItem
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        // Constructor
        public Discount(string name, double price, int quantity, double discount)
            : base(name, price, quantity) // Calls the base class constructor
        {
            this.item_discount = discount;
        }

        // Method to calculate and return total price after applying discount
        public override double getTotalPrice()
        {
            double discountFactor = item_discount * 0.01;  // Convert discount to percentage
            discounted_price = item_price * (1 - discountFactor);  // Calculate the discounted price
            return discounted_price * item_quantity;  // Return total price after applying discount
        }

        // Method to set payment and compute change
        public override void setPayment(double amount)
        {
            payment_amount = amount;
            change = payment_amount - getTotalPrice();  // Compute change based on total price
        }

        // Method to get the change
        public double getChange()
        {
            return change;
        }
    }
}