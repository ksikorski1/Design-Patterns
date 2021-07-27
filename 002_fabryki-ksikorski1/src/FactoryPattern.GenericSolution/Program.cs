using System;

using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Extensions;
using FactoryPattern.Domain.Models;

namespace FactoryPattern.GenericSolution
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICar car;

            car = CarFactory.Instance.CreateCar<NissanSuv>();
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar<NissanVan>();
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar<NissanSedan>();
            Console.WriteLine(car.GetDescription());

            car = CarFactory.Instance.CreateCar<BmwSuv>();
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar<BmwVan>();
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar<BmwSedan>();
            Console.WriteLine(car.GetDescription());

            car = CarFactory.Instance.CreateCar<FordSuv>();
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar<FordVan>();
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar<FordSedan>();
            Console.WriteLine(car.GetDescription());


            Console.ReadKey();
        }
    }
}
