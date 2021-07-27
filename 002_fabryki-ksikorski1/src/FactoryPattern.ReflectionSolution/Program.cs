using System;

using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Extensions;
using FactoryPattern.Domain.Models;

namespace FactoryPattern.ReflectionSolution
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarFactory.Instance.RegisterAllCars();

            ICar car;

            car = CarFactory.Instance.CreateCar(nameof(NissanSuv));
            Console.WriteLine(car.GetDescription());

            Console.ReadKey();
        }
    }
}
