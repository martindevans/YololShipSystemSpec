using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices.RackModules.Chips
{
    internal class MemoryChip
        : Device<MemoryChipTypes>, IMemoryChip
    {
        [FieldRemap] public string ChipField1 { get; set; }
        [FieldRemap] public string ChipField2 { get; set; }
        [FieldRemap] public string ChipField3 { get; set; }
        [FieldRemap] public string ChipField4 { get; set; }
        [FieldRemap] public string ChipField5 { get; set; }
        [FieldRemap] public string ChipField6 { get; set; }
        [FieldRemap] public string ChipField7 { get; set; }
        [FieldRemap] public string ChipField8 { get; set; }
        [FieldRemap] public string ChipField9 { get; set; }
        [FieldRemap] public string ChipField10 { get; set; }
    }

    public interface IMemoryChip
        : IChip
    {
         string ChipField1 { get; }
         string ChipField2 { get; }
         string ChipField3 { get; }
         string ChipField4 { get; }
         string ChipField5 { get; }
         string ChipField6 { get; }
         string ChipField7 { get; }
         string ChipField8 { get; }
         string ChipField9 { get; }
         string ChipField10 { get; }
    }

    public class MemoryChipTypes
    {
    }
}
