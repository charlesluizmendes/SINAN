using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum LocalOcorrencia
    {
        [Display(Name = "Residência")]
        Residencia = 01,

        [Display(Name = "Escola")]
        Escola = 02,

        [Display(Name = "Habitação Coletiva")]
        HabitacaoColetiva = 03,

        [Display(Name = "Local de Prática Esportiva")]
        LocalDePraticaEsportiva = 04,

        [Display(Name = "Bar ou similar")]
        BarOuSimilar = 05,

        [Display(Name = "Via Pública")]
        ViaPublica = 06,

        [Display(Name = "Comércio/Serviços")]
        ComercioServicos = 07,

        [Display(Name = "Indústria/Construção")]
        IndustriaConstrucao = 08,

        [Display(Name = "Outro")]
        Outro = 09,

        [Display(Name = "Ignorado")]
        Ignorado = 99,
    }
}
