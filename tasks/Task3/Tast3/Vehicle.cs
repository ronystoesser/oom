using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task3
{
    public class Vehicle : IControl
    {
        private decimal my_price;

        public void fahren(int velocity)         //Interface Implementierung (Methode)
        {
            Console.WriteLine("{0} faehrt mit {1} km/h", Model, velocity);
        }

        [JsonConstructor]
        //Constructor
        public Vehicle(string model, string HP, decimal price)
        {
            if (string.IsNullOrEmpty(model)) throw new ArgumentException("Model must not be empty.", nameof(model));
            if (string.IsNullOrEmpty(HP)) throw new ArgumentException("HP must not be empty,", nameof(HP));

            Model = model;
            HorsePw = HP;
            UpdatePrice(price);
        }


        public string Model { get; }    //Autoproperties

        public string HorsePw { get; }

        //Property
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

        //methode
         public void UpdatePrice(decimal newPrice)
       {
           if (newPrice < 0) throw new ArgumentException("Price must not be negative.", nameof(newPrice));
           my_price = newPrice;           
       }
    }
}
