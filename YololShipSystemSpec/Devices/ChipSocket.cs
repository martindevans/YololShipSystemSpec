using SharpYaml.Serialization;
using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices
{
    internal class ChipSocket
        : Device<ButtonTypes>, IButton
    {
        [FieldRemap] public string ButtonState { get; set; }
        [FieldRemap] public string ButtonOnStateValue { get; set; }
        [FieldRemap] public string ButtonOffStateValue { get; set; }
        [FieldRemap] public string ButtonStyle { get; set; }

        [YamlMember("script")] private string _script;
        [YamlIgnore] public string Script => _script;
    }

    public interface IChipSocket
        : IDevice
    {
        string ButtonState { get; }
        string ButtonOnStateValue { get; }
        string ButtonOffStateValue { get; }
        string ButtonStyle { get; }

        string Script { get; }

        ChipSocketTypes TypeOf { get; }
    }

    public class ChipSocketTypes
    {
    }
}
