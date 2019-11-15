using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Infrastructure.Data.Mapping;
using SINAN.Domain.Entities;
using System.Configuration;

namespace SINAN.Infrastructure.Data.Context
{
    public class Contexto : DbContext, IDisposable
    {
        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Logradouro> Logradouro { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<Sinan> Sinan { get; set; }
        public DbSet<Sinan_DadosDaOcorrencia> Sinan_DadosDaOcorrencia { get; set; }
        public DbSet<Sinan_DadosDePessoaAtendida> Sinan_DadosDePessoaAtendida { get; set; }
        public DbSet<Sinan_DadosDoProvavelAutorDaViolencia> Sinan_DadosDoProvavelAutorDaViolencia { get; set; }
        public DbSet<Sinan_DadosFinais> Sinan_DadosFinais { get; set; }
        public DbSet<Sinan_DadosGerais> Sinan_DadosGerais { get; set; }
        public DbSet<Sinan_DadosResidencia> Sinan_DadosResidencia { get; set; }
        public DbSet<Sinan_Encaminhamento> Sinan_Encaminhamento { get; set; }
        public DbSet<Sinan_NotificacaoIndividual> Sinan_NotificacaoIndividual { get; set; }
        public DbSet<Sinan_Notificador> Sinan_Notificador { get; set; }
        public DbSet<Sinan_Observacoes> Sinan_Observacoes { get; set; }
        public DbSet<Sinan_Violencia> Sinan_Violencia { get; set; }
        public DbSet<Sinan_ViolenciaSexual> Sinan_ViolenciaSexual { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
        public DbSet<Usuario> Usuario { get; set; }              

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            }                
        }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bairro>(new BairroMap().Configure);
            modelBuilder.Entity<Logradouro>(new LogradouroMap().Configure);
            modelBuilder.Entity<Municipio>(new MunicipioMap().Configure);
            modelBuilder.Entity<Sinan>(new SinanMap().Configure);
            modelBuilder.Entity<Sinan_DadosDaOcorrencia>(new Sinan_DadosDaOcorrenciaMap().Configure);
            modelBuilder.Entity<Sinan_DadosDePessoaAtendida>(new Sinan_DadosDePessoaAtendidaMap().Configure);
            modelBuilder.Entity<Sinan_DadosDoProvavelAutorDaViolencia>(new Sinan_DadosDoProvavelAutorDaViolenciaMap().Configure);
            modelBuilder.Entity<Sinan_DadosFinais>(new Sinan_DadosFinaisMap().Configure);
            modelBuilder.Entity<Sinan_DadosGerais>(new Sinan_DadosGeraisMap().Configure);
            modelBuilder.Entity<Sinan_DadosResidencia>(new Sinan_DadosResidenciaMap().Configure);
            modelBuilder.Entity<Sinan_Encaminhamento>(new Sinan_EncaminhamentoMap().Configure);
            modelBuilder.Entity<Sinan_NotificacaoIndividual>(new Sinan_NotificacaoIndividualMap().Configure);
            modelBuilder.Entity<Sinan_Notificador>(new Sinan_NotificadorMap().Configure);
            modelBuilder.Entity<Sinan_Observacoes>(new Sinan_ObservacoesMap().Configure);
            modelBuilder.Entity<Sinan_Violencia>(new Sinan_ViolenciaMap().Configure);
            modelBuilder.Entity<Sinan_ViolenciaSexual>(new Sinan_ViolenciaSexualMap().Configure);
            modelBuilder.Entity<Unidade>(new UnidadeMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
