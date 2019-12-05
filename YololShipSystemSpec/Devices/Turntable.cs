using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class Turntable
        : Device<TurntableTypes>, ITurntable
    {
        [FieldRemap] public string TurretRotation { get; set; }
        [FieldRemap] public string TurretCurrentRotation { get; set; }
        [FieldRemap] public string MaxRotation { get; set; }
        [FieldRemap] public string MinRotation { get; set; }
        [FieldRemap] public string TargetVelocity { get; set; }
    }

    public interface ITurntable
        : IDevice
    {
        string TurretRotation { get; }
        string TurretCurrentRotation { get; }
        string MaxRotation { get; }
        string MinRotation { get; }
        string TargetVelocity { get; }
    }

    public class TurntableTypes
    {
    }
}
