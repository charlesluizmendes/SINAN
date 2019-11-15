using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_ObservacoesViewModel
    {
        public string nome_acompanhate { get; set; }
        public string vinculo_acompanhate { get; set; }
        public string telefone_acompanhate { get; set; }
        public string obs { get; set; }
    }
}
