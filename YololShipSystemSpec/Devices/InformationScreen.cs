using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class InformationScreen
        : Device<InformationScreenTypes>, IInformationScreen
    {
        [FieldRemap] public string InfoScreenContent { get; set; }
    }

    public interface IInformationScreen
        : IDevice
    {
        string InfoScreenContent { get; }
    }

    public class InformationScreenTypes
    {
    }
}
