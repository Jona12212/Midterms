using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    //abstract base class
    public abstract class Item
    {
        //protected fields 
        protected string itemName;
        protected double itemPrice;
        protected int itemQuantity;
        protected double totalPrice;

        //constructor
        public Item(string name, double price, int quantity)
        {
            itemName = name;
            itemPrice = price;
            itemQuantity = quantity;
        }

        // Abstract method for getting the total price
        public abstract double GetTotalPrice();

        // Abstract method for setting the payment amount
        public abstract void SetPayment(double amount);
    }
}

