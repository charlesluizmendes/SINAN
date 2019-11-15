using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Domain.Interfaces.Services;
using SINAN.Domain.Interfaces.Repository;

namespace SINAN.Domain.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Delete(T entidade)
        {
            _repository.Delete(entidade);
        }        

        public IEnumerable<T> Get()
        {
            return _repository.Get();
        }

        public T GetById(object id)
        {
            return _repository.GetById(id);
        }

        public void Insert(T entidade)
        {
            _repository.Insert(entidade);
        }               

        public void Update(T entidade)
        {
            _repository.Update(entidade);
        }

        public void Commit()
        {
            _repository.Commit();         
        }

        public void Dispose()
        {
            _repository.Dispose();            
        }       
    }
}
