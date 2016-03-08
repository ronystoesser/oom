using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task2
{
    public class Car
    {
        private decimal my_price;

        public Car(string model, string HP, decimal price)
        {
            if (string.IsNullOrEmpty(model)) throw new ArgumentException("Model must not be empty.", nameof(model));
            if (string.IsNullOrEmpty(HP)) throw new ArgumentException("HP must not be empty,", nameof(HP));

            Model = model;
            HorsePw = HP;
            UpdatePrice(price);
        }


        public string Model { get; }

        public string HorsePw { get; }

        public decimal Price
        {
            get
            {
                return my_price;
            }
            private set
            {
                if (Price < 0) throw new Exception("Price must not be negative.");
                my_price = Price;
            }
        }

       

        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0) throw new ArgumentException("Price must not be negative.", nameof(newPrice));
            my_price = newPrice;           
        }
    } 
}
