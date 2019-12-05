using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class Lever
        : Device<LeverTypes>, ILever
    {
        [FieldRemap] public string LeverState { get; set; }
        [FieldRemap] public string LeverMinOutput { get; set; }
        [FieldRemap] public string LeverMaxOutput { get; set; }
        [FieldRemap] public string LeverCenterOutput { get; set; }
        [FieldRemap] public string LeverCenterDeadZone { get; set; }
        [FieldRemap] public string LeverCenteringSpeed { get; set; }
        [FieldRemap] public string LeverBindsMoveSpeed { get; set; }
    }

    public interface ILever
        : IDevice
    {
        string LeverState { get; }
        string LeverMinOutput { get; }
        string LeverMaxOutput { get; }
        string LeverCenterOutput { get; }
        string LeverCenterDeadZone { get; }
        string LeverCenteringSpeed { get; }
        string LeverBindsMoveSpeed { get; }
    }

    public class LeverTypes
    {
    }
}
