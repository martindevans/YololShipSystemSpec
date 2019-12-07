using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices.RackModules
{
    internal class ChipReader
        : Device<ChipReaderTypes>, IChipReader
    {
        [FieldRemap] public string Script { get; set; }
    }

    public interface IChipReader
        : IRackModule
    {
        string Script { get; }
    }

    public class ChipReaderTypes
    {
    }
}
