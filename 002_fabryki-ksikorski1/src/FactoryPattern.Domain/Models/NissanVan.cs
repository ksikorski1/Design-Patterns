using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Models
{
    public class NissanVan : IVan
    {
        public CarProducer Producer { get; set; }
        public double EngineSize { get; set; }
        public int HP { get; set; }
        public EngineType EngineType { get; set; }
        public string Body { get; set; }

        public NissanVan()
        {
            this.Producer = CarProducer.Nissan;
            this.EngineSize = 5.2;
            this.HP = 360;
            this.EngineType = EngineType.V8;
            this.Body = "Van";


        }
    }
}
