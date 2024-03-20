using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineshopDmain.Aggregates.Sale;
using PublicTools.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop.EFCore.Configuration.SaleConfiguration
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategory", DatabaseConstants.Schemas.Model);
            builder.HasKey(pc => pc.Id);
            builder.Property(pc => pc.Title).IsRequired().HasMaxLength(50);
            //  modelBuilder.Entity().HasMany(p => p.Contacts).WithOne(d => d.Company).HasForeignKey(d => d.CompanyId);
        //    builder.HasOne<ProductCategory>(p => p.Category).WithOne(p => p.Category).HasForeignKey(pc => pc.Id); 
            

        }
    }
}
