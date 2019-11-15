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
    public class Sinan_ViolenciaSexualMap : IEntityTypeConfiguration<Sinan_ViolenciaSexual>
    {
        public void Configure(EntityTypeBuilder<Sinan_ViolenciaSexual> builder)
        {
            builder.ToTable("sinan_violenciasexual");

            builder.HasKey(c => c.id);
        }
    }
}