using System;
using System.Collections.Generic;
using System.Linq;

using FactoryPattern.Domain.Abstraction;

namespace FactoryPattern.ReflectionSolution
{
    public class CarFactory
    {
        private readonly Dictionary<string, Type> registeredCars = new Dictionary<string, Type>();
        private static readonly Lazy<CarFactory> lazyInstance = new Lazy<CarFactory>(() => new CarFactory());

        private CarFactory() { }

        public static CarFactory Instance
        {
            get { return lazyInstance.Value; }
        }

        public void RegisterCar(string carId, Type carType)
        {
            this.registeredCars.Add(carId, carType);
        }

        public void RegisterAllCars()
        {
            Type interfaceType = typeof(ICar);
            IEnumerable<Type> types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass);

            foreach (Type type in types)
                Instance.RegisterCar(type.Name, type);
        }

        public ICar CreateCar(string carId)
        {
            ICar car = this.registeredCars.TryGetValue(carId, out Type carType)
                ? (ICar)Activator.CreateInstance(carType)
                : null;

            return car;
        }
    }
}
