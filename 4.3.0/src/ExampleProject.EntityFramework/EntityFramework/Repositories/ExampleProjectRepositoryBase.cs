using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ExampleProject.EntityFramework.Repositories
{
    public abstract class ExampleProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ExampleProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ExampleProjectRepositoryBase(IDbContextProvider<ExampleProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ExampleProjectRepositoryBase<TEntity> : ExampleProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ExampleProjectRepositoryBase(IDbContextProvider<ExampleProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
