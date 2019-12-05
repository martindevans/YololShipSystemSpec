using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class RadioTransmitter
        : Device<RadioTransmitterTypes>, IRadioTransmitter
    {
        [FieldRemap] public string TransmitMessage { get; set; }
        [FieldRemap] public string TransmitRange { get; set; }
        [FieldRemap] public string Frequency { get; set; }
    }

    public interface IRadioTransmitter
        : IDevice
    {
        string TransmitMessage { get; }
        string TransmitRange { get; }
        string Frequency { get; }
    }

    public class RadioTransmitterTypes
    {
    }
}
