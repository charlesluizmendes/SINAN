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
    public class Sinan_DadosFinaisMap : IEntityTypeConfiguration<Sinan_DadosFinais>
    {
        public void Configure(EntityTypeBuilder<Sinan_DadosFinais> builder)
        {
            builder.ToTable("sinan_dadosfinais");

            builder.HasKey(c => c.id);
        }
    }
}