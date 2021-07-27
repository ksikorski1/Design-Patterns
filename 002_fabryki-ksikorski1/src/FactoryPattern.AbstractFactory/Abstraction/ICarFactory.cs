using FactoryPattern.Domain.Abstraction;

namespace FactoryPattern.AbstractFactory.Abstraction
{
    public interface ICarFactory
    {
        ISuv CreateSuv();
        IVan CreateVan();
        ISedan CreateSedan();
    }
}
