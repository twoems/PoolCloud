using Abp.MultiTenancy;
using Twoems.PoolCloud.Users;

namespace Twoems.PoolCloud.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}