using FactoryPattern.Domain.Abstraction;
using FactoryPattern.Domain.Enumerations;

namespace FactoryPattern.Domain.Models
{
    public class NissanSuv : ISuv
    {
        public CarProducer Producer { get; set; }
        public double EngineSize { get; set; }
        public int HP { get; set; }
        public EngineType EngineType { get; set; }
        public string Body { get; set; }

        public NissanSuv()
        {
            this.Producer = CarProducer.Nissan;
            this.EngineSize = 3.2;
            this.HP = 160;
            this.EngineType = EngineType.R4;
            this.Body = "Suv";
        }
    }
}
