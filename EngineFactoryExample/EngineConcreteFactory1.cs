using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineFactoryExample
{
    public class EngineConcreteFactory1 : EngineAbstractFactory
    {
        public override IMotor CreateMotor()
        {
            return new Motor1();
        }
    }
}
