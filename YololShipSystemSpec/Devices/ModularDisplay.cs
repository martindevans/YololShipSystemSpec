using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class ModularDisplay
        : Device<ModularDisplayTypes>, IModularDisplay
    {
        [FieldRemap] public string PanelValue { get; set; }
    }

    public interface IModularDisplay
        : IDevice
    {
        string PanelValue { get; }
    }

    public class ModularDisplayTypes
    {
    }
}
