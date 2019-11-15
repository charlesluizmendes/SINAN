using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_NotificadorViewModel
    {
        public string municipio_nome_unidade_notificadora { get; set; }
        public int? codigo_unidade_notificadora { get; set; }
        public string municipio_unidade_saude { get; set; }
        public int? codigo_unidade_saude { get; set; }
        public string nome { get; set; }
        public string funcao { get; set; }
    }
}
