using System;

namespace MyApp.SDK
{
    public abstract class Plugin
    {
        public abstract void Loaded();
        public abstract void Unload();
    }
}
