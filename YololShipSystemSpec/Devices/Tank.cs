using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class Tank
        : Device<TankTypes>, ITank
    {
        [FieldRemap] public string GasContainerStoredResource { get; set; }
        [FieldRemap] public string GasContainerMaxResource { get; set; }
        [FieldRemap] public string IsOpenId { get; set; }
        [FieldRemap] public string FlowId { get; set; }
    }

    public interface ITank
        : IDevice
    {
        string GasContainerStoredResource { get; }
        string GasContainerMaxResource { get; }
        string IsOpenId { get; }
        string FlowId { get; }
    }

    public class TankTypes
    {
    }
}
