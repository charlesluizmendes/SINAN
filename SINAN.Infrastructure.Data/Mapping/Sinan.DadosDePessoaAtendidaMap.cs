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
    public class Sinan_DadosDePessoaAtendidaMap : IEntityTypeConfiguration<Sinan_DadosDePessoaAtendida>
    {
        public void Configure(EntityTypeBuilder<Sinan_DadosDePessoaAtendida> builder)
        {
            builder.ToTable("sinan_dadosdepessoaatendida");

            builder.HasKey(c => c.id);
        }
    }
}