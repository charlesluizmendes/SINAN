using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_NotificacaoIndividual
    {
        public virtual int id { get; set; }
        public virtual string nome_paciente { get; set; }
        public virtual DateTime? data_nascimento { get; set; }
        public virtual string idade { get; set; }
        public virtual int? ou_idade { get; set; }
        public virtual string sexo { get; set; }
        public virtual int? gestante { get; set; }
        public virtual int? raca { get; set; }
        public virtual int? escolaridade { get; set; }
        public virtual int? continua_estudando { get; set; }
        public virtual int? ano_de_escolaridade { get; set; }
        public virtual int? rede_ensino { get; set; }
        public virtual int? esfera_ensino { get; set; }
        public virtual string nome_escola { get; set; }
        public virtual string num_cartaosus { get; set; }
        public virtual string num_cartaonis { get; set; }
        public virtual string nome_mae { get; set; }
        public virtual int? tem_nome_pai_registro { get; set; }
    }
}
