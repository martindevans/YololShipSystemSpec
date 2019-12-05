using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class Generator
        : Device<GeneratorTypes>, IGenerator
    {
        [FieldRemap] public string FuelChamberFuel { get; }
        [FieldRemap] public string FuelChamberMaxFuel { get; }
        [FieldRemap] public string FuelChamberUnitRateLimit { get; }
        [FieldRemap] public string FuelChamberUnitRate { get; }
        [FieldRemap] public string GeneratorUnitRateLimit { get; }
        [FieldRemap] public string GeneratorUnitRate { get; }
        [FieldRemap] public string StoredCoolant { get; }
        [FieldRemap] public string MaxCoolant { get; }
        [FieldRemap] public string CoolerUnitRateLimit { get; }
        [FieldRemap] public string CoolerUnitRate { get; }
        [FieldRemap] public string SocketUnitRateLimit { get; }
        [FieldRemap] public string SocketUnitRate { get; }
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
