using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_NotificadorViewModel
    {
        [Display(Name = "Município/Unidade de Saúde")]
        public string municipio_nome_unidade_notificadora { get; set; }

        [Display(Name = "Cód. da Unid. de Saúde/CNE")]
        public int? codigo_unidade_notificadora { get; set; }

        [Display(Name = "Município/Unidade Notificadora")]
        public string municipio_unidade_saude { get; set; }

        [Display(Name = "Código Unidade")]
        public int? codigo_unidade_saude { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome válido")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite uma Função válida")]
        [Display(Name = "Função")]
        public string funcao { get; set; }
    }
}
