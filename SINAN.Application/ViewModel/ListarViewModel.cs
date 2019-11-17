using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class ListarViewModel
    {
        public string searchNome { get; set; }

        public DateTime? searchDataNascimento { get; set; }

        public string searchCartaoSUS { get; set; }

        public ViolenciaMotivada? searchMotivoOcorrencia { get; set; }

        public DateTime? searchDataOcorrencia { get; set; }
        
        public int id { get; set; }        

        [Display(Name = "Nome do Paciente")]
        public string nome_paciente { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data Nascimento")]
        public DateTime? data_nascimento { get; set; }

        [Display(Name = "Numero Cartão SUS")]
        public string num_cartaosus { get; set; }

        [Display(Name = "Motivo Ocorrência")]
        public ViolenciaMotivada? motivo_ocorrencia { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data Ocorrência")]
        public DateTime? data_violencia { get; set; }        
    }
}
