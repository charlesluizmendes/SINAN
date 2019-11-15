using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_DadosGerais
    {
        public virtual int? id { get; set; }
        public virtual int? tipo_notificacao { get; set; }
        public virtual string agravo { get; set; }
        public virtual string codigo_cid10 { get; set; }
        public virtual DateTime? data_notificacao { get; set; }
        public virtual string uf_origem { get; set; }
        public virtual double? mun_origem { get; set; }
        public virtual int? cod_ibge { get; set; }
        public virtual int? unidade_notificadora { get; set; }
        public virtual string nome_unidade_notificadora { get; set; }
        public virtual int? cod_unidade { get; set; }
        public virtual DateTime? data_violencia { get; set; }
        public virtual int? unidade_saude { get; set; }
        public virtual int? cod_cnes { get; set; }
    }
}
