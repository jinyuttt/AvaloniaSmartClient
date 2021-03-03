using System.Collections.Generic;

namespace IBilPlugin
{
    public class SysMenum
    {

        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 子菜单
        /// </summary>
        public List<SysMenum> ChildMenu { get; set; }
    }
}
