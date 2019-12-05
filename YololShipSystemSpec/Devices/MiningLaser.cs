using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class MiningLaser
        : Device<MiningLaserTypes>, IMiningLaser
    {
        [FieldRemap] public string MiningLaserOn { get; set; }
        [FieldRemap] public string MiningLaserBeamLength { get; set; }
    }

    public interface IMiningLaser
        : IDevice
    {
        string MiningLaserOn { get; }
        string MiningLaserBeamLength { get; }
    }

    public class MiningLaserTypes
    {
    }
}
