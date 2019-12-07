using SharpYaml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using YololShipSystemSpec.Attributes;
using YololShipSystemSpec.Devices;

namespace YololShipSystemSpec
{
    internal class Network
        : INetwork
    {
        [YamlMember("name")] public string _name { get; set; }
        [YamlIgnore] string INetwork.Name => _name;

        [YamlMember("remark")] public string _remark { get; set; }
        [YamlIgnore] string INetwork.Remark => _remark;

        [YamlMember("devices")] public List<IDevice> _devices { get; set; }
        IReadOnlyList<IDevice> INetwork.Devices => _devices;
    }

    internal class Specification
        : ISpecification
    {
        [YamlMember("networks")] public List<Network> _networks { get; set; }
        [YamlIgnore] IReadOnlyList<INetwork> ISpecification.Networks => _networks;

        [YamlMember("relays")] public List<Relay> _relays { get; set; }
        [YamlIgnore] IReadOnlyList<IRelay> ISpecification.Relays => _relays;
    }

    internal class Device<T>
        : IDevice
        where T : new()
    {
        [YamlMember("prefix")] public string _prefix { get; set; }
        [YamlIgnore] public string Prefix => _prefix;

        [YamlMember("suffix")] public string _suffix { get; set; }
        [YamlIgnore] public string Suffix => _suffix;

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

        private static readonly T _types = new T();
        public T TypeOf => _types;
    }
}
