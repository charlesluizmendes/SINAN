using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum Escolaridade
    {
        [Display(Name = "Analfabeto")]
        Analfabeto = 0,

        [Display(Name = "1ª a 4ª série incompleta do EF (antigo primário ou 1º grau)")]
        PrimeiraAQuartaSerieIncompletaDoEF = 1,

        [Display(Name = "4ª série completa do EF (antigo primário ou 1º grau)")]
        QuartaSerieCompleta = 2,

        [Display(Name = "5ª a 8ª série incompleta do EF (antigo ginásio ou 1º grau)")]
        QuintaAOitavaSerieIncompletaDoEF = 3,

        [Display(Name = "Ensino fundamental completo (antigo ginásio ou 1º grau)")]
        QuintaAOitavaSerieCompleto = 4,

        [Display(Name = "Ensino médio incompleto (antigo colegial ou 2º grau)")]
        EnsinoMedioIncompleto = 5,

        [Display(Name = "Ensino médio completo (antigo colegial ou 2º grau)")]
        EnsinoMedioCompleto = 6,

        [Display(Name = "Educação superior incompleta")]
        EducacaoSuperioIncompleta = 7,

        [Display(Name = "Educação superior completa")]
        EducacaoSuperiroCompleta = 8,

        [Display(Name = "Ignorado")]
        Ignorado = 9,

        [Display(Name = "Não se Aplica")]
        NaoSeAplica = 10,
    }
}
