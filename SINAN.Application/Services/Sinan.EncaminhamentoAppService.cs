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
    public class Sinan_EncaminhamentoAppService : AppService<Sinan_Encaminhamento>, ISinan_EncaminhamentoAppService
    {
        private readonly ISinan_EncaminhamentoService _usuarioEncaminhamentoService;

        public Sinan_EncaminhamentoAppService(ISinan_EncaminhamentoService usuarioEncaminhamentoService) 
            : base(usuarioEncaminhamentoService)
        {
            _usuarioEncaminhamentoService = usuarioEncaminhamentoService;
        }
    }
}
