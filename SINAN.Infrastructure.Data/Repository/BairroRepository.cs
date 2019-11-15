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
    public class BairroRepository : Repository<Bairro>, IBairroRepository
    {
        public BairroRepository(Contexto context) 
            : base(context)
        {
        }
    }
}
