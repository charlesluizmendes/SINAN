using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum ViolenciaMotivada
    {
        [Display(Name = "Sexismo")]
        Sexismo = 01,

        [Display(Name = "Homofobia/Lesbofobia/Bifobia/Transfobia")]
        HomofobiaLesbofobiaBifobiaTransfobia = 02,

        [Display(Name = "Racismo")]
        Racismo = 03,

        [Display(Name = "Xenofobia")]
        Xenofobia = 04,

        [Display(Name = "Intolerância religiosa")]
        Intolerânciareligiosa = 05,      

        [Display(Name = "Conflito Geracional")]
        ConflitoGeracional = 06,

        [Display(Name = "Situação de rua")]
        SituaçãodeRua = 07,

        [Display(Name = "Outros")]
        Outros = 09,

        [Display(Name = "Não se aplica")]
        NaoSeAplica = 88,

        [Display(Name = "Ignorado")]
        Ignorado = 99,
    }
}
