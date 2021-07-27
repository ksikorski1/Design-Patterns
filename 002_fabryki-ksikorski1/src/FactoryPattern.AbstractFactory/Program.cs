using System;

using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Extensions;

namespace FactoryPattern.AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ISuv Suv;
            IVan Van;
            ISedan Sedan;

            Suv = NissanFactory.Instance.CreateSuv();
            Console.WriteLine(Suv.GetDescription());
            Suv = BmwFactory.Instance.CreateSuv();
            Console.WriteLine(Suv.GetDescription());
            Suv = FordFactory.Instance.CreateSuv();
            Console.WriteLine(Suv.GetDescription());

            Van = NissanFactory.Instance.CreateVan();
            Console.WriteLine(Van.GetDescription());
            Van = BmwFactory.Instance.CreateVan();
            Console.WriteLine(Van.GetDescription());
            Van = FordFactory.Instance.CreateVan();
            Console.WriteLine(Van.GetDescription());

            Sedan = NissanFactory.Instance.CreateSedan();
            Console.WriteLine(Sedan.GetDescription());
            Sedan = BmwFactory.Instance.CreateSedan();
            Console.WriteLine(Sedan.GetDescription());
            Sedan = FordFactory.Instance.CreateSedan();
            Console.WriteLine(Sedan.GetDescription());

            Console.ReadKey();
        }
    }
}
