using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Task3 
{
    class MainClass

    {
        public static void Main(string[] args)
        {
            try
            {
                var cars = new[]
                {
                new Car("Audi", "150", 20000, "leder"),
                new Car("VW", "100", 17000, "synthetik"),
                new Car("opel", "85", 15000, "kunststoff"),
                };

                var bikes = new[]
               {
                new Bike("Honda", "90", 5000, "Race"),
                new Bike("KTM", "45", 2500, "Cross"),
                new Bike("Ducati", "85", 4500, "Race"),
                };

                var vehicle = new Vehicle[]
                    {
                        new Car("Ferrari", "600", 150000, "leder"),
                        new Car("Lamborghini", "680", 180000, "leder"),
                        new Bike("Aprilia", "80", 4000, "Race"),
                        new Bike("BMW", "90", 5000, "Race"),
                    };


                foreach (var x in cars)
                {
                    Console.WriteLine("{0} {1} {2} {3}", x.Model, x.HorsePw, x.Price, x.Interior);
                }

                foreach (var x in bikes)
                {
                    Console.WriteLine("{0} {1} {2} {3}", x.Model, x.HorsePw, x.Price, x.Art);
                }

                bikes[1].fahren(120);
                cars[0].fahren(200);


                //Json Implementierung

                //Serialization using mixed array
                var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
                Console.WriteLine(JsonConvert.SerializeObject(vehicle, settings));

                //File items auf den Desktop
                var text = JsonConvert.SerializeObject(cars);
                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var filename = Path.Combine(desktop, "items.json");
                File.WriteAllText(filename, text);

                var textFromFile = File.ReadAllText(filename);
                var itemsFromFile = JsonConvert.DeserializeObject<Car[]>(text);
                foreach (var x in itemsFromFile) Console.WriteLine($"{x.Model} {x.HorsePw} {x.Price} {x.Interior}");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            
        }
    }
    
}
