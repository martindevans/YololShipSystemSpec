using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class FlightControlUnit
        : Device<FlightControlUnitTypes>, IFlightControlUnit
    {
        [FieldRemap] public string FcuMfcIO { get; set; }
        [FieldRemap] public string FcuGeneralMultiplier { get; set; }
        [FieldRemap] public string FcuForward { get; set; }
        [FieldRemap] public string FcuBackward { get; set; }
        [FieldRemap] public string FcuRotationalPitch { get; set; }
        [FieldRemap] public string FcuRotationalYaw { get; set; }
        [FieldRemap] public string FcuRotationalRoll { get; set; }
        [FieldRemap] public string FcuUpDown { get; set; }
        [FieldRemap] public string FcuRightLeft { get; set; }
        [FieldRemap] public string FcuFwdBwdPitch { get; set; }
        [FieldRemap] public string FcuFwdBwdYaw { get; set; }
        [FieldRemap] public string FcuFwdBwdRoll { get; set; }
    }

    public interface IFlightControlUnit
        : IDevice
    {
        string FcuMfcIO { get; }
        string FcuGeneralMultiplier { get; }
        string FcuForward { get; }
        string FcuBackward { get; }
        string FcuRotationalPitch { get; }
        string FcuRotationalYaw { get; }
        string FcuRotationalRoll { get; }
        string FcuUpDown { get; }
        string FcuRightLeft { get; }
        string FcuFwdBwdPitch { get; }
        string FcuFwdBwdYaw { get; }
        string FcuFwdBwdRoll { get; }
    }

    public class FlightControlUnitTypes
    {
    }
}
