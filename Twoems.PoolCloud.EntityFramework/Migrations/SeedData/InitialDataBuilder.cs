using Twoems.PoolCloud.EntityFramework;

namespace Twoems.PoolCloud.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly PoolCloudDbContext _context;

        public InitialDataBuilder(PoolCloudDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
        }
    }
}
