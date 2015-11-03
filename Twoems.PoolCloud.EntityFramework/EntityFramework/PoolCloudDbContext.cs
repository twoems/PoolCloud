using System.Data.Common;
using Abp.Zero.EntityFramework;
using Twoems.PoolCloud.Authorization.Roles;
using Twoems.PoolCloud.MultiTenancy;
using Twoems.PoolCloud.Users;

namespace Twoems.PoolCloud.EntityFramework
{
    public class PoolCloudDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public PoolCloudDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in PoolCloudDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of PoolCloudDbContext since ABP automatically handles it.
         */
        public PoolCloudDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public PoolCloudDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
