using System;

using FactoryPattern.Domain.Abstraction;

namespace FactoryPattern.GenericSolution
{
    public class CarFactory
    {
        private static readonly Lazy<CarFactory> lazyInstance = new Lazy<CarFactory>(() => new CarFactory());

        private CarFactory() { }

        public static CarFactory Instance
        {
            get { return lazyInstance.Value; }
        }

        public T CreateCar<T>()
            where T : ICar, new()
        {
            var car = new T();

            return car;
        }
    }
}
