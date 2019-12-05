using SharpYaml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using YololShipSystemSpec.Attributes;
using YololShipSystemSpec.Devices;

#pragma warning disable IDE1006 // Naming Styles

namespace YololShipSystemSpec
{
    internal class Network
        : INetwork
    {
        [YamlMember] public string name { get; set; }
        [YamlIgnore] string INetwork.Name => name;

        [YamlMember] public string remark { get; set; }
        [YamlIgnore] string INetwork.Remark => remark;

        [YamlMember] public List<IDevice> devices { get; set; }
        IReadOnlyList<IDevice> INetwork.Devices => devices;
    }

    internal class Specification
        : ISpecification
    {
        [YamlMember] public List<Network> networks { get; set; }
        [YamlIgnore] IReadOnlyList<INetwork> ISpecification.Networks => networks;

        [YamlMember] public List<Relay> relays { get; set; }
        [YamlIgnore] IReadOnlyList<IRelay> ISpecification.Relays => relays;
    }

    internal class Device<T>
        : IDevice
        where T : new()
    {
        [YamlMember] public string prefix { get; set; }
        [YamlIgnore] public string Prefix => prefix;

        [YamlMember] public string suffix { get; set; }
        [YamlIgnore] public string Suffix => suffix;

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
