using SharpYaml.Serialization;
using YololShipSystemSpec.Devices.RackModules.Chips;

namespace YololShipSystemSpec.Devices.RackModules
{
    internal class SocketCore
        : Device<SocketCoreTypes>, ISocketCore
    {
        [YamlMember("slot1")] public IChip Slot1 { get; set; }
        [YamlMember("slot2")] public IChip Slot2 { get; set; }
    }

    public interface ISocketCore
        : IRackModule
    {
        IChip Slot1 { get; }
        IChip Slot2 { get; }
    }

    public class SocketCoreTypes
    {
    }
}
