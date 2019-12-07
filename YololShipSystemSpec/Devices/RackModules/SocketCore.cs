using YololShipSystemSpec.Attributes;

namespace YololShipSystemSpec.Devices.RackModules
{
    internal class SocketCore
        : Device<SocketCoreTypes>, ISocketCore
    {
        [FieldRemap] public string Script0 { get; set; }
        [FieldRemap] public string Script1 { get; set; }
    }

    public interface ISocketCore
        : IRackModule
    {
        string Script0 { get; }
        string Script1 { get; }
    }

    public class SocketCoreTypes
    {
    }
}
