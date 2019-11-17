using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_DadosDoProvavelAutorViolenciaViewModel
    {
        [Display(Name = "Número de envolvidos")]
        public UmDoisOuMaisIgnorado? num_envolvidos { get; set; }

        [Display(Name = "Pai")]
        public SimNaoIgnorado? pai { get; set; }

        [Display(Name = "Ex-Cônjuge")]
        public SimNaoIgnorado? ex_conjugue { get; set; }

        [Display(Name = "Amigos/conhecidos")]
        public SimNaoIgnorado? amigos_conhecidos { get; set; }

        [Display(Name = "Policial/agente da lei")]
        public SimNaoIgnorado? policial_agente { get; set; }

        [Display(Name = "Mãe")]
        public SimNaoIgnorado? mae { get; set; }

        [Display(Name = "Namorado(a)")]
        public SimNaoIgnorado? namoradoa { get; set; }

        [Display(Name = "Desconhecido(a)")]
        public SimNaoIgnorado? desconhecidoa { get; set; }

        [Display(Name = "Própria pessoa")]
        public SimNaoIgnorado? propria_pessoa { get; set; }

        [Display(Name = "Padrasto")]
        public SimNaoIgnorado? padrassto { get; set; }

        [Display(Name = "Ex-Namorado(a)")]
        public SimNaoIgnorado? ex_namoradoa { get; set; }

        [Display(Name = "Cuidador(a)")]
        public SimNaoIgnorado? cuidadoraa { get; set; }

        [Display(Name = "Madrasta")]
        public SimNaoIgnorado? madrastra { get; set; }

        [Display(Name = "Filho(a)")]
        public SimNaoIgnorado? filhoa { get; set; }

        [Display(Name = "Patrão/chefe")]
        public SimNaoIgnorado? patrao_chefe { get; set; }

        [Display(Name = "Cônjuge")]
        public SimNaoIgnorado? conjugue { get; set; }

        [Display(Name = "Irmão(ã)")]
        public SimNaoIgnorado? irmaoa { get; set; }

        [Display(Name = "Pessoa com relação institucional")]
        public SimNaoIgnorado? pessoa_relacao_intituc { get; set; }

        [Display(Name = "Outros")]
        public SimNaoIgnorado? vinculo_outros { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Vinculo válido")]
        public string vinculo_outros_extenso { get; set; }

        [Display(Name = "Sexo do provável autor da violência")]
        public SexoProvavelAutorViolencia? sexo_autor { get; set; }

        [Display(Name = "Suspeita de uso de álcool")]
        public SimNaoIgnorado? uso_alcool { get; set; }

        [Display(Name = "Ciclo de vida do provável autor da violência")]
        public CicloVidaProvavelAutorViolencia? ciclo_vida_autor { get; set; }
    }
}
