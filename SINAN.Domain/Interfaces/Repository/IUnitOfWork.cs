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
        IRepository<T> GetRepository<T>() where T : class;        
        void Commit();
        void Dispose();
    }
}