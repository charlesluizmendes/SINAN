using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum Gestante
    {
        [Display(Name = "1º Trimestre")]
        PrimeiroTrimestre = 1,

        [Display(Name = "2º Trimestre")]
        SegundoTrimestre = 2,

        [Display(Name = "3º Trimestre")]
        TerceiroTrimestre = 3,

        [Display(Name = "Idade gestacional ignorada")]
        IdadeGestacionalIgnorada = 4,

        [Display(Name = "Não")]
        Nao = 5,

        [Display(Name = "Não se aplica")]
        NaoSeAplica = 6,

        [Display(Name = "Ignorado")]
        Ignorado = 9,
    }
}