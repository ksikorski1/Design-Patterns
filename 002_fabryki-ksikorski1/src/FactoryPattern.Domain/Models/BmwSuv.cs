using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Models
{
    public class BmwSuv : ISuv
    {
        public CarProducer Producer { get; set; }
        public double EngineSize { get; set; }
        public int HP { get; set; }
        public EngineType EngineType { get; set; }
        public string Body { get; set; }


        public BmwSuv()
        {
            this.Producer = CarProducer.Bmw;
            this.EngineSize = 3.6;
            this.HP = 240;
            this.EngineType = EngineType.V6;
            this.Body = "Suv";
        }
    }
}
