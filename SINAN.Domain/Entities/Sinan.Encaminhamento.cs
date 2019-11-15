using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_Encaminhamento
    {
        public virtual int id { get; set; }
        public virtual int? rede_saude { get; set; }
        public virtual int? conselho_do_idoso { get; set; }
        public virtual int? delegacia_atendimento_mulher { get; set; }
        public virtual int? rede_assistencia_social { get; set; }
        public virtual int? delegacia_atendimento_idoso { get; set; }
        public virtual int? outras_delegacias { get; set; }
        public virtual int? rede_educacao { get; set; }
        public virtual int? centro_referencia_diretos_humanos { get; set; }
        public virtual int? justica_da_infancia_juventude { get; set; }
        public virtual int? rede_atendimento_mulher { get; set; }
        public virtual int? delegacia_especializada_crianca_adolecente { get; set; }
        public virtual int? defensoria_publica { get; set; }
        public virtual int? conselho_tutelar { get; set; }
        public virtual int? ministerio_publico { get; set; }
    }
}
