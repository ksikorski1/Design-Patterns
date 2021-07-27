using FactoryPattern.Domain.Abstraction;
using FactoryPattern.FactoryMethod.Enumerations;

namespace FactoryPattern.FactoryMethod.Abstraction
{
    public interface ICarFactory
    {
        ICar CreateCar(CarType brand);
    }
}
