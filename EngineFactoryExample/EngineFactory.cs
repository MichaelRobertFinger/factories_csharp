using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineFactoryExample
{
    public class EngineFactory
    {
        public static Engine Create(EngineVersion version)
        {
            switch (version)
            {
                case EngineVersion.Version1:
                    return new Engine(new EngineConcreteFactory1());
                case EngineVersion.Version2:
                    return new Engine(new EngineConcreteFactory2());
                default:
                    throw new Exception("Engine version not found.");
            }
        }
    }
}
