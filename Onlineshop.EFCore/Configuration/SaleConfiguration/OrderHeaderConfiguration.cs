using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineshopDmain.Aggregates.Sale;
using PublicTools.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.EFCore.Configuration.SaleConfiguration
{
    public class OrderHeaderConfiguration : IEntityTypeConfiguration<OrderHeader>
    {
        public void Configure(EntityTypeBuilder<OrderHeader> builder)
        {
            builder.ToTable("OrderHeader", DatabaseConstants.Schemas.Model);
            builder.HasKey(oh => oh.Id);
            builder.Property(oh => oh.SellerId).IsRequired();
            builder.Property(oh => oh.BuyerId).IsRequired();
            builder.Property(oh => oh.Code).IsRequired();
            builder.Property(oh => oh.OrderDate).IsRequired();

            builder.Property(oh => oh.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(oh => oh.DateCreatedLatin).IsRequired().HasDefaultValue(System.DateTime.Now);
            builder.Property(oh => oh.IsModified).HasDefaultValue(false);
            builder.Property(oh => oh.IsDeleted).HasDefaultValue(false);
        }
    }
}
