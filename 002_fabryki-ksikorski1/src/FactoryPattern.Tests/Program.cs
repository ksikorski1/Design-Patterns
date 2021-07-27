using System;
using System.Diagnostics;

using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Models;
using FactoryPattern.Domain.Enumerations;
using FactoryPattern.FactoryMethod.Enumerations;
using FactoryPattern.SimpleFactory.Enumerations;

namespace FactoryPattern.Tests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICar car = null;
            var stopwatch = new Stopwatch();

            // ====== FactoryMethod ========

            stopwatch.Start();

            for (int i = 0; i < 1_000_0000; i++)
            {
                car = FactoryMethod.NissanFactory.Instance.CreateCar(CarType.Suv);
                car = FactoryMethod.NissanFactory.Instance.CreateCar(CarType.Van);
                car = FactoryMethod.NissanFactory.Instance.CreateCar(CarType.Sedan);
                car = FactoryMethod.FordFactory.Instance.CreateCar(CarType.Suv);
                car = FactoryMethod.FordFactory.Instance.CreateCar(CarType.Van);
                car = FactoryMethod.FordFactory.Instance.CreateCar(CarType.Sedan);
                car = FactoryMethod.BmwFactory.Instance.CreateCar(CarType.Suv);
                car = FactoryMethod.BmwFactory.Instance.CreateCar(CarType.Van);
                car = FactoryMethod.BmwFactory.Instance.CreateCar(CarType.Sedan);
            }

            stopwatch.Stop();
            Console.WriteLine($"Number of ticks for FactoryMethod: {stopwatch.ElapsedTicks}");

            stopwatch.Reset();

            // ====== AbstractFactory ======

            stopwatch.Start();

            for (int i = 0; i < 1_000_0000; i++)
            {
                car = AbstractFactory.NissanFactory.Instance.CreateSuv();
                car = AbstractFactory.NissanFactory.Instance.CreateVan();
                car = AbstractFactory.NissanFactory.Instance.CreateSedan();
                car = AbstractFactory.FordFactory.Instance.CreateSuv();
                car = AbstractFactory.FordFactory.Instance.CreateVan();
                car = AbstractFactory.FordFactory.Instance.CreateSedan();
                car = AbstractFactory.BmwFactory.Instance.CreateSuv();
                car = AbstractFactory.BmwFactory.Instance.CreateVan();
                car = AbstractFactory.BmwFactory.Instance.CreateSedan();
            }

            stopwatch.Stop();
            Console.WriteLine($"Number of ticks for AbstractFactory: {stopwatch.ElapsedTicks}");

            stopwatch.Reset();

            // ====== Reflection ===========

            ReflectionSolution.CarFactory.Instance.RegisterAllCars();
            stopwatch.Start();

            for (int i = 0; i < 1_000_0000; i++)
            {
                car = ReflectionSolution.CarFactory.Instance.CreateCar(nameof(NissanSuv));
                car = ReflectionSolution.CarFactory.Instance.CreateCar(nameof(NissanVan));
                car = ReflectionSolution.CarFactory.Instance.CreateCar(nameof(NissanSedan));
                car = ReflectionSolution.CarFactory.Instance.CreateCar(nameof(BmwSuv));
                car = ReflectionSolution.CarFactory.Instance.CreateCar(nameof(BmwVan));
                car = ReflectionSolution.CarFactory.Instance.CreateCar(nameof(BmwSedan));
                car = ReflectionSolution.CarFactory.Instance.CreateCar(nameof(FordSuv));
                car = ReflectionSolution.CarFactory.Instance.CreateCar(nameof(FordVan));
                car = ReflectionSolution.CarFactory.Instance.CreateCar(nameof(FordSedan));
            }

            stopwatch.Stop();
            Console.WriteLine($"Number of ticks for Reflection solution: {stopwatch.ElapsedTicks}");

            stopwatch.Reset();

            // ====== Generic ==============

            stopwatch.Start();

            for (int i = 0; i < 1_000_0000; i++)
            {
                car = GenericSolution.CarFactory.Instance.CreateCar<NissanSuv>();
                car = GenericSolution.CarFactory.Instance.CreateCar<NissanVan>();
                car = GenericSolution.CarFactory.Instance.CreateCar<NissanSedan>();
                car = GenericSolution.CarFactory.Instance.CreateCar<BmwSuv>();
                car = GenericSolution.CarFactory.Instance.CreateCar<BmwVan>();
                car = GenericSolution.CarFactory.Instance.CreateCar<BmwSedan>();
                car = GenericSolution.CarFactory.Instance.CreateCar<FordSuv>();
                car = GenericSolution.CarFactory.Instance.CreateCar<FordVan>();
                car = GenericSolution.CarFactory.Instance.CreateCar<FordSedan>();
            }

            stopwatch.Stop();
            Console.WriteLine($"Number of ticks for Generic solution: {stopwatch.ElapsedTicks}");

            stopwatch.Reset();

            // ====== Generic ==============

            stopwatch.Start();

            for (int i = 0; i < 1_000_0000; i++)
            {
                car = SimpleFactory.CarFactory.Instance.CreateCar(CarProducer.Nissan, BodyType.Suv);
                car = SimpleFactory.CarFactory.Instance.CreateCar(CarProducer.Nissan, BodyType.Van);
                car = SimpleFactory.CarFactory.Instance.CreateCar(CarProducer.Nissan, BodyType.Sedan);
                car = SimpleFactory.CarFactory.Instance.CreateCar(CarProducer.Bmw, BodyType.Suv);
                car = SimpleFactory.CarFactory.Instance.CreateCar(CarProducer.Bmw, BodyType.Van);
                car = SimpleFactory.CarFactory.Instance.CreateCar(CarProducer.Bmw, BodyType.Sedan);
                car = SimpleFactory.CarFactory.Instance.CreateCar(CarProducer.Ford, BodyType.Suv);
                car = SimpleFactory.CarFactory.Instance.CreateCar(CarProducer.Ford, BodyType.Van);
                car = SimpleFactory.CarFactory.Instance.CreateCar(CarProducer.Ford, BodyType.Sedan);
            }

            stopwatch.Stop();
            Console.WriteLine($"Number of ticks for Simple solution: {stopwatch.ElapsedTicks}");

            Console.ReadKey();
        }
    }
}
