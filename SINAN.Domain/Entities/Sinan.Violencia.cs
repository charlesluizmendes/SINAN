using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_Violencia
    {
        public virtual int id { get; set; }
        public virtual int? motivo_ocorrencia { get; set; }
        public virtual int? violencia_fisica { get; set; }
        public virtual int? trafico_de_humanos { get; set; }
        public virtual int? intervencao_legal { get; set; }
        public virtual int? pisicologica_mental { get; set; }
        public virtual int? financeira_economica { get; set; }
        public virtual int? tortura { get; set; }
        public virtual int? negligencia_abandono { get; set; }
        public virtual int? sexual { get; set; }
        public virtual int? trabalho_infantil { get; set; }
        public virtual int? violencia_outros { get; set; }
        public virtual string violencia_outros_extenso { get; set; }
        public virtual int? forca_corporal_espacamento { get; set; }
        public virtual int? objeto_perfurante_cortante { get; set; }
        public virtual int? arma_de_fogo { get; set; }
        public virtual int? enforcamento { get; set; }
        public virtual int? substancia_objeto_quente { get; set; }
        public virtual int? ameaca { get; set; }
        public virtual int? objeto_contindente { get; set; }
        public virtual int? envenenamento_intoxicacao { get; set; }
        public virtual int? agressao_outros { get; set; }
        public virtual string agressao_outros_extenso { get; set; }

    }
}
