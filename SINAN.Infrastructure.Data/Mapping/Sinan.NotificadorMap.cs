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
    public class Sinan_NotificadorMap : IEntityTypeConfiguration<Sinan_Notificador>
    {
        public void Configure(EntityTypeBuilder<Sinan_Notificador> builder)
        {
            builder.ToTable("sinan_notificador");

            builder.HasKey(c => c.id);
        }
    }
}