using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_DadosDoProvavelAutorDaViolencia
    {
        public virtual int id { get; set; }
        public virtual int? num_envolvido { get; set; }
        public virtual int? pai { get; set; }
        public virtual int? ex_conjugue { get; set; }
        public virtual int? amigos_conhecidos { get; set; }
        public virtual int? policial_agente { get; set; }
        public virtual int? mae { get; set; }
        public virtual int? namoradoa { get; set; }
        public virtual int? desconhecidoa { get; set; }
        public virtual int? propria_pessoa { get; set; }
        public virtual int? padrassto { get; set; }
        public virtual int? ex_namoradoa { get; set; }
        public virtual int? cuidadoraa { get; set; }
        public virtual int? madrastra { get; set; }
        public virtual int? filhoa { get; set; }
        public virtual int? patrao_chefe { get; set; }
        public virtual int? conjugue { get; set; }
        public virtual int? irmaoa { get; set; }
        public virtual int? pessoa_relacao_intituc { get; set; }
        public virtual int? vinculo_outros { get; set; }
        public virtual string vinculo_outros_extenso { get; set; }
        public virtual int? sexo_autor { get; set; }
        public virtual int? uso_alcool { get; set; }
        public virtual int? ciclo_vida_autor { get; set; }
    }
}
