using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomePlugin
{
    public class Test: MyApp.SDK.Plugin
    {
        public override void Loaded()
        {
            Console.WriteLine("Loaded");
        }

        public override void Unload()
        {
            Console.WriteLine("Unloaded");
        }
    }
}
