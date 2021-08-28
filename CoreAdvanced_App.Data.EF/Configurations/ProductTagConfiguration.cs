using CoreAdvanced_App.Data.EF.Extensions;
using CoreAdvanced_App.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(_ => _.TagId).HasMaxLength(255).IsRequired()
                .HasColumnType("varchar(255)");
        }
    }
}
