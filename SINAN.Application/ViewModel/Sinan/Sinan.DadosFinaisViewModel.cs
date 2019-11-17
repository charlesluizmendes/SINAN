using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_DadosFinaisViewModel
    {
        [Display(Name = "Violência Relacionada ao Trabalho")]
        public SimNaoIgnorado? violencia_trabalho { get; set; }

        [Display(Name = "Se sim, foi emitida a Comunicação de Acidente do Trabalho(CAT)")]
        public SimNaoNaoSeAplicaIgnorado? emissao_cat { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite uma Circustância válida")]
        [Display(Name = "Circunstância da lesão")]
        public string circunstancia_lesao { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Encerramento")]
        public string data_encerramento { get; set; }
    }
}
