using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Configurations
{
    public class MailAccountConfiguration : IEntityTypeConfiguration<MailAccount>
    {
        public void Configure(EntityTypeBuilder<MailAccount> builder)
        {
            // PK
            builder.HasKey(x => x.Id);

            // Pk 1er artsın.
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.EmailAddress).HasMaxLength(30).IsRequired();
            builder.Property(x => x.MailServerAddress).HasMaxLength(15).IsRequired();
            builder.Property(x => x.Port).IsRequired();
            builder.Property(x => x.UserName).HasMaxLength(30).IsRequired();
            builder.Property(x=>x.Password).HasMaxLength(15).IsRequired();
            builder.Property(x => x.MailType).HasMaxLength(15).IsRequired();
        }
    }
}
