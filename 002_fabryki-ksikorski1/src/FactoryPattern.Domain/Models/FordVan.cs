using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Models
{
    public class FordVan : IVan
    {
        public CarProducer Producer { get; set; }
        public double EngineSize { get; set; }
        public int HP { get; set; }
        public EngineType EngineType { get; set; }
        public string Body { get; set; }

        public FordVan()
        {
            this.Producer = CarProducer.Ford;
            this.EngineSize = 4.0;
            this.HP = 190;
            this.EngineType = EngineType.V6;
            this.Body = "Van";
        }
    }
}
