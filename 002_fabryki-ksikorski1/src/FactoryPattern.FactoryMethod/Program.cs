using System;

using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;
using FactoryPattern.Domain.Extensions;
using FactoryPattern.FactoryMethod.Enumerations;

namespace FactoryPattern.FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var carstore = new CarStore();
            ICar car;

            car = carstore.SellCar(CarProducer.Nissan, CarType.Suv);
            Console.WriteLine(car.GetDescription());

            car = carstore.SellCar(CarProducer.Bmw, CarType.Van);
            Console.WriteLine(car.GetDescription());

            car = carstore.SellCar(CarProducer.Ford, CarType.Sedan);
            Console.WriteLine(car.GetDescription());

            Console.ReadKey();
        }
    }
}
