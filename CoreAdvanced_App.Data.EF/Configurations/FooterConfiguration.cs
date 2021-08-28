using CoreAdvanced_App.Data.EF.Extensions;
using CoreAdvanced_App.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.EF.Configurations
{
    public class FooterConfiguration : DbEntityConfiguration<Footer>
    {
        public override void Configure(EntityTypeBuilder<Footer> entity)
        {
            entity.HasKey(_ => _.Id);
            entity.Property(_ => _.Id).HasMaxLength(255)
                .HasColumnType("varchar(255)").IsRequired();
        }
    }
}
