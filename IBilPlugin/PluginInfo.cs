using System.Collections.Generic;

namespace IBilPlugin
{
    public class PluginInfo
    {
        /// <summary>
        /// 关联菜单
        /// </summary>
        public SysMenum Menum { get; set; } 

        /// <summary>
        /// 插件名称
        /// </summary>
        public string PluginName { get; set; }

        /// <summary>
        /// 插件窗口
        /// </summary>
        public List<PluginForm> Forms { get; set; }

        /// <summary>
        /// 插件序号
        /// </summary>
        public int OrderNum { get; set; }
    }

    public class PluginForm
    {
        /// <summary>
        /// 窗口名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 窗口显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 窗口标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 窗口类型名称
        /// </summary>
        public string ControlName { get; set; }

        /// <summary>
        /// 窗口图标类型
        /// </summary>
        public string Icon { get; set; }


    }

    public class VisualForm
    {
        /// <summary>
        /// 窗口对象
        /// </summary>
        public object Form { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 显示方式
        /// </summary>
        public ShowType  Show{get;set;}

        /// <summary>
        ///标题
        /// </summary>
        public string Title { get; set; }
    }
}
