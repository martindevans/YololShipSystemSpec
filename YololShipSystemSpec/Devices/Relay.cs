using SharpYaml.Serialization;
using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class Relay
        : Device<RelayTypes>, IRelay
    {
        [FieldRemap] public string IsEnabled { get; set; }

        [YamlMember] INetwork src { get; set; }
        [YamlIgnore] INetwork IRelay.Source => src;

        [YamlMember] INetwork dst { get; set; }
        [YamlIgnore] INetwork IRelay.Destination => dst;
    }

    public interface IRelay
        : IDevice
    {
        string IsEnabled { get; }

        INetwork Source { get; }

        INetwork Destination { get; }
    }

    public class RelayTypes
    {
    }
}
