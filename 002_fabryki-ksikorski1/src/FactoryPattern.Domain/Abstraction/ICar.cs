using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Abstraction
{
    public interface ICar
    {
        CarProducer Producer { get; set; }
        double EngineSize { get; set; }
        int HP { get; set; }
        EngineType EngineType { get; set; }
    }
}
