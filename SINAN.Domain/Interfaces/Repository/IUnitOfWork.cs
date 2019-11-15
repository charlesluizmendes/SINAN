using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Domain.Entities;

namespace SINAN.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {       
        IRepository<Sinan> sinan { get; }
        IRepository<Sinan_DadosGerais> sinanDadosGerais { get; }
        IRepository<Sinan_NotificacaoIndividual> sinanNotificacaoIndividual { get; }
        IRepository<Sinan_DadosResidencia> sinanDadosResidencia { get; }
        IRepository<Sinan_DadosDePessoaAtendida> sinanDadosDePessoaAtendida { get; }
        IRepository<Sinan_DadosDaOcorrencia> sinanDadosDaOcorrencia { get; }
        IRepository<Sinan_Violencia> sinanViolencia { get; }
        IRepository<Sinan_ViolenciaSexual> sinanViolenciaSexual { get; }
        IRepository<Sinan_DadosDoProvavelAutorDaViolencia> sinanDadosDoProvavelAutorDaViolencia { get; }
        IRepository<Sinan_Encaminhamento> sinanEncaminhamento { get; }
        IRepository<Sinan_DadosFinais> sinanDadosFinais { get; }
        IRepository<Sinan_Observacoes> sinanObservacoes { get; }
        IRepository<Sinan_Notificador> sinanNotificador { get; }
        void Commit();
        void Dispose();
    }
}