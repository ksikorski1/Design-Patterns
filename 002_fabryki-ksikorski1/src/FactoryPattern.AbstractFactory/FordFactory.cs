using System;

using FactoryPattern.AbstractFactory.Abstraction;
using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Models;

namespace FactoryPattern.AbstractFactory
{
    public class FordFactory : ICarFactory
    {
        private static readonly Lazy<FordFactory> lazyInstance = new Lazy<FordFactory>(() => new FordFactory());

        private FordFactory() { }

        public static FordFactory Instance
        {
            get { return lazyInstance.Value; }
        }

        public ISuv CreateSuv()
        {
            return new FordSuv();
        }

        public IVan CreateVan()
        {
            return new FordVan();
        }
        public ISedan CreateSedan()
        {
            return new FordSedan();
        }
    }
}
