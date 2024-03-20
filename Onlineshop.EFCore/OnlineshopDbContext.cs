//using Microsoft.AspNet.Identity.EntityFramework;

using Microsoft.AspNetCore.Identity;
using OnlineshopDmain.Aggregates.UserManagment;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OnlineshopDmain.Frameworks.Abstracts;
using Onlineshop.EFCore.FrameWorks;
using PublicTools.Constants;
using OnlineshopDmain.Aggregates.Sale;


namespace Onlineshop.EFCore
{
    public class OnlineshopDbContext:IdentityDbContext<OnlineShopUser,OnlineShopRoll,string,
        IdentityUserClaim<string>,
        OnlineShopUserRoll,
        IdentityUserLogin<string>,
        IdentityRoleClaim<string>,
        IdentityUserToken<string>
        >
    {
        public OnlineshopDbContext(DbContextOptions<OnlineshopDbContext> options) : base(options)
        {
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DatabaseConstants.Schemas.Identity);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.RegisterAllEntities<IDbSetEntity>(typeof(IDbSetEntity).Assembly);

            modelBuilder.Entity<OrderHeader>().HasOne(oh => oh.Buyer).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<OrderHeader>().HasOne(oh => oh.Seller).WithMany().OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }



    }
}
