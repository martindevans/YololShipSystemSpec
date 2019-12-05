using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class CargoBeam
        : Device<CargoBeamTypes>, ICargoBeam
    {
        [FieldRemap] public string CargoBeamOnState { get; set; }
        [FieldRemap] public string CargoBeamSearchLength { get; set; }
    }

    public interface ICargoBeam
        : IDevice
    {
        string CargoBeamOnState { get; }
        string CargoBeamSearchLength { get; }
    }

    public class CargoBeamTypes
    {
    }
}
