using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_DadosDaOcorrenciaViewModel
    {
        [Display(Name = "UF")]
        public UF? uf_ocorrencia { get; set; }

        [Display(Name = "Município")]
        public double? mun_ocorrencia { get; set; }

        [Display(Name = "Código IBGE")]
        public int? cod_ibge_ocorrencia { get; set; }

        [MaxLength(255)]        
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Distrito válido")]
        [Display(Name = "Distrito")]
        public string destrito_ocorrencia { get; set; }

        [Display(Name = "Bairro")]
        public double? bairro_ocorrencia { get; set; }

        [MaxLength(255)]        
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Distrito válido")]
        [Display(Name = "Logradouro")]
        public string lograd_ocorrencia { get; set; }

        [Display(Name = "Código")]
        public int? cod_ocorrencia { get; set; }

        [MaxLength(255)]        
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Digite um Número válido")]
        [Display(Name = "Número")]
        public int? numero_ocorrencia { get; set; }

        [MaxLength(255)]        
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Distrito válido")]
        [Display(Name = "Complemento")]
        public string comp_ocorrencia { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Geo Camp 1 válido")]
        [Display(Name = "Geo Camp 1")]
        public string geo_campo3_ocorrencia { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Geo Camp 1 válido")]
        [Display(Name = "Geo Camp 2")]
        public string geo_campo4_ocorrencia { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Complemento válido")]
        [Display(Name = "Referência")]
        public string referencia_ocorrencia { get; set; }

        [Display(Name = "Zona")]
        public Zona? zona_ocorrencia { get; set; }

        [MaxLength(15)]
        [DataType(DataType.Time)]
        [Display(Name = "Telefone")]
        public string hora_ocorrencia { get; set; }

        [Display(Name = "Local de Ocorrência")]
        public LocalOcorrencia? local_ocorrencia { get; set; }

        [Display(Name = "Ocorreu Outras Vezes?")]
        public SimNaoIgnorado? ocorrencia_repetida { get; set; }

        [Display(Name = "A Lessão foi Autoprovocada?")]
        public SimNaoIgnorado? autoprovocada { get; set; }
    }
}
