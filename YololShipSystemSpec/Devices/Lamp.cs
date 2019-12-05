using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class Lamp
        : Device<LampTypes>, ILamp
    {
        [FieldRemap] public string LampOn { get; set; }
        [FieldRemap] public string LampLumens { get; set; }
        [FieldRemap] public string LampColorHue { get; set; }
        [FieldRemap] public string LampColorSaturation { get; set; }
        [FieldRemap] public string LampColorValue { get; set; }
        [FieldRemap] public string LampRange { get; set; }
    }

    public interface ILamp
        : IDevice
    {
        string LampOn { get; }
        string LampLumens { get; }
        string LampColorHue { get; }
        string LampColorSaturation { get; }
        string LampColorValue { get; }
        string LampRange { get; }
    }

    public class LampTypes
    {
    }
}
