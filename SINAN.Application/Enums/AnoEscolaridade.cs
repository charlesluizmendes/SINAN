using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum AnoEscolaridade
    {
        [Display(Name = "Ensino Fundamental 1º ano")]
        EnsinoFundamentalPrimeiroAno = 1,

        [Display(Name = "Ensino Fundamental 2º ano")]
        EnsinoFundamentalSegundoAno = 2,

        [Display(Name = "Ensino Fundamental 3º ano")]
        EnsinoFundamentalTerceiroAno = 3,

        [Display(Name = "Ensino Fundamental 4º ano")]
        EnsinoFundamentalQaurtoAno = 4,

        [Display(Name = "Ensino Fundamental 5º ano")]
        EnsinoFundamentalQuintoAno = 5,

        [Display(Name = "Ensino Fundamental 6º ano")]
        EnsinoFundamentalSextoAno = 6,

        [Display(Name = "Ensino Fundamental 7º ano")]
        EnsinoFundamentalSetmoAno = 7,

        [Display(Name = "Ensino Fundamental 8º ano")]
        EnsinoFundamentalOitavoAno = 8,

        [Display(Name = "Ensino Fundamental 9º ano")]
        EnsinoFundamentalNonoAno = 9,

        [Display(Name = "Ensino Médio 1º ano")]
        EnsinoMedioPrimeiroAno = 10,
        
        [Display(Name = "Ensino Médio 2º ano")]
        EnsinoMedioSegundoAno = 11,
        
        [Display(Name = "Ensino Médio 3º ano")]
        EnsinoMedioTerceiroAno = 12,
        
        [Display(Name = "Ensino Superior 1º período")]
        EnsinoSuperiro1Periodo = 13,
        
        [Display(Name = "Ensino Superior 2º período")]
        EnsinoSuperiro2Periodo = 14,
        
        [Display(Name = "Ensino Superior 3º período")]
        EnsinoSuperiro3Periodo = 15,
        
        [Display(Name = "Ensino Superior 4º período")]
        EnsinoSuperiro4Periodo = 16,
        
        [Display(Name = "Ensino Superior 5º período")]
        EnsinoSuperiro5Periodo = 17,
        
        [Display(Name = "Ensino Superior 6º período")]
        EnsinoSuperiro6Periodo = 18,
        
        [Display(Name = "Ensino Superior 7º período")]
        EnsinoSuperiro7Periodo = 19,

        [Display(Name = "Ensino Superior 8º período")]
        EnsinoSuperiro8Periodo = 20,

        [Display(Name = "Ensino Superior 9º período")]
        EnsinoSuperiro9Periodo = 21,

        [Display(Name = "Ensino Superior 10º período")]
        EnsinoSuperiro10Periodo = 22,

        [Display(Name = "Ignorado")]
        Ignorado = 99,
    }
}
