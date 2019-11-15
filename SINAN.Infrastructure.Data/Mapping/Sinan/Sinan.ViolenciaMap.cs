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
    public class Sinan_ViolenciaMap : IEntityTypeConfiguration<Sinan_Violencia>
    {
        public void Configure(EntityTypeBuilder<Sinan_Violencia> builder)
        {
            builder.ToTable("sinan_violencia");

            builder.HasKey(c => c.id);
        }
    }
}