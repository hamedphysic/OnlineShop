using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineshopDmain.Aggregates.UserManagment;
using Onlineshope.RepositoryDesignPttern.Frameworks.Abstracts;

using ResponseFramework;




namespace Onlineshope.RepositoryDesignPttern.Frameworks.Bases
{
    public class BaseRepository<TDbContext, TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
                                                                          where TEntity : class
                                                                          where TDbContext : IdentityDbContext<OnlineShopUser, OnlineShopRoll, string,
                                                                              IdentityUserClaim<string>, OnlineShopUserRoll, IdentityUserLogin<string>,
                                                                              IdentityRoleClaim<string>, IdentityUserToken<string>>

    {
        public BaseRepository(TDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = dbContext.Set<TEntity>();
        }
        protected virtual TDbContext DbContext { get; set; }
        protected virtual DbSet<TEntity> DbSet { get; set; }



        public virtual async Task<IResponse<object>> DeleteAsync(TPrimaryKey id)
        {
            var entityToDelete = DbSet.FindAsync(id).Result;
          //  if (entityToDelete == null) return new ResponseFramework.Response<object>(MessageResource.Error_FailProcess);
            DbSet.Remove(entityToDelete);
            await SaveChanges();
            return new ResponseFramework.Response<object>(entityToDelete);
        }

        public Task<IResponse<object>> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<TEntity>> FindByIdAsync(TPrimaryKey? id)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<object>> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<List<TEntity>>> Select()
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<object>> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
