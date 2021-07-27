using System;

using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;
using FactoryPattern.Domain.Models;
using FactoryPattern.SimpleFactory.Enumerations;

namespace FactoryPattern.SimpleFactory
{

    public class CarFactory
    {
        private static readonly Lazy<CarFactory> lazyInstance = new Lazy<CarFactory>(() => new CarFactory());

        private CarFactory() { }

        public static CarFactory Instance
        {
            get { return lazyInstance.Value; }
        }

        public ICar CreateCar(CarProducer producer, BodyType type)
        {
            switch (producer)
            {
                case CarProducer.Nissan:
                    if (type == BodyType.Suv)
                    {
                        return new NissanSuv();
                    }
                    else if (type == BodyType.Van)
                    {
                        return new NissanVan();
                    }
                    else if (type == BodyType.Sedan)
                    {
                        return new NissanSedan();
                    }
                    else
                    {
                        return null;
                    }
                case CarProducer.Bmw:
                    if (type == BodyType.Suv)
                    {
                        return new BmwSuv();
                    }
                    else if (type == BodyType.Van)
                    {
                        return new BmwVan();
                    }
                    else if (type == BodyType.Sedan)
                    {
                        return new BmwSedan();
                    }
                    else
                    {
                        return null;
                    }
                case CarProducer.Ford:
                    if (type == BodyType.Suv)
                    {
                        return new FordSuv();
                    }
                    else if (type == BodyType.Van)
                    {
                        return new FordVan();
                    }
                    else if (type == BodyType.Sedan)
                    {
                        return new FordSedan();
                    }
                    else
                    {
                        return null;
                    }
                default:
                    return null;
            }
        }
    }
}