using System.Collections.Generic;
using YololShipSystemSpec.Devices;

namespace YololShipSystemSpec
{
    public interface ISpecification
    {
        IReadOnlyDictionary<string, object> Extensions { get; }

        IReadOnlyList<INetwork> Networks { get; }

        IReadOnlyList<IRelay> Relays { get; }
    }

    public interface INetwork
    {
        IReadOnlyDictionary<string, object> Extensions { get; }

        string Name { get; }

        string Remark { get; }

        IReadOnlyList<IDevice> Devices { get; }
    }

    public interface IDevice
    {
        IReadOnlyDictionary<string, object> Extensions { get; }

        string Prefix { get; }
        string Suffix { get; }

        IReadOnlyDictionary<string, string> FieldNames { get; }
    }
}
