using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Abstraction
{
    public interface ISuv : ICar 
    {
        string Body { get; set; }
    }
}
