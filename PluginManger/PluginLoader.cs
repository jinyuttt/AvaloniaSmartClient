using Autofac;
using System;

namespace PluginManger
{

    /// <summary>
    /// 依赖注册
    /// </summary>
    public class PluginLoader
    {
        private static Lazy<PluginLoader> Loader = new Lazy<PluginLoader>();
        public static PluginLoader Instance
        {
            get { return Loader.Value; }
        }

        readonly ContainerBuilder builder = new ContainerBuilder();
         IContainer container = null;

        /// <summary>
        /// 以接口注册类型
        /// </summary>
        /// <param name="srvType">类型</param>
        /// <param name="isSingleInstance">是否单例</param>
        public void AddType(Type srvType,bool isSingleInstance=false)
        {
           var t= builder.RegisterType(srvType).AsSelf().AsImplementedInterfaces();
            if(isSingleInstance)
            {
                t.SingleInstance();
            }
        }

        /// <summary>
        /// 以名称注册类
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="srvType">类</param>
        /// <param name="IsSingleInstance">单例</param>
        public void AddNameType(string name,Type srvType, bool IsSingleInstance=false)
        {
           var t= builder.RegisterType(srvType).Named(name, srvType).AsSelf().AsImplementedInterfaces();
            if(IsSingleInstance)
            {
                t.SingleInstance();
            }
        }

       /// <summary>
       /// 获取注册的接口类型
       /// </summary>
       /// <typeparam name="T">接口</typeparam>
       /// <returns></returns>
        public T  GetType<T>() where T:class
        {
            if(container==null)
            {
                container = builder.Build();
            }
            using var scope = container.BeginLifetimeScope();
            var service = scope.ResolveOptional<T>();
            return service;
        }

        /// <summary>
        /// 以名称获取类
        /// </summary>
        /// <typeparam name="T">接口类型</typeparam>
        /// <param name="name">名称</param>
        /// <returns></returns>
        public T GetNameType<T>(string name) where T : class
        {
            if (container == null)
            {
                container = builder.Build();
            }
            using var scope = container.BeginLifetimeScope();
            var service = scope.ResolveOptionalNamed<T>(name);
            return service;
        }

       
    }
}
