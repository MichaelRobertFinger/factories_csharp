using EngineFactoryExample;
using NUnit.Framework;
using System;

namespace EngineFactoryExampleTests
{
    [TestFixture]
    public class Motor2Tests
    {
        [Test]
        public void GetPart_Test()
        {
            var expected = "Part from Motor2";
            var motor = new Motor2();
            var actual = motor.GetPart();

            Assert.AreEqual(expected, actual);
        }
    }
}
