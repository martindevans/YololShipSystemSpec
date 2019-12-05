using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class Hinge
        : Device<HingeTypes>, IHinge
    {
        [FieldRemap] public string DoorOpenState { get; set; }
        [FieldRemap] public string DoorCurrentState { get; set; }
        [FieldRemap] public string EndRotation { get; set; }
        [FieldRemap] public string StartRotation { get; set; }
        [FieldRemap] public string TargetVelocity { get; set; }
    }

    public interface IHinge
        : IDevice
    {
        string DoorOpenState { get; }
        string DoorCurrentState { get; }
        string EndRotation { get; }
        string StartRotation { get; }
        string TargetVelocity { get; }
    }

    public class HingeTypes
    {
    }

    internal class Prismatic
        : Device<PrismaticTypes>, IPrismatic
    {
        [FieldRemap] public string DoorOpenState { get; set; }
        [FieldRemap] public string DoorCurrentState { get; set; }
        [FieldRemap] public string EndPosition { get; set; }
        [FieldRemap] public string StartPosition { get; set; }
        [FieldRemap] public string TargetVelocity { get; set; }
    }

    public interface IPrismatic
        : IDevice
    {
        string DoorOpenState { get; }
        string DoorCurrentState { get; }
        string EndPosition { get; }
        string StartPosition { get; }
        string TargetVelocity { get; }
    }

    public class PrismaticTypes
    {
    }
}
