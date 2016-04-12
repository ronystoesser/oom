using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3
{
    public class Car : Vehicle
    {
        

        public Car(string model, string HP, decimal price, string interior) : base(model, HP, price)
        {
            
            Interior = interior;
           
        }


        

        public string Interior { get; set; }

       

       /* public void UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0) throw new ArgumentException("Price must not be negative.", nameof(newPrice));
            base.my_price = newPrice;           
        }*/

        //IControl implementation

        

       
    } 
}
