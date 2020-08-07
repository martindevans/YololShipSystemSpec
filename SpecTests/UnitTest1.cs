using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using YololShipSystemSpec;

namespace SpecTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new StringReader(File.ReadAllText("all.yaml"));

            var deserializer = new Deserializer();
            var spec = deserializer.Deserialize(input);

            Assert.IsNotNull(spec);
            Assert.AreEqual("1.0.0", spec.Version);

            Console.WriteLine(string.Join(",", spec.Networks[0].Devices[0].FieldNames));
        }
    }
}
