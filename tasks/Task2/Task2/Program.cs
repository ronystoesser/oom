using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var cars = new[]
            {
                //objects
                new Car("Audi", "150", 20000),
                new Car("VW", "100", 17000),
                new Car("opel", "85", 15000),
            };

            foreach (var x in cars)
            {
                Console.WriteLine("{0} {1} {2}", x.Model, x.HorsePw, x.Price);
            }
        }
    }
}
