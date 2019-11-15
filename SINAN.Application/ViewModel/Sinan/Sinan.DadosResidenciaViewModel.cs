using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_DadosResidenciaViewModel
    {
        [Display(Name = "UF")]
        public UF? uf_residencia { get; set; }

        [Display(Name = "Município")]
        public double? municipio_residencia { get; set; }

        [Display(Name = "Código IBGE")]
        public int? cod_ibge_residencia { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Distrito válido")]
        [Display(Name = "Distrito Residência")]
        public string distrito_residencia { get; set; }

        [Display(Name = "Bairro")]
        public double? bairro_residencia { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Logradouro válido")]
        [Display(Name = "Distrito")]
        public string logradouro_residencia { get; set; }

        [Display(Name = "Código")]
        public int? cod_residencia { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Digite um Número válido")]
        [Display(Name = "Número")]
        public int? numero_residencia { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Complemento válido")]
        [Display(Name = "Complemento")]
        public string comp_residencia { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Geo Camp 1 válido")]
        [Display(Name = "Geo Camp 1")]
        public string geo_campo1_residencia { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Geo Camp 1 válido")]
        [Display(Name = "Geo Camp 2")]
        public string geo_campo2_residencia { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Complemento válido")]
        [Display(Name = "Referência")]
        public string referencia_residencia { get; set; }

        [MaxLength(10)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "CEP")]
        public string cep { get; set; }

        [MaxLength(15)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Display(Name = "Zona")]
        public Zona? zona { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de País válido")]
        [Display(Name = "País")]
        public string pais { get; set; }
    }
}
