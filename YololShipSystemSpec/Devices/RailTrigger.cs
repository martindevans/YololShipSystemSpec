using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class RailTrigger
        : Device<RailTriggerTypes>, IRailTrigger
    {
        [FieldRemap] public string RailTriggerOutput { get; set; }
        [FieldRemap] public string RailTriggerValue { get; set; }
        [FieldRemap] public string RailTriggerReadMover { get; set; }
    }

    public interface IRailTrigger
        : IDevice
    {
        string RailTriggerOutput { get; }
        string RailTriggerValue { get; }
        string RailTriggerReadMover { get; }
    }

    public class RailTriggerTypes
    {
    }
}
