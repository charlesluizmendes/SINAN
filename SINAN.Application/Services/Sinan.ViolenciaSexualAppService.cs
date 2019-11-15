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
    public class Sinan_ViolenciaSexualAppService : AppService<Sinan_ViolenciaSexual>, ISinan_ViolenciaSexualAppService
    {
        private readonly ISinan_ViolenciaSexualService _usuarioViolenciaSexualService;

        public Sinan_ViolenciaSexualAppService(ISinan_ViolenciaSexualService usuarioViolenciaSexualService) 
            : base(usuarioViolenciaSexualService)
        {
            _usuarioViolenciaSexualService = usuarioViolenciaSexualService;
        }
    }
}
