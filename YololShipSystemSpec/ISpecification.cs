using System.Collections.Generic;
using YololShipSystemSpec.Devices;

namespace YololShipSystemSpec
{
    public interface ISpecification
    {
        IReadOnlyList<INetwork> Networks { get; }

        IReadOnlyList<IRelay> Relays { get; }
    }

    public interface INetwork
    {
        string Name { get; }

        string Remark { get; }

        IReadOnlyList<IDevice> Devices { get; }
    }

    public interface IDevice
    {
        string Prefix { get; }
        string Suffix { get; }

        IReadOnlyDictionary<string, string> FieldNames { get; }
    }
}
