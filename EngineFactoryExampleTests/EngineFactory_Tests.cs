using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EngineFactoryExample;

namespace EngineFactoryExampleTests
{
    [TestFixture]
    public class EngineFactory_Tests
    {
        [Test]
        public void EngineFactory_GetEngineConcreteFactory1_ReturnsCorrectVersion()
        {
            var engine = EngineFactory.Create(EngineVersion.Version1);

            Assert.IsInstanceOf<Motor1>(engine.Motor);
        }

        [Test]
        public void EngineFactory_GetEngineConcreteFactory2_ReturnsCorrectVersion()
        {
            var engine = EngineFactory.Create(EngineVersion.Version2);

            Assert.IsInstanceOf<Motor2>(engine.Motor);
        }

        //[Test]
        //[ExpectedException(ExpectedException=typeof(Exception), ExpectedMessage="Engine version not found.")]
        //public void EngineFactory_NonExistentEngine_ThrowsException()
        //{
        //    var engine = EngineFactory.Create()
        //}
    }
}
