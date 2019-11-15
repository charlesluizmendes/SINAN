using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Interfaces
{
    public interface IAppService<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(object id);
        void Insert(T entidade);        
        void Update(T entidade);
        void Delete(T entidade);
        void Commit();
        void Dispose();
    }
}
