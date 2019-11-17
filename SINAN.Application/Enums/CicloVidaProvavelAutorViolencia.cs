using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum CicloVidaProvavelAutorViolencia
    {
        [Display(Name = "Criança (0 a 9 anos)")]
        Crianca = 1,

        [Display(Name = "Adolecente (10 a 19 anos)")]
        Adolecente = 2,

        [Display(Name = "Jovem (20 a 24 anos)")]
        Jovem = 3,

        [Display(Name = "Pessoa adulta (25 a 59 anos)")]
        PessoaAdulta = 4,

        [Display(Name = "Pessoa idosa (60 anos ou mais)")]
        PessoaIdosa = 5,

        [Display(Name = "Ignorado")]
        Ignorado = 9,
    }
}
