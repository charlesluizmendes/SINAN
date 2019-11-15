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
    public class Sinan_DadosGeraisMap : IEntityTypeConfiguration<Sinan_DadosGerais>
    {
        public void Configure(EntityTypeBuilder<Sinan_DadosGerais> builder)
        {
            builder.ToTable("sinan_dadosgerais");

            builder.HasKey(c => c.id);
        }
    }
}