using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Abstraction
{
    public interface IVan : ICar
    {
        string Body { get; set; }
    }
}
