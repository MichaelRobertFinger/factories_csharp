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
    public class EngineConcreteFactory2_Tests
    {
        [Test]
        public void CreateMotor_Test() {
            var factory = new EngineConcreteFactory2();
            var motor = factory.CreateMotor();

            Assert.IsInstanceOf<Motor2>(motor);
        }
    }
}
