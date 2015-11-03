using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Twoems.PoolCloud.EntityFramework;

namespace Twoems.PoolCloud
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(PoolCloudCoreModule))]
    public class PoolCloudDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
