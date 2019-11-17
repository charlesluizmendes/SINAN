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
        [Display(Name = "Rede da Saúde (Unidade Básica de Saúde,hospital,outras)")]
        public SimNaoIgnorado? rede_saude { get; set; }

        [Display(Name = "Conselho do Ido")]
        public SimNaoIgnorado? conselho_do_idoso { get; set; }

        [Display(Name = "Delegacia de Atendimento à Mulher")]
        public SimNaoIgnorado? delegacia_atendimento_mulher { get; set; }

        [Display(Name = "Rede da Assistência Social (CRAS, CREAS, outras)")]
        public SimNaoIgnorado? rede_assistencia_social { get; set; }

        [Display(Name = "Delegacia de Atendimento ao Idoso")]
        public SimNaoIgnorado? delegacia_atendimento_idoso { get; set; }

        [Display(Name = "Outras delegacias")]
        public SimNaoIgnorado? outras_delegacias { get; set; }

        [Display(Name = "Rede da Educação (Creche, escola, outras)")]
        public SimNaoIgnorado? rede_educacao { get; set; }

        [Display(Name = "Centro de Referência dos Direitos Humanos")]
        public SimNaoIgnorado? centro_referencia_diretos_humanos { get; set; }

        [Display(Name = "Justiça da Infância e da Juventude")]
        public SimNaoIgnorado? justica_da_infancia_juventude { get; set; }

        [Display(Name = "Rede de Atendimento à Mulher (Centro Especializado de Atendimento à Mulher, Casa da Mulher Brasileira, outras)")]
        public SimNaoIgnorado? rede_atendimento_mulher { get; set; }

        [Display(Name = "Ministério Público")]
        public SimNaoIgnorado? delegacia_especializada_crianca_adolecente { get; set; }

        [Display(Name = "Defensoria Pública")]
        public SimNaoIgnorado? defensoria_publica { get; set; }

        [Display(Name = "Conselho Tutelar")]
        public SimNaoIgnorado? conselho_tutelar { get; set; }

        [Display(Name = "Delegacia Especializada de Proteção à Criança e Adolescente")]
        public SimNaoIgnorado? ministerio_publico { get; set; }
    }
}
