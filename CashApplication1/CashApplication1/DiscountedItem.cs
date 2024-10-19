using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double itemDiscount;
        private double paymentAmount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount): base(name, price, quantity)
        {
            itemDiscount = discount;
        }

        // Implement the abstract method to get the total price
        public override double GetTotalPrice()
        {
            // Compute the discounted price
            double discountedPrice = itemPrice * (1 - itemDiscount);
            totalPrice = discountedPrice * itemQuantity;
            return totalPrice;
        }

        // Implement the abstract method to set the payment amount
        public override void SetPayment(double amount)
        {
            paymentAmount = amount;
        }

        // Method to get the change
        public double GetChange()
        {
            change = paymentAmount - totalPrice;
            return change;
        }
    }
}

