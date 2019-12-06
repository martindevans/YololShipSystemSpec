## Yolol Ship System Spec

This library supplies all the basics types needed to specify a Yolol network within a C# project.

Every single device type has an interface representing it. This interface has a C# property for each device field which contains the name of that device field in the network. For example, a button is represented by this interface:

```
public interface IButton
    : IDevice
{
    string ButtonState { get; }
    string ButtonOnStateValue { get; }
    string ButtonOffStateValue { get; }
    string ButtonStyle { get; }

    ButtonTypes TypeOf { get; }
}
```

There are some additional convenience properties available on device interfaces.

The `TypeOf` field (not yet implemented for all types) contains `TypeInfo` for every device field, specifying the expected values for a field. For example the `ButtonTypes` class looks like this:

```
public class ButtonTypes
{
    public TypeInfo ButtonState => new TypeInfo(YololType.Number | YololType.String);
    public TypeInfo ButtonOnStateValue => new TypeInfo(YololType.Number | YololType.String);
    public TypeInfo ButtonOffStateValue => new TypeInfo(YololType.Number | YololType.String);
    public TypeInfo ButtonStyle => new TypeInfo(YololType.Number, 0, 2);
}
```

## Serialisation

Constructing these graphs is done by deserialising a YAML file which specifies the network layout. This is intended to act as a general way to specify network layouts which can be used to exchange network topology information between different tools (compilers, optimisers etc).

The file specifies a list of named networks, each network has a list of devices. There is also a list of relays which connect together the named networks. For example:

```
networks:
 - &primary                                             # Specify a network named `primary`
   name: "primary network"                              # Give it a human readable name
   remark: "Primary data backbone of the ship"          # Optional human readable remarks
   devices:
    - !radio_transmitter                                # Specify a device of type `radio_transmitter` 
      prefix: pre_                                      # Prefix all fields with `pre_`
      suffix: _post                                     # Suffix all fields with `_post`
      TransmitMessage: tm                               # Name the `Transmitmessage` field `pre_tm_post`
      TransmitRange: tr
      Frequency: fq
    - !cargo_beam
      prefix: range

 - &hull_integrity                                      # Another network
   name: "integrity"
   remark: "wires on hull plating to detect breaches"

 - &bridge                                              # Yet another network
   name: "bridge"
   remark: "Data network for bridge terminals"

relays:
 - src: *hull_integrity                                 # A relay connecting `hull integrity` to `primary` network
   dst: *primary
 - src: *bridge
   dst: *primary
```