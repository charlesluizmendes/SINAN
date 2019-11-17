using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_ObservacoesViewModel
    {
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite uma Nome de Acompanhante válido")]
        [Display(Name = "Nome do acompanhante")]
        public string nome_acompanhate { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Vinculo válido")]
        [Display(Name = "Vínculo/grau de parent")]
        public string vinculo_acompanhate { get; set; }

        [MaxLength(15)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string telefone_acompanhate { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite uma Observação válida")]
        [Display(Name = "Observações Adicionais")]
        public string obs { get; set; }
    }
}
