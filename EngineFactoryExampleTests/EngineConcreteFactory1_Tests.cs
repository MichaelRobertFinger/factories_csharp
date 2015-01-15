using EngineFactoryExample;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineFactoryExampleTests
{
    [TestFixture]
    public class EngineConcreteFactory1_Tests
    {
        [Test]
        public void CreateMotor_Test() {
            var factory = new EngineConcreteFactory1();
            var motor = factory.CreateMotor();

            Assert.IsInstanceOf<Motor1>(motor);
        }
    }
}
