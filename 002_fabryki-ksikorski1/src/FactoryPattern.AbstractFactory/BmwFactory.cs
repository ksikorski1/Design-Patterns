using System;

using FactoryPattern.AbstractFactory.Abstraction;
using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Models;

namespace FactoryPattern.AbstractFactory
{
    public class BmwFactory : ICarFactory
    {
        private static readonly Lazy<BmwFactory> lazyInstance = new Lazy<BmwFactory>(() => new BmwFactory());

        private BmwFactory() { }

        public static BmwFactory Instance
        {
            get { return lazyInstance.Value; }
        }

        public ISuv CreateSuv()
        {
            return new BmwSuv();
        }

        public IVan CreateVan()
        {
            return new BmwVan();
        }
        public ISedan CreateSedan()
        {
            return new BmwSedan();
        }
    }
}
