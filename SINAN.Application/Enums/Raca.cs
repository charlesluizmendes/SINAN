using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum Raca
    {
        [Display(Name = "Branca")]
        Branca = 1,

        [Display(Name = "Preta")]
        Preta = 2,

        [Display(Name = "Amarela")]
        Amarela = 3,

        [Display(Name = "Parda")]
        Parda = 4,
        
        [Display(Name = "Indígena")]
        Indígena = 5,

        [Display(Name = "Ignorado")]
        Ignorado = 9,
    }
}
