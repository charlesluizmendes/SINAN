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
    public class Sinan_NotificacaoIndividualMap : IEntityTypeConfiguration<Sinan_NotificacaoIndividual>
    {
        public void Configure(EntityTypeBuilder<Sinan_NotificacaoIndividual> builder)
        {
            builder.ToTable("sinan_notificacaoindividual");

            builder.HasKey(c => c.id);
        }
    }
}