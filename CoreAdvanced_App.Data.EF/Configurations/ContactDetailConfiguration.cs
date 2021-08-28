using CoreAdvanced_App.Data.EF.Extensions;
using CoreAdvanced_App.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreAdvanced_App.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(_ => _.Id);
            entity.Property(_ => _.Id).HasMaxLength(255).IsRequired();
        }
    }
}