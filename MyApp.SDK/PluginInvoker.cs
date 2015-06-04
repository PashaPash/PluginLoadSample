using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.SDK
{
    public static class PluginInvoker
    {
        public static void InvokePlugin()
        {
            var pluginAssembly = Assembly.Load("SomePlugin");
            var pluginType = pluginAssembly.GetTypes().Where(t => typeof(Plugin).IsAssignableFrom(t)).Single();
            Plugin plugin = (Plugin)pluginType.GetConstructor(new Type[0]).Invoke(null);
            plugin.Loaded();
        }
    }
}
