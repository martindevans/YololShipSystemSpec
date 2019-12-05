using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class RailRelay
        : Device<RailRelayTypes>, IRailRelay
    {
        [FieldRemap] public string IsEnabled { get; set; }
    }

    public interface IRailRelay
        : IDevice
    {
        string IsEnabled { get; }
    }

    public class RailRelayTypes
    {
    }
}
