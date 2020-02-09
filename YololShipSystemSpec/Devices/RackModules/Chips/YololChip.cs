using SharpYaml.Serialization;
using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices.RackModules.Chips
{
    internal class YololChip
        : Device<YololChipTypes>, IYololChip
    {
        [FieldRemap] public string ChipWait { get; set; }

        [YamlMember("script")] private string _script;
        [YamlIgnore] public string Script => _script;
    }

    public interface IYololChip
        : IChip
    {
         string ChipWait { get; }

         string Script { get; }
    }

    public class YololChipTypes
    {
    }
}
