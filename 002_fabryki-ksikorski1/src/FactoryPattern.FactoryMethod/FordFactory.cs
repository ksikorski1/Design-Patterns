using System;

using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Models;
using FactoryPattern.FactoryMethod.Abstraction;
using FactoryPattern.FactoryMethod.Enumerations;

namespace FactoryPattern.FactoryMethod
{
    public class FordFactory : ICarFactory
    {
        private static readonly Lazy<FordFactory> lazyInstance = new Lazy<FordFactory>(() => new FordFactory());

        private FordFactory() { }

        public static FordFactory Instance
        {
            get { return lazyInstance.Value; }
        }

        public ICar CreateCar(CarType type)
        {
            switch (type)
            {
                case CarType.Suv:
                    return new FordSuv();
                case CarType.Van:
                    return new FordVan();
                case CarType.Sedan:
                    return new FordSedan();
                default:
                    return null;
            }
        }
    }
}
