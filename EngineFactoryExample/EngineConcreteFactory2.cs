using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineFactoryExample
{
    public class EngineConcreteFactory2 : EngineAbstractFactory
    {
        public override IMotor CreateMotor()
        {
            return new Motor2();
        }
    }
}
