using MyApp.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomainSetup setup = new AppDomainSetup();
            setup.ApplicationBase = @"C:\Users\Pavel\Documents\visual studio 2013\Projects\MyApp\SomePlugin\bin\Debug\";
            
            AppDomain pluginDomain = AppDomain.CreateDomain("plugin", null, setup);
            pluginDomain.DoCallBack(PluginInvoker.InvokePlugin);

        }
    }
}
