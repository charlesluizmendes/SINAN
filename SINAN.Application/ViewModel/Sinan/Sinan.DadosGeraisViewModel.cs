using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_DadosGeraisViewModel
    {
        [Display(Name = "Tipo Notificação")]
        public TipoNotificacao? tipo_notificacao { get; set; }

        [MaxLength(255)]
        [Display(Name = "Agravo")]
        public string agravo { get; set; }

        [MaxLength(255)]
        [Display(Name = "Codigo CID10")]
        public string codigo_cid10 { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Notificação")]
        public string data_notificacao { get; set; }

        [Display(Name = "UF")]
        public UF? uf_origem { get; set; }

        [Display(Name = "Municipio")]
        public double? mun_origem { get; set; }

        [Display(Name = "Código IBGE")]
        public int? cod_ibge { get; set; }

        [Display(Name = "Unidade Notificadora")]
        public UnidadeNotificadora? unidade_notificadora { get; set; } 
      
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Unidade válido")]
        [Display(Name = "Nome Unidade Notificadora")]
        public string nome_unidade_notificadora { get; set; }

        [Display(Name = "Código da Unidade")]
        public int? cod_unidade { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data da Violência")]
        public string data_violencia { get; set; }

        [Display(Name = "Unidade de Saúde")]
        public int? unidade_saude { get; set; }

        [Display(Name = "Código CNES")]
        public int? cod_cnes { get; set; }
    }
}
