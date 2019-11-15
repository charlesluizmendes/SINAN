using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_EncaminhamentoViewModel
    {
        public int? rede_saude { get; set; }
        public int? conselho_do_idoso { get; set; }
        public int? delegacia_atendimento_mulher { get; set; }
        public int? rede_assistencia_social { get; set; }
        public int? delegacia_atendimento_idoso { get; set; }
        public int? outras_delegacias { get; set; }
        public int? rede_educacao { get; set; }
        public int? centro_referencia_diretos_humanos { get; set; }
        public int? justica_da_infancia_juventude { get; set; }
        public int? rede_atendimento_mulher { get; set; }
        public int? delegacia_especializada_crianca_adolecente { get; set; }
        public int? defensoria_publica { get; set; }
        public int? conselho_tutelar { get; set; }
        public int? ministerio_publico { get; set; }
    }
}
