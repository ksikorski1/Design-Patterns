using System;

using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Models;
using FactoryPattern.FactoryMethod.Abstraction;
using FactoryPattern.FactoryMethod.Enumerations;

namespace FactoryPattern.FactoryMethod
{
    public class NissanFactory : ICarFactory
    {
        private static readonly Lazy<NissanFactory> lazyIstance = new Lazy<NissanFactory>(() => new NissanFactory());

        private NissanFactory() { }

        public static NissanFactory Instance
        {
            get { return lazyIstance.Value; }
        }

        public ICar CreateCar(CarType type)
        {
            switch (type)
            {
                case CarType.Suv:
                    return new NissanSuv();
                case CarType.Van:
                    return new NissanVan();
                case CarType.Sedan:
                    return new NissanSedan();
                default:
                    return null;
            }
        }
    }
}
