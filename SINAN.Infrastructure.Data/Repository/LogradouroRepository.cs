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
    public class LogradouroRepository : Repository<Logradouro>, ILogradouroRepository
    {
        public LogradouroRepository(Contexto context) 
            : base(context)
        {
        }
    }
}
