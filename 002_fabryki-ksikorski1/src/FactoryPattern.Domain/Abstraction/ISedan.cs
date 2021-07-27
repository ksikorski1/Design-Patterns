using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Abstraction
{
    public interface ISedan : ICar
    {
        string Body { get; set; }
    }
}
