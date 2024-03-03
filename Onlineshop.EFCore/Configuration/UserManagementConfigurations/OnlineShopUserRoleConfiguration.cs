using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineshopDmain.Aggregates.UserManagment;
using PublicTools.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.EFCore.Configuration.UserManagementConfigurations
{
    public class OnlineShopUserRoleConfiguration : IEntityTypeConfiguration<OnlineShopUserRoll>
    {
        public void Configure(EntityTypeBuilder<OnlineShopUserRoll> builder)
        {
            builder.ToTable(nameof(OnlineShopUserRoll))
                .HasData(
                    new OnlineShopUserRoll() { UserId = DatabaseConstants.AdminUser.GodAdminId, RoleId = DatabaseConstants.RollUser.GodAdminId }
                       );
            builder.HasKey(p => new
            {
                p.UserId,
                p.RoleId,
            });
        }

    }
}
