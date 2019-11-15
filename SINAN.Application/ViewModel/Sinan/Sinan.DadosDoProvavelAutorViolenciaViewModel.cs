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
        public int? num_envolvido { get; set; }
        public int? pai { get; set; }
        public int? ex_conjugue { get; set; }
        public int? amigos_conhecidos { get; set; }
        public int? policial_agente { get; set; }
        public int? mae { get; set; }
        public int? namoradoa { get; set; }
        public int? desconhecidoa { get; set; }
        public int? propria_pessoa { get; set; }
        public int? padrassto { get; set; }
        public int? ex_namoradoa { get; set; }
        public int? cuidadoraa { get; set; }
        public int? madrastra { get; set; }
        public int? filhoa { get; set; }
        public int? patrao_chefe { get; set; }
        public int? conjugue { get; set; }
        public int? irmaoa { get; set; }
        public int? pessoa_relacao_intituc { get; set; }
        public int? vinculo_outros { get; set; }
        public string vinculo_outros_extenso { get; set; }
        public int? sexo_autor { get; set; }
        public int? uso_alcool { get; set; }
        public int? ciclo_vida_autor { get; set; }
    }
}
