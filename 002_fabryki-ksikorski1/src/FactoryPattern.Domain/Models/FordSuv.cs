using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Models
{
    public class FordSuv : ISuv
    {
        public CarProducer Producer { get; set; }
        public double EngineSize { get; set; }
        public int HP { get; set; }
        public EngineType EngineType { get; set; }
        public string Body { get; set; }

        public FordSuv()
        {
            this.Producer = CarProducer.Ford;
            this.EngineSize = 6.2;
            this.HP = 300;
            this.EngineType = EngineType.V8;
            this.Body = "Suv";
        }
    }
}
