using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_DadosDePessoaAtendidaViewModel
    {
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome Social válido")]
        [Display(Name = "Nome Social")]
        public string nome_social { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite uma Ocupação válida")]
        [Display(Name = "Ocupação")]
        public string ocupacao { get; set; }

        [Display(Name = "Situação Conjugal")]
        public SituacaoConjugal? situacao_conjugal { get; set; }

        [Display(Name = "Orientação Sexual")]
        public OrientacaoSexual? orientacao_sexual { get; set; }

        [Display(Name = "Identidade de Gênero")]
        public IdentidadeGenero? identidade_genero { get; set; }

        [Display(Name = "Deficiência")]
        public SimNaoNaoSeAplicaIgnorado? deficiencia { get; set; }

        [Display(Name = "Deficiência Fisica")]
        public SimNaoNaoSeAplicaIgnorado? deficiencia_fisica { get; set; }

        [Display(Name = "Deficiência Visual")]
        public SimNaoNaoSeAplicaIgnorado? deficiencia_visual { get; set; }

        [Display(Name = "Deficiência Mental")]
        public SimNaoNaoSeAplicaIgnorado? transtorno_mental { get; set; }

        [Display(Name = "Deficiência Intelectual")]
        public SimNaoNaoSeAplicaIgnorado? deficiencia_intelectual { get; set; }

        [Display(Name = "Deficiência Auditiva")]
        public SimNaoNaoSeAplicaIgnorado? deficiencia_auditiva { get; set; }

        [Display(Name = "Deficiência Comportamento")]
        public SimNaoNaoSeAplicaIgnorado? trans_de_comportamento { get; set; }

        [Display(Name = "Deficiência Outros")]
        public SimNaoNaoSeAplicaIgnorado? deficiencia_outros { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Deficiência válido")]
        [Display(Name = "Deficiência Outros")]
        public string deficiencia_outros_extenso { get; set; }
    }
}
