using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class FixedMount
        : Device<FixedMountTypes>, IFixedMount
    {
        [FieldRemap] public string CurrentState { get; set; }
        [FieldRemap] public string OnState { get; set; }
        [FieldRemap] public string OffState { get; set; }
        [FieldRemap] public string ButtonStyle { get; set; }
    }

    public interface IFixedMount
        : IDevice
    {
        string CurrentState { get; }
        string OnState { get; }
        string OffState { get; }
        string ButtonStyle { get; }
    }

    public class FixedMountTypes
    {
    }
}
