using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_ViolenciaViewModel
    {
        [Display(Name = "Essa violência foi motivada por:")]
        public virtual ViolenciaMotivada? motivo_ocorrencia { get; set; }

        [Display(Name = "Física")]
        public virtual SimNaoIgnorado? violencia_fisica { get; set; }

        [Display(Name = "Trafico de humanos")]
        public SimNaoIgnorado? trafico_de_humanos { get; set; }

        [Display(Name = "Intervenção legal")]
        public SimNaoIgnorado? intervencao_legal { get; set; }

        [Display(Name = "Psicológica/Moral")]
        public SimNaoIgnorado? pisicologica_mental { get; set; }

        [Display(Name = "Financeira/Economica")]
        public SimNaoIgnorado? financeira_economica { get; set; }

        [Display(Name = "Tortura")]
        public SimNaoIgnorado? tortura { get; set; }

        [Display(Name = "Negligência/Abandono")]
        public SimNaoIgnorado? negligencia_abandono { get; set; }

        [Display(Name = "Sexual")]
        public SimNaoIgnorado? sexual { get; set; }

        [Display(Name = "Trabalho Infantil")]
        public SimNaoIgnorado? trabalho_infantil { get; set; }

        [Display(Name = "Outros")]
        public SimNaoIgnorado? violencia_outros { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome Social válido")]
        public string violencia_outros_extenso { get; set; }

        [Display(Name = "Força corporal/espancam.")]
        public SimNaoIgnorado? forca_corporal_espacamento { get; set; }

        [Display(Name = "Obj. pérfuro-cortante")]
        public SimNaoIgnorado? objeto_perfurante_cortante { get; set; }

        [Display(Name = "Arma de fogo")]
        public SimNaoIgnorado? arma_de_fogo { get; set; }

        [Display(Name = "Enforcamento")]
        public SimNaoIgnorado? enforcamento { get; set; }

        [Display(Name = "Substancia/Obj. quente")]
        public SimNaoIgnorado? substancia_objeto_quente { get; set; }

        [Display(Name = "Ameaça")]
        public SimNaoIgnorado? ameaca { get; set; }

        [Display(Name = "Obj. contundente")]
        public SimNaoIgnorado? objeto_contindente { get; set; }

        [Display(Name = "Envenenamento/Intoxicação")]
        public SimNaoIgnorado? envenenamento_intoxicacao { get; set; }

        [Display(Name = "Outros")]
        public SimNaoIgnorado? agressao_outros { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome Social válido")]
        public string agressao_outros_extenso { get; set; }
    }
}
