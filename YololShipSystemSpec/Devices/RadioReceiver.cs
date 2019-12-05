using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class RadioReceiver
        : Device<RadioReceiverTypes>, IRadioReceiver
    {
        [FieldRemap] public string Message { get; set; }
        [FieldRemap] public string SignalStrength { get; set; }
        [FieldRemap] public string ListenAngle { get; set; }
        [FieldRemap] public string TargetMessage { get; set; }
        [FieldRemap] public string TargetFrequency { get; set; }
        [FieldRemap] public string Frequency { get; set; }
        [FieldRemap] public string ReceiverPitch { get; set; }
        [FieldRemap] public string ReceiverCurrentPitch { get; set; }
        [FieldRemap] public string MaxRotation { get; set; }
        [FieldRemap] public string MinRotation { get; set; }
        [FieldRemap] public string TargetVelocity { get; set; }
    }

    public interface IRadioReceiver
        : IDevice
    {
        string Message { get; }
        string SignalStrength { get; }
        string ListenAngle { get; }
        string TargetMessage { get; }
        string TargetFrequency { get; }
        string Frequency { get; }
        string ReceiverPitch { get; }
        string ReceiverCurrentPitch { get; }
        string MaxRotation { get; }
        string MinRotation { get; }
        string TargetVelocity { get; }
    }

    public class RadioReceiverTypes
    {
    }
}
