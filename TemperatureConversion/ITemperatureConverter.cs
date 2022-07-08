using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion
{
    public interface ITemperatureConverter
    {
        ITemperatureConverter From(TemperatureSystem from);
        ITemperatureConverter To(TemperatureSystem to);
        double Convert(double degrees);
        Temperature Convert(Temperature temperature, TemperatureSystem to);
        double Convert(TemperatureSystem from, TemperatureSystem to, double degrees);
    }
}
