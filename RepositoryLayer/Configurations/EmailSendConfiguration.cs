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
    public class EmailSendConfiguration : IEntityTypeConfiguration<EmailSend>
    {
        public void Configure(EntityTypeBuilder<EmailSend> builder)
        {
            // PK
            builder.HasKey(x => x.Id);

            // Pk 1er artsın.
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.Subject).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(500).IsRequired();
        }
    }
}
