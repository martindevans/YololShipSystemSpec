using SharpYaml.Serialization;
using YololShipSystemSpec.Attributes;
using YololShipSystemSpec.Devices.RackModules.Chips;

namespace YololShipSystemSpec.Devices
{
    internal class ChipSocket
        : Device<ChipSocketTypes>, IChipSocket
    {
        [FieldRemap] public string ButtonState { get; set; }
        [FieldRemap] public string ButtonOnStateValue { get; set; }
        [FieldRemap] public string ButtonOffStateValue { get; set; }
        [FieldRemap] public string ButtonStyle { get; set; }

        [YamlMember("chip")] public IChip Chip { get; set;}
    }

    public interface IChipSocket
        : IDevice
    {
        string ButtonState { get; }
        string ButtonOnStateValue { get; }
        string ButtonOffStateValue { get; }
        string ButtonStyle { get; }

        IChip Chip { get; }

        ChipSocketTypes TypeOf { get; }
    }

    public class ChipSocketTypes
    {
    }
}
