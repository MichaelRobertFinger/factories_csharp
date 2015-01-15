using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineFactoryExample
{
    public abstract class EngineAbstractFactory
    {
        public abstract IMotor CreateMotor();
    }
}
