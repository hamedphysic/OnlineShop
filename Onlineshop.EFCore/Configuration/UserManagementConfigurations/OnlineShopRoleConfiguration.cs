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
    public class OnlineShopRoleConfiguration:IEntityTypeConfiguration<OnlineShopRoll>
    {
        public void Configure(EntityTypeBuilder<OnlineShopRoll> builder)
        {

            builder.ToTable(nameof(OnlineShopRoll)).
                HasData(
                new OnlineShopRoll()
                {
                    Id = DatabaseConstants.RollUser.GodAdminId,
                    Name = DatabaseConstants.RollUser.GodAdminName,
                    NormalizedName = DatabaseConstants.RollUser.GodAdminNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.RollUser.GodAdminConcurrencyStamp,
                },
                new OnlineShopRoll()
                {
                    Id = DatabaseConstants.RollUser.AdminId,
                    Name = DatabaseConstants.RollUser.AdminName,
                    NormalizedName = DatabaseConstants.RollUser.AdminNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.RollUser.AdminConcurrencyStamp,
                }
            );

        }
    }
}
