using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class Thruster
        : Device<ThrusterTypes>, IThruster
    {
        [FieldRemap] public string ThrusterState { get; set; }
        [FieldRemap] public string ThrusterCurrentThrust { get; set; }
    }

    public interface IThruster
        : IDevice
    {
        string ThrusterState { get; }
        string ThrusterCurrentThrust { get; }
    }

    public class ThrusterTypes
    {
    }
}
