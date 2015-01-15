using EngineFactoryExample;
using NUnit.Framework;
using System;

namespace EngineFactoryExampleTests
{
    [TestFixture]
    public class Motor1Tests
    {
        [Test]
        public void GetPart_Test()
        {
            var expected = "base motor";
            var motor = new Motor1();
            var actual = motor.GetPart();

            Assert.AreEqual(expected, actual);
        }
    }
}
