using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations
{
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.Id).HasColumnName("PostId");
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
            builder.Property(p=>p.Title).HasMaxLength(100).IsRequired();
        }
    }
}
