using SharpYaml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using YololShipSystemSpec.Attributes;
using YololShipSystemSpec.Devices;

#pragma warning disable 649 //Unassigned field
#pragma warning disable IDE0044 // Add readonly modifier
// ReSharper disable ConvertToAutoProperty
// ReSharper disable CollectionNeverUpdated.Local

namespace YololShipSystemSpec
{
    internal class Network
        : INetwork
    {

        [YamlMember("name")] private string _name;
        [YamlIgnore] string INetwork.Name => _name;

        [YamlMember("remark")] private string _remark;
        [YamlIgnore] string INetwork.Remark => _remark;

        [YamlMember("devices")] private List<IDevice> _devices;
        IReadOnlyList<IDevice> INetwork.Devices => _devices;

        [YamlMember("extensions")] private Dictionary<string, object> _extensions;
        IReadOnlyDictionary<string, object> INetwork.Extensions => _extensions;
    }

    internal class Specification
        : ISpecification
    {
        [YamlMember("version")] private string _version;
        [YamlIgnore] public string Version => _version;

        [YamlMember("networks")] private List<Network> _networks;
        [YamlIgnore] IReadOnlyList<INetwork> ISpecification.Networks => _networks;

        [YamlMember("relays")] private List<Relay> _relays;
        [YamlIgnore] IReadOnlyList<IRelay> ISpecification.Relays => _relays;

        [YamlMember("extensions")] private Dictionary<string, object> _extensions;
        IReadOnlyDictionary<string, object> ISpecification.Extensions => _extensions;
    }

    internal class Device<T>
        : IDevice
        where T : new()
    {
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once InconsistentNaming
        [YamlMember("prefix")] public string _prefix;
        [YamlIgnore] public string Prefix => _prefix;

        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once InconsistentNaming
        [YamlMember("suffix")] public string _suffix;
        [YamlIgnore] public string Suffix => _suffix;

        [YamlMember("extensions")] private Dictionary<string, object> _extensions;
        IReadOnlyDictionary<string, object> IDevice.Extensions => _extensions;

        private IReadOnlyDictionary<string, string> _fieldNames;
        public IReadOnlyDictionary<string, string> FieldNames
        {
            get
            {
                if (_fieldNames == null)
                {
                    var props = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    var attrs = props.Where(a => a.GetCustomAttribute<FieldRemapAttribute>(true) != null);

                    _fieldNames = attrs
                        .Select(a => (a.Name, (string)a.GetValue(this)))
                        .ToDictionary(a => a.Name, a => a.Item2);

                }
                return _fieldNames;
            }
        }

        private static readonly T Types = new T();
        public T TypeOf => Types;
    }
}
