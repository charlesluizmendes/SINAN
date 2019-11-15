using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Domain.Interfaces.Repository;
using SINAN.Infrastructure.Data.Context;

namespace SINAN.Infrastructure.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Contexto _context;       

        public Repository(Contexto context)
        {
            _context = context;
        }

        public IEnumerable<T> Get()
        {
            try
            {
                return _context.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar: " + ex.Message);
            }
        }

        public T GetById(object Id)
        {
            try
            {
                return _context.Set<T>().Find(Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar: " + ex.Message);
            }
        }

        public void Insert(T entidade)
        {
            try
            {
                _context.Set<T>().Add(entidade);               
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir: " + ex.Message);
            }
        }

        public void Update(T entidade)
        {
            try
            {
                _context.Entry(entidade).State = Microsoft.EntityFrameworkCore.EntityState.Modified;               
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Alterar: " + ex.Message);
            }
        }

        public void Delete(T entidade)
        {
            try
            {
                _context.Set<T>().Remove(entidade);                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Excluir: " + ex.Message);
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
