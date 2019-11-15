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
    public class Sinan_NotificacaoIndividualAppService : AppService<Sinan_NotificacaoIndividual>, ISinan_NotificacaoIndividualAppService
    {
        private readonly ISinan_NotificacaoIndividualService _usuarioNotificacaoIndividualService;

        public Sinan_NotificacaoIndividualAppService(ISinan_NotificacaoIndividualService usuarioNotificacaoIndividualService) 
            : base(usuarioNotificacaoIndividualService)
        {
            _usuarioNotificacaoIndividualService = usuarioNotificacaoIndividualService;
        }
    }
}
