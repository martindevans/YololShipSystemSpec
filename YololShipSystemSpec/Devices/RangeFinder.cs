using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class RangeFinder
        : Device<RangeFinderTypes>, IRangeFinder
    {
        [FieldRemap] public string RangeFinderOnState { get; set; }
        [FieldRemap] public string RangeFinderSearchLength { get; set; }
        [FieldRemap] public string RangeFinderDistance { get; set; }
    }

    public interface IRangeFinder
        : IDevice
    {
        string RangeFinderOnState { get; }
        string RangeFinderSearchLength { get; }
        string RangeFinderDistance { get; }
    }

    public class RangeFinderTypes
    {
    }
}
