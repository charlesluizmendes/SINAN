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
    public class Sinan_NotificadorAppService : AppService<Sinan_Notificador>, ISinan_NotificadorAppService
    {
        private readonly ISinan_NotificadorService _usuarioNotificadorService;

        public Sinan_NotificadorAppService(ISinan_NotificadorService usuarioNotificadorService) 
            : base(usuarioNotificadorService)
        {
            _usuarioNotificadorService = usuarioNotificadorService;
        }
    }
}
