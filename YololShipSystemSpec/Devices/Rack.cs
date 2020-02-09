using SharpYaml.Serialization;
using YololShipSystemSpec.Attributes;
using YololShipSystemSpec.Devices.RackModules;

namespace YololShipSystemSpec.Devices
{
    internal class Rack
        : Device<RackTypes>, IRack
    {
        [FieldRemap] public string CurrentState { get; set; }
        [FieldRemap] public string OnState { get; set; }
        [FieldRemap] public string OffState { get; set; }
        [FieldRemap] public string ButtonStyle { get; set; }

        [YamlMember("module")] private IRackModule _module;
        [YamlIgnore] public IRackModule Module => _module;
    }

    public interface IRack
        : IDevice
    {
        string CurrentState { get; }
        string OnState { get; }
        string OffState { get; }
        string ButtonStyle { get; }

        IRackModule Module { get; }
    }

    public class RackTypes
    {
    }
}
