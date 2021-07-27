using System;

using FactoryPattern.AbstractFactory.Abstraction;
using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Models;

namespace FactoryPattern.AbstractFactory
{
    public class NissanFactory : ICarFactory
    {
        private static readonly Lazy<NissanFactory> lazyInstance = new Lazy<NissanFactory>(() => new NissanFactory());

        private NissanFactory() { }

        public static NissanFactory Instance
        {
            get { return lazyInstance.Value; }
        }

        public ISuv CreateSuv()
        {
            return new NissanSuv();
        }

        public IVan CreateVan()
        {
            return new NissanVan();
        }
        public ISedan CreateSedan()
        {
            return new NissanSedan();
        }
    }
}
