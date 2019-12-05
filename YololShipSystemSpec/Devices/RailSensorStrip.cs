using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class RailSensorStrip
        : Device<RailSensorStripTypes>, IRailSensorStrip
    {
        [FieldRemap] public string RailSensorOutput { get; set; }
        [FieldRemap] public string RailSensorDelta { get; set; }
        [FieldRemap] public string RailSensorMoverFilter { get; set; }
    }

    public interface IRailSensorStrip
        : IDevice
    {
        string RailSensorOutput { get; }
        string RailSensorDelta { get; }
        string RailSensorMoverFilter { get; }
    }

    public class RailSensorStripTypes
    {
    }
}
