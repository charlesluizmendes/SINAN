using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Interfaces;
using SINAN.Domain.Interfaces.Services;

namespace SINAN.Application.Services
{
    public class AppService<T> : IAppService<T> where T : class
    {
        private readonly IService<T> _service;      

        public AppService(IService<T> service)
        {
            _service = service;
        }

        public void Delete(T entidade)
        {
            _service.Delete(entidade);
        }        

        public IEnumerable<T> Get()
        {
            return _service.Get();
        }

        public T GetById(object id)
        {
            return _service.GetById(id);
        }

        public void Insert(T entidade)
        {
            _service.Insert(entidade);
        }      

        public void Update(T entidade)
        {
            _service.Update(entidade);
        }

        public void Commit()
        {
            _service.Commit();
        }

        public void Dispose()
        {
            _service.Dispose();
        }        
    }
}
