using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Bike : Vehicle
    {
        public Bike(string model, string HP, decimal price, string art) : base(model, HP, price)
        {

            Art = art;

        }

        public string Art { get; set; }


    }
}