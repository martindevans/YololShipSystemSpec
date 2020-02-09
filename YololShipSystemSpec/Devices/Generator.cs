using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class Generator
        : Device<GeneratorTypes>, IGenerator
    {
        [FieldRemap] public string FuelChamberFuel { get; set; }
        [FieldRemap] public string FuelChamberMaxFuel { get; set; }
        [FieldRemap] public string FuelChamberUnitRateLimit { get; set; }
        [FieldRemap] public string FuelChamberUnitRate { get; set; }
        [FieldRemap] public string GeneratorUnitRateLimit { get; set; }
        [FieldRemap] public string GeneratorUnitRate { get; set; }
        [FieldRemap] public string StoredCoolant { get; set; }
        [FieldRemap] public string MaxCoolant { get; set; }
        [FieldRemap] public string CoolerUnitRateLimit { get; set; }
        [FieldRemap] public string CoolerUnitRate { get; set; }
        [FieldRemap] public string SocketUnitRateLimit { get; set; }
        [FieldRemap] public string SocketUnitRate { get; set; }
    }

    public interface IGenerator
        : IDevice
    {
        string FuelChamberFuel { get; }
        string FuelChamberMaxFuel { get; }
        string FuelChamberUnitRateLimit { get; }
        string FuelChamberUnitRate { get; }
        string GeneratorUnitRateLimit { get; }
        string GeneratorUnitRate { get; }
        string StoredCoolant { get; }
        string MaxCoolant { get; }
        string CoolerUnitRateLimit { get; }
        string CoolerUnitRate { get; }
        string SocketUnitRateLimit { get; }
        string SocketUnitRate { get; }
    }

    public class GeneratorTypes
    {
    }
}
