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
    public class LogradouroAppService : AppService<Logradouro>, ILogradouroAppService
    {
        private readonly ILogradouroService _logradouroService;

        public LogradouroAppService(ILogradouroService logradouroService) 
            : base(logradouroService)
        {
            _logradouroService = logradouroService;
        }
    }
}