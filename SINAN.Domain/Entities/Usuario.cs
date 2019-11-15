using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Usuario
    {
        public virtual int usu_codigo { get; set; }
        public virtual string usu_nome { get; set; }
        public virtual string usu_cpf { get; set; }
        public virtual string usu_email { get; set; }
        public virtual string usu_telefone { get; set; }
        public virtual string usu_senha { get; set; }
        public virtual DateTime usu_datacadastro { get; set; }
        public virtual string usu_perfil { get; set; }
        public virtual bool usu_ativo { get; set; }
    }
}
