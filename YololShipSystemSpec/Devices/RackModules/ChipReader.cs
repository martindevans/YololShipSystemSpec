using SharpYaml.Serialization;
using YololShipSystemSpec.Devices.RackModules.Chips;

namespace YololShipSystemSpec.Devices.RackModules
{
    internal class ChipReader
        : Device<ChipReaderTypes>, IChipReader
    {
        [YamlMember("slot1")] public IChip Slot1 { get; set; }
    }

    public interface IChipReader
        : IRackModule
    {
        IChip Slot1 { get; }
    }

    public class ChipReaderTypes
    {
    }
}
