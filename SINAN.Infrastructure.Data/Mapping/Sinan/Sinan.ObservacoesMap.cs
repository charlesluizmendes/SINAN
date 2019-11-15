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
    public class Sinan_ObservacoesMap : IEntityTypeConfiguration<Sinan_Observacoes>
    {
        public void Configure(EntityTypeBuilder<Sinan_Observacoes> builder)
        {
            builder.ToTable("sinan_observacoes");

            builder.HasKey(c => c.id);
        }
    }
}