using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task3
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void PriceOfCarNotNegativ()
        {
            Assert.Catch(() =>
            {
                var car = new Car("Opel", "100", -3000, "Leder");
            });
        }

        [Test]
        public void ModelNotEmpty()
        {
            Assert.Catch(() =>
            {
                var car = new Car("", "100", 3000, "Leder");
            });
        }

        [Test]
        public void HPNotEmpty()
        {
            Assert.Catch(() =>
            {
                var car = new Car("Opel", "", 3000, "Leder");
            });
        }

        [Test]
        public void PriceValueCorrect()
        {
            var car = new Car("Opel", "120", 3000, "Leder");
            car.UpdatePrice(12000);
            Assert.IsTrue(car.Price == 12000);
        }

        [Test]
        public void PriceOfBikeNotNegativ()
        {
            Assert.Catch(() =>
            {
                var bike = new Bike("Honda", "90", -3000, "Race");
            });
        }

        [Test]
        public void ModelOfBikeNotEmpty()
        {
            Assert.Catch(() =>
            {
                var bike = new Bike("", "100", 3000, "Cross");
            });
        }

        [Test]
        public void HPOfBikeNotEmpty()
        {
            Assert.Catch(() =>
            {
                var bike = new Bike("Opel", "", 3000, "Leder");
            });
        }

        [Test]
        public void PriceValueOfBikeCorrect()
        {
            var bike = new Bike("Opel", "120", 3000, "Leder");
            bike.UpdatePrice(12000);
            Assert.IsTrue(bike.Price == 12000);
        }
    }
}
