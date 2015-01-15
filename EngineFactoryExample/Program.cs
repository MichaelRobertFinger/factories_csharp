using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine1 = EngineFactory.Create(EngineVersion.Version1);
            Console.WriteLine(engine1.Motor.GetPart());

            var engine2 = EngineFactory.Create(EngineVersion.Version2);
            Console.WriteLine(engine2.Motor.GetPart());

            Console.ReadKey();
        }
    }
}
