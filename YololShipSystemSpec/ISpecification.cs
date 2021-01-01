using System.Collections.Generic;
using YololShipSystemSpec.Devices;

namespace YololShipSystemSpec
{
    public interface ISpecification
    {
        string Version { get; }

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

    // ReSharper disable once InconsistentNaming
    public static class IDeviceExtensions
    {
        public static IEnumerable<(string, string)> ResolveNames(this IDevice device)
        {
            foreach (var name in device.FieldNames)
            {
                yield return (
                    name.Key,
                    $"{device.Prefix}{name.Value}{device.Suffix}"
                );
            }
        }
    }
}
