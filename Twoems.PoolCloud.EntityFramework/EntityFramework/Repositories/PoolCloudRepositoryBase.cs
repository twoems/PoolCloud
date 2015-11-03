using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Twoems.PoolCloud.EntityFramework.Repositories
{
    public abstract class PoolCloudRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<PoolCloudDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected PoolCloudRepositoryBase(IDbContextProvider<PoolCloudDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class PoolCloudRepositoryBase<TEntity> : PoolCloudRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected PoolCloudRepositoryBase(IDbContextProvider<PoolCloudDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
