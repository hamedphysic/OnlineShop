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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product", DatabaseConstants.Schemas.Model);
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Code).IsRequired().HasMaxLength(50);
            builder.Property(p => p.UnitPrice).IsRequired();

            builder.Property(p => p.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(p => p.DateCreatedLatin).IsRequired().HasDefaultValue(System.DateTime.Now);
            builder.Property(p => p.IsModified).HasDefaultValue(false);
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
        }


    }
}
