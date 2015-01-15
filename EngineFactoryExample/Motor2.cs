using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineFactoryExample
{
    public class Motor2 : BaseMotor, IMotor
    {
        public override string GetPart()
        {
            return "Part from Motor2";
        }
    }
}
