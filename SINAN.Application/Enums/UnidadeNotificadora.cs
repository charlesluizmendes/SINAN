using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum UnidadeNotificadora
    {
        [Display(Name = "Unidade de Saúde")]
        UnidadeDeSaude = 1,

        [Display(Name = "Unidade de Assistencia Social")]
        UnidadeDeAssistenciaSocial = 2,

        [Display(Name = "Estabelecimento de Ensino")]
        EstabelecimentoDeEnsino = 3,

        [Display(Name = "Conselho Tutelar")]
        ConselhoTutelar = 4,

        [Display(Name = "Unidade de Saúde Indígena")]
        UnidadeDeSaudeIndigena = 5,

        [Display(Name = "Centro Especializado de Atendimento à Mulher")]
        CentroEspecializadoDeAtendimentoAMulher = 6,

        [Display(Name = "Outros")]
        Outros = 7
    }
}
