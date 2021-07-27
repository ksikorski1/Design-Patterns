using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Models
{
    public class BmwVan : IVan
    {
        public CarProducer Producer { get; set; }
        public double EngineSize { get; set; }
        public int HP { get; set; }
        public EngineType EngineType { get; set; }
        public string Body { get; set; }

        public BmwVan()
        {
            this.Producer = CarProducer.Bmw;
            this.EngineSize = 1.4;
            this.HP = 130;
            this.EngineType = EngineType.R4;
            this.Body = "Van";
        }
    }
}
