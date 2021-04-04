using IBilPlugin;
using System;
using System.Collections.Generic;

namespace PluginDemo
{
    public class TaskMgr : IPluginMgr
    {
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public VisualForm GetPluginForm(string name)
        {
            throw new NotImplementedException();
        }

        public PluginInfo GetPluginInfo()
        {
            return null;
        }

        public void Init(Dictionary<string, string> arg)
        {
            throw new NotImplementedException();
        }
    }
}
