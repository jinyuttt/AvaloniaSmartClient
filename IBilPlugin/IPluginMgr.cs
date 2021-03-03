using System.Collections.Generic;

namespace IBilPlugin
{
    public  interface IPluginMgr
    {
        
        public void Init(Dictionary<string, string> arg);

        public PluginInfo GetPluginInfo();

        public VisualForm GetPluginForm(string name);

        public void Clear();



    }
}
