using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices.RackModules
{
    internal class ChipCore
        : Device<ChipCoreTypes>, IChipCore
    {
        [FieldRemap] public string Script0 { get; set; }
        [FieldRemap] public string Script1 { get; set; }
        [FieldRemap] public string Script2 { get; set; }
    }

    public interface IChipCore
        : IRackModule
    {
        string Script0 { get; }
        string Script1 { get; }
        string Script2 { get; }
    }

    public class ChipCoreTypes
    {
    }
}
