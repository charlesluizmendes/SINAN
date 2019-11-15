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
    public class Sinan_DadosDoProvavelAutorDaViolenciaMap : IEntityTypeConfiguration<Sinan_DadosDoProvavelAutorDaViolencia>
    {
        public void Configure(EntityTypeBuilder<Sinan_DadosDoProvavelAutorDaViolencia> builder)
        {
            builder.ToTable("sinan_dadosdoprovavelautordaviolencia");

            builder.HasKey(c => c.id);
        }
    }
}