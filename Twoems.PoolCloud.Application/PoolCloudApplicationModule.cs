using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Twoems.PoolCloud
{
    [DependsOn(typeof(PoolCloudCoreModule), typeof(AbpAutoMapperModule))]
    public class PoolCloudApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
