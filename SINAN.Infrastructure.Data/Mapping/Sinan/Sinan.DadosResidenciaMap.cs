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
    public class Sinan_DadosResidenciaMap : IEntityTypeConfiguration<Sinan_DadosResidencia>
    {
        public void Configure(EntityTypeBuilder<Sinan_DadosResidencia> builder)
        {
            builder.ToTable("sinan_dadosresidencia");

            builder.HasKey(c => c.id);
        }
    }
}