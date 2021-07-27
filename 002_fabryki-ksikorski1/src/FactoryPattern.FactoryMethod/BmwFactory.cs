using System;

using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Models;
using FactoryPattern.FactoryMethod.Abstraction;
using FactoryPattern.FactoryMethod.Enumerations;

namespace FactoryPattern.FactoryMethod
{
    public class BmwFactory : ICarFactory
    {
        private static readonly Lazy<BmwFactory> lazyInstance = new Lazy<BmwFactory>(() => new BmwFactory());

        private BmwFactory() { }

        public static BmwFactory Instance
        {
            get { return lazyInstance.Value; }
        }

        public ICar CreateCar(CarType type)
        {
            switch (type)
            {
                case CarType.Suv:
                    return new BmwSuv();
                case CarType.Van:
                    return new BmwVan();
                case CarType.Sedan:
                    return new BmwSedan();
                default:
                    return null;
            }
        }
    }
}
