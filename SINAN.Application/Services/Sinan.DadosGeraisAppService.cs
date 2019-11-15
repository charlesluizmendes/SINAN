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
    public class Sinan_DadosGeraisAppService : AppService<Sinan_DadosGerais>, ISinan_DadosGeraisAppService
    {
        private readonly ISinan_DadosGeraisService _usuarioDadosGeraisService;

        public Sinan_DadosGeraisAppService(ISinan_DadosGeraisService usuarioDadosGeraisService) 
            : base(usuarioDadosGeraisService)
        {
            _usuarioDadosGeraisService = usuarioDadosGeraisService;
        }
    }
}
