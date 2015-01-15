using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineFactoryExample
{
    public class BaseMotor : IMotor
    {
        public virtual string GetPart()
        {
            return "base motor";
        }
    }
}
