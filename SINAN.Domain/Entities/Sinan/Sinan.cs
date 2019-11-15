using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan
    {
        public virtual int id { get; set; }
        public virtual int usu_codigo { get; set; }
        public virtual DateTime? data_envio { get; set; }
    }
}