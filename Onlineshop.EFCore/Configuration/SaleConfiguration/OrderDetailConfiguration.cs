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
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail", DatabaseConstants.Schemas.Model);
            builder.HasKey(od => new
            {
                od.ProductId,
                od.OrderHeaderId,
            });

            builder.Property(od => od.UnitPrice).IsRequired();
            builder.Property(od => od.Quantity).IsRequired();
        }
    }
 }
