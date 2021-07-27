using System;

using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Extensions;
using FactoryPattern.Domain.Enumerations;

using FactoryPattern.SimpleFactory.Enumerations;

namespace FactoryPattern.SimpleFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICar car;

            car = CarFactory.Instance.CreateCar(CarProducer.Nissan, BodyType.Suv);
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar(CarProducer.Bmw, BodyType.Suv);
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar(CarProducer.Ford, BodyType.Suv);
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar(CarProducer.Nissan, BodyType.Van);
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar(CarProducer.Bmw, BodyType.Van);
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar(CarProducer.Ford, BodyType.Van);
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar(CarProducer.Nissan, BodyType.Sedan);
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar(CarProducer.Bmw, BodyType.Sedan);
            Console.WriteLine(car.GetDescription());
            car = CarFactory.Instance.CreateCar(CarProducer.Ford, BodyType.Sedan);
            Console.WriteLine(car.GetDescription());

            Console.ReadKey();
        }
	}
}