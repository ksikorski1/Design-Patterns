using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Models
{
    public class BmwSedan : ISedan
    {
        public CarProducer Producer { get; set; }
        public double EngineSize { get; set; }
        public int HP { get; set; }
        public EngineType EngineType { get; set; }
        public string Body { get; set; }


        public BmwSedan()
        {
            this.Producer = CarProducer.Bmw;
            this.EngineSize = 3.8;
            this.HP = 530;
            this.EngineType = EngineType.V8;
            this.Body = "Sedan";
        }
    }
}
