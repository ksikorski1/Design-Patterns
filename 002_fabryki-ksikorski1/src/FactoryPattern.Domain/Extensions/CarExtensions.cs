using FactoryPattern.Domain.Abstraction;

namespace FactoryPattern.Domain.Extensions
{
    public static class CarExtensions
    {
        public static string GetDescription(this ICar car)
        {
            string description = $"producer {car.Producer}: engine size {car.EngineSize}, HP {car.HP}, engine type {car.EngineType}";

            if (car is ISuv suv)
            {
                description += $", body: {suv.Body}";
            }
            if (car is IVan van)
            {
                description += $", body: {van.Body}";
            }
            if (car is ISedan sedan)
            {
                description += $", body: {sedan.Body}";
            }

            return description;
        }
    }
}
