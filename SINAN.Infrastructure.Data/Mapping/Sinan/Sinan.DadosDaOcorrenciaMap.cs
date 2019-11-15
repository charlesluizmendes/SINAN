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
    public class Sinan_DadosDaOcorrenciaMap : IEntityTypeConfiguration<Sinan_DadosDaOcorrencia>
    {
        public void Configure(EntityTypeBuilder<Sinan_DadosDaOcorrencia> builder)
        {
            builder.ToTable("sinan_dadosdaocorrencia");

            builder.HasKey(c => c.id);
        }
    }
}