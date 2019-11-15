using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Domain.Entities;

namespace SINAN.Infrastructure.Data.Mapping
{
    public class SinanMap : IEntityTypeConfiguration<Sinan>
    {
        public void Configure(EntityTypeBuilder<Sinan> builder)
        {
            builder.ToTable("sinan");

            builder.HasKey(c => c.id);
        }
    }
}