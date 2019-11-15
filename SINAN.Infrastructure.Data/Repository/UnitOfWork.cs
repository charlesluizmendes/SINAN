using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Domain.Interfaces.Repository;
using SINAN.Domain.Entities;
using SINAN.Infrastructure.Data.Context;

namespace SINAN.Infrastructure.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Contexto _context;

        private Repository<Sinan> _sinan = null;
        private Repository<Sinan_DadosGerais> _sinanDadosGerais = null;
        private Repository<Sinan_NotificacaoIndividual> _sinanNotificacaoIndividual = null;
        private Repository<Sinan_DadosResidencia> _sinanDadosResidencia = null;
        private Repository<Sinan_DadosDePessoaAtendida> _sinanDadosDePessoaAtendida = null;
        private Repository<Sinan_DadosDaOcorrencia> _sinanDadosDaOcorrencia = null;
        private Repository<Sinan_Violencia> _sinanViolencia = null;
        private Repository<Sinan_ViolenciaSexual> _sinanViolenciaSexual = null;
        private Repository<Sinan_DadosDoProvavelAutorDaViolencia> _sinanDadosDoProvavelAutorDaViolencia = null;
        private Repository<Sinan_Encaminhamento> _sinanEncaminhamento = null;
        private Repository<Sinan_DadosFinais> _sinanDadosFinais = null;
        private Repository<Sinan_Observacoes> _sinanObservacoes = null;
        private Repository<Sinan_Notificador> _sinanNotificador = null;

        public UnitOfWork(Contexto context)
        {
            _context = context;
        }

        public IRepository<Sinan> sinan
        {
            get
            {
                if (_sinan == null)
                {
                    _sinan = new Repository<Sinan>(_context);
                }

                return _sinan;
            }
        }

        public IRepository<Sinan_DadosGerais> sinanDadosGerais
        {
            get
            {
                if (_sinanDadosGerais == null)
                {
                    _sinanDadosGerais = new Repository<Sinan_DadosGerais>(_context);
                }

                return _sinanDadosGerais;
            }
        }

        public IRepository<Sinan_NotificacaoIndividual> sinanNotificacaoIndividual
        {
            get
            {
                if (_sinanNotificacaoIndividual == null)
                {
                    _sinanNotificacaoIndividual = new Repository<Sinan_NotificacaoIndividual>(_context);
                }

                return _sinanNotificacaoIndividual;
            }
        }

        public IRepository<Sinan_DadosResidencia> sinanDadosResidencia
        {
            get
            {
                if (_sinanDadosResidencia == null)
                {
                    _sinanDadosResidencia = new Repository<Sinan_DadosResidencia>(_context);
                }

                return _sinanDadosResidencia;
            }
        }

        public IRepository<Sinan_DadosDePessoaAtendida> sinanDadosDePessoaAtendida
        {
            get
            {
                if (_sinanDadosDePessoaAtendida == null)
                {
                    _sinanDadosDePessoaAtendida = new Repository<Sinan_DadosDePessoaAtendida>(_context);
                }

                return _sinanDadosDePessoaAtendida;
            }
        }

        public IRepository<Sinan_DadosDaOcorrencia> sinanDadosDaOcorrencia
        {
            get
            {
                if (_sinanDadosDaOcorrencia == null)
                {
                    _sinanDadosDaOcorrencia = new Repository<Sinan_DadosDaOcorrencia>(_context);
                }

                return _sinanDadosDaOcorrencia;
            }
        }

        public IRepository<Sinan_Violencia> sinanViolencia
        {
            get
            {
                if (_sinanViolencia == null)
                {
                    _sinanViolencia = new Repository<Sinan_Violencia>(_context);
                }

                return _sinanViolencia;
            }
        }

        public IRepository<Sinan_ViolenciaSexual> sinanViolenciaSexual
        {
            get
            {
                if (_sinanViolenciaSexual == null)
                {
                    _sinanViolenciaSexual = new Repository<Sinan_ViolenciaSexual>(_context);
                }

                return _sinanViolenciaSexual;
            }
        }

        public IRepository<Sinan_DadosDoProvavelAutorDaViolencia> sinanDadosDoProvavelAutorDaViolencia
        {
            get
            {
                if (_sinanDadosDoProvavelAutorDaViolencia == null)
                {
                    _sinanDadosDoProvavelAutorDaViolencia = new Repository<Sinan_DadosDoProvavelAutorDaViolencia>(_context);
                }

                return _sinanDadosDoProvavelAutorDaViolencia;
            }
        }

        public IRepository<Sinan_Encaminhamento> sinanEncaminhamento
        {
            get
            {
                if (_sinanEncaminhamento == null)
                {
                    _sinanEncaminhamento = new Repository<Sinan_Encaminhamento>(_context);
                }

                return _sinanEncaminhamento;
            }
        }

        public IRepository<Sinan_DadosFinais> sinanDadosFinais
        {
            get
            {
                if (_sinanDadosFinais == null)
                {
                    _sinanDadosFinais = new Repository<Sinan_DadosFinais>(_context);
                }

                return _sinanDadosFinais;
            }
        }

        public IRepository<Sinan_Observacoes> sinanObservacoes
        {
            get
            {
                if (_sinanObservacoes == null)
                {
                    _sinanObservacoes = new Repository<Sinan_Observacoes>(_context);
                }

                return _sinanObservacoes;
            }
        }

        public IRepository<Sinan_Notificador> sinanNotificador
        {
            get
            {
                if (_sinanNotificador == null)
                {
                    _sinanNotificador = new Repository<Sinan_Notificador>(_context);
                }

                return _sinanNotificador;
            }
        }        

        public void Commit()
        {
            _context.SaveChanges();
        }

        #region

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this.disposed = true;
        }        

        #endregion
    }
}
