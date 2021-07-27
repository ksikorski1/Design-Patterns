using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Models
{
    public class FordSedan : ISedan
    {
        public CarProducer Producer { get; set; }
        public double EngineSize { get; set; }
        public int HP { get; set; }
        public EngineType EngineType { get; set; }
        public string Body { get; set; }

        public FordSedan()
        {
            this.Producer = CarProducer.Ford;
            this.EngineSize = 1.8;
            this.HP = 110;
            this.EngineType = EngineType.R4;
            this.Body = "Sedan";
        }
    }
}
