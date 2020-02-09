using SharpYaml.Serialization;
using YololShipSystemSpec.Devices.RackModules.Chips;

namespace YololShipSystemSpec.Devices.RackModules
{
    internal class ChipCore
        : Device<ChipCoreTypes>, IChipCore
    {
        [YamlMember("slot1")] public IChip Slot1 { get; set; }
        [YamlMember("slot2")] public IChip Slot2 { get; set; }
        [YamlMember("slot3")] public IChip Slot3 { get; set; }
    }

    public interface IChipCore
        : IRackModule
    {
        IChip Slot1 { get; }
        IChip Slot2 { get; }
        IChip Slot3 { get; }
    }

    public class ChipCoreTypes
    {
    }
}
