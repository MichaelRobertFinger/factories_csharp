using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineFactoryExample
{
    public class Engine
    {
        public IMotor Motor;

        public Engine(EngineAbstractFactory factory)
        {
            Motor = factory.CreateMotor();
        }
    }
}
