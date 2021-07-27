using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Models
{
    public class NissanSedan : ISedan
    {
        public CarProducer Producer { get; set; }
        public double EngineSize { get; set; }
        public int HP { get; set; }
        public EngineType EngineType { get; set; }
        public string Body { get; set; }

        public NissanSedan()
        {
            this.Producer = CarProducer.Nissan;
            this.EngineSize = 2.8;
            this.HP = 450;
            this.EngineType = EngineType.V6;
            this.Body = "Sedan";
        }
    }
}
