using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class CargoLockFrame
        : Device<CargoLockFrameTypes>, ICargoLockFrame
    {
        [FieldRemap] public string CargoFrameState { get; set; }
    }

    public interface ICargoLockFrame
        : IDevice
    {
        string CargoFrameState { get; }
    }

    public class CargoLockFrameTypes
    {
    }
}
