using YololShipSystemSpec.Attributes;
using YololShipSystemSpec.Types;

namespace YololShipSystemSpec.Devices
{
    internal class Button
        : Device<ButtonTypes>, IButton
    {
        [FieldRemap] public string ButtonState { get; set; }
        [FieldRemap] public string ButtonOnStateValue { get; set; }
        [FieldRemap] public string ButtonOffStateValue { get; set; }
        [FieldRemap] public string ButtonStyle { get; set; }
    }

    public interface IButton
        : IDevice
    {
        string ButtonState { get; }
        string ButtonOnStateValue { get; }
        string ButtonOffStateValue { get; }
        string ButtonStyle { get; }

        ButtonTypes TypeOf { get; }
    }

    public class ButtonTypes
    {
        public TypeInfo ButtonState => new TypeInfo(YololType.Number | YololType.String);
        public TypeInfo ButtonOnStateValue => new TypeInfo(YololType.Number | YololType.String);
        public TypeInfo ButtonOffStateValue => new TypeInfo(YololType.Number | YololType.String);
        public TypeInfo ButtonStyle => new TypeInfo(YololType.Number, 0, 2);
    }
}
