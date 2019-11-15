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
    public class Sinan_EncaminhamentoMap : IEntityTypeConfiguration<Sinan_Encaminhamento>
    {
        public void Configure(EntityTypeBuilder<Sinan_Encaminhamento> builder)
        {
            builder.ToTable("sinan_encaminhamento");

            builder.HasKey(c => c.id);
        }
    }
}