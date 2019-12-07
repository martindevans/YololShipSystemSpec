using System;
using System.IO;
using Humanizer;
using SharpYaml.Serialization;
using YololShipSystemSpec.Devices;
using YololShipSystemSpec.Devices.RackModules;

namespace YololShipSystemSpec
{
    public class Deserializer
    {
        private Serializer _serializer;

        public Deserializer()
        {
            _serializer = new Serializer();
            _serializer.Settings.NamingConvention = new FlatNamingConvention();

            Register<Button>();
            Register<CargoBeam>();
            Register<CargoLockFrame>();
            Register<FixedMount>();
            Register<FlightControlUnit>();
            Register<Generator>();
            Register<Hinge>();
            Register<InformationScreen>();
            Register<Lamp>();
            Register<Lever>();
            Register<MainFlightComputer>();
            Register<MiningLaser>();
            Register<ModularDisplay>();
            Register<RadioReceiver>();
            Register<RadioTransmitter>();
            Register<RailRelay>();
            Register<RailSensorStrip>();
            Register<RailTrigger>();
            Register<RangeFinder>();
            Register<Tank>();
            Register<Thruster>();
            Register<Turntable>();
            Register<Rack>();
            Register<ChipCore>();
            Register<ChipReader>();
            Register<SocketCore>();
            Register<ChipSocket>();
        }

        private void Register<T>()
        {
            var name = typeof(T).Name;

            // Register `nameofdevice`
            _serializer.Settings.RegisterTagMapping(name.ToLowerInvariant(), typeof(T));

            // Register `name_of_device`
            _serializer.Settings.RegisterTagMapping(name.Underscore(), typeof(T));
        }

        public ISpecification Deserialize(TextReader reader)
        {
            return _serializer.Deserialize<Specification>(reader);
        }
    }
}
