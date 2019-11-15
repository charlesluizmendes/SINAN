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
    public class Sinan_ObservacoesAppService : AppService<Sinan_Observacoes>, ISinan_ObservacoesAppService
    {
        private readonly ISinan_ObservacoesService _usuarioObservacoesService;

        public Sinan_ObservacoesAppService(ISinan_ObservacoesService usuarioObservacoesService) 
            : base(usuarioObservacoesService)
        {
            _usuarioObservacoesService = usuarioObservacoesService;
        }
    }
}
