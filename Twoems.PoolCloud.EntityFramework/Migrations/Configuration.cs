using System.Data.Entity.Migrations;
using Twoems.PoolCloud.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Twoems.PoolCloud.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PoolCloud.EntityFramework.PoolCloudDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PoolCloud";
        }

        protected override void Seed(PoolCloud.EntityFramework.PoolCloudDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
