using CoreAdvanced_App.Data.EF.Extensions;
using CoreAdvanced_App.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreAdvanced_App.Data.EF.Configurations
{
    public class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(_ => _.Id).HasMaxLength(255).IsRequired();
        }
    }
}