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
    public class Sinan_DadosDePessoaAtendidaAppService : AppService<Sinan_DadosDePessoaAtendida>, ISinan_DadosDePessoaAtendidaAppService
    {
        private readonly ISinan_DadosDePessoaAtendidaService _sinanDadosDePessoaAtendidaService;

        public Sinan_DadosDePessoaAtendidaAppService(ISinan_DadosDePessoaAtendidaService sinanDadosDePessoaAtendidaService) 
            : base(sinanDadosDePessoaAtendidaService)
        {
            _sinanDadosDePessoaAtendidaService = sinanDadosDePessoaAtendidaService;
        }
    }
}
