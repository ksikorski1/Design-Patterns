using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;
using FactoryPattern.FactoryMethod.Abstraction;
using FactoryPattern.FactoryMethod.Enumerations;

namespace FactoryPattern.FactoryMethod
{
    public class CarStore
    {
        public ICar SellCar(CarProducer producer, CarType type)
        {
            ICarFactory factory = null;
            if (producer == CarProducer.Nissan)
            {
                factory = NissanFactory.Instance;
            }
            else if (producer == CarProducer.Bmw)
            {
                factory = BmwFactory.Instance;
            }
            else if (producer == CarProducer.Ford)
            {
                factory = FordFactory.Instance;
            }
            return factory?.CreateCar(type);
        }
    }
}
