using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_Notificador
    {
        public virtual int id { get; set; }
        public virtual string municipio_nome_unidade_notificadora { get; set; }
        public virtual int? codigo_unidade_notificadora { get; set; }
        public virtual string municipio_unidade_saude { get; set; }
        public virtual int? codigo_unidade_saude { get; set; }
        public virtual string nome { get; set; }
        public virtual string funcao { get; set; }
    }
}
