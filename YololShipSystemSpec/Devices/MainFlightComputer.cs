using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class MainFlightComputer
        : Device<MainFlightComputerTypes>, IMainFlightComputer
    {
        [FieldRemap] public string FcuMfcIO1 { get; set; }
        [FieldRemap] public string FcuMfcIO2 { get; set; }

        [FieldRemap] public string ThrusterPowerLevel01 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel02 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel03 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel04 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel05 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel06 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel07 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel08 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel09 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel10 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel11 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel12 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel13 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel14 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel15 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel16 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel17 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel18 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel19 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel20 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel21 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel22 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel23 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel24 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel25 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel26 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel27 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel28 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel29 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel30 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel31 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel32 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel33 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel34 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel35 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel36 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel37 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel38 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel39 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel40 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel41 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel42 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel43 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel44 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel45 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel46 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel47 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel48 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel49 { get; set; }
        [FieldRemap] public string ThrusterPowerLevel50 { get; set; }
    }

    public interface IMainFlightComputer
        : IDevice
    {
        string FcuMfcIO1 { get; }
        string FcuMfcIO2 { get; }

        string ThrusterPowerLevel01 { get; }
        string ThrusterPowerLevel02 { get; }
        string ThrusterPowerLevel03 { get; }
        string ThrusterPowerLevel04 { get; }
        string ThrusterPowerLevel05 { get; }
        string ThrusterPowerLevel06 { get; }
        string ThrusterPowerLevel07 { get; }
        string ThrusterPowerLevel08 { get; }
        string ThrusterPowerLevel09 { get; }
        string ThrusterPowerLevel10 { get; }
        string ThrusterPowerLevel11 { get; }
        string ThrusterPowerLevel12 { get; }
        string ThrusterPowerLevel13 { get; }
        string ThrusterPowerLevel14 { get; }
        string ThrusterPowerLevel15 { get; }
        string ThrusterPowerLevel16 { get; }
        string ThrusterPowerLevel17 { get; }
        string ThrusterPowerLevel18 { get; }
        string ThrusterPowerLevel19 { get; }
        string ThrusterPowerLevel20 { get; }
        string ThrusterPowerLevel21 { get; }
        string ThrusterPowerLevel22 { get; }
        string ThrusterPowerLevel23 { get; }
        string ThrusterPowerLevel24 { get; }
        string ThrusterPowerLevel25 { get; }
        string ThrusterPowerLevel26 { get; }
        string ThrusterPowerLevel27 { get; }
        string ThrusterPowerLevel28 { get; }
        string ThrusterPowerLevel29 { get; }
        string ThrusterPowerLevel30 { get; }
        string ThrusterPowerLevel31 { get; }
        string ThrusterPowerLevel32 { get; }
        string ThrusterPowerLevel33 { get; }
        string ThrusterPowerLevel34 { get; }
        string ThrusterPowerLevel35 { get; }
        string ThrusterPowerLevel36 { get; }
        string ThrusterPowerLevel37 { get; }
        string ThrusterPowerLevel38 { get; }
        string ThrusterPowerLevel39 { get; }
        string ThrusterPowerLevel40 { get; }
        string ThrusterPowerLevel41 { get; }
        string ThrusterPowerLevel42 { get; }
        string ThrusterPowerLevel43 { get; }
        string ThrusterPowerLevel44 { get; }
        string ThrusterPowerLevel45 { get; }
        string ThrusterPowerLevel46 { get; }
        string ThrusterPowerLevel47 { get; }
        string ThrusterPowerLevel48 { get; }
        string ThrusterPowerLevel49 { get; }
        string ThrusterPowerLevel50 { get; }
    }

    public class MainFlightComputerTypes
    {
    }
}
