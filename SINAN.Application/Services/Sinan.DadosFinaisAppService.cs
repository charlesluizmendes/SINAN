using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Interfaces;
using SINAN.Domain.Interfaces.Services;
using SINAN.Domain.Entities;

namespace SINAN.Application.Services
{
    public class Sinan_DadosFinaisAppService : AppService<Sinan_DadosFinais>, ISinan_DadosFinaisAppService
    {
        private readonly ISinan_DadosFinaisService _sinanDadosFinaisService;

        public Sinan_DadosFinaisAppService(ISinan_DadosFinaisService sinanDadosFinaisService) 
            : base(sinanDadosFinaisService)
        {
            _sinanDadosFinaisService = sinanDadosFinaisService;
        }
    }
}
