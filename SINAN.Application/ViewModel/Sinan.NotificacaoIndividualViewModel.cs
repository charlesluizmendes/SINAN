using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;


namespace SINAN.Application.ViewModel
{
    public class Sinan_NotificacaoIndividualViewModel
    {        
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome válido")]
        [Display(Name = "Nome do Paciente")]
        public string nome_paciente { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Nascimento")]
        public string data_nascimento { get; set; }

        [MaxLength(2)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Digite uma Idade válida")]
        [Display(Name = "Idade")]
        public string idade { get; set; }

        [MaxLength(2)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Digite uma Idade válida")]
        [Display(Name = "Ou Idade")]
        public string ou_idade { get; set; }

        [Display(Name = "Sexo")]
        public Sexo? sexo { get; set; }

        [Display(Name = "Gestante")]
        public Gestante? gestante { get; set; }

        [Display(Name = "Raça")]
        public Raca? raca { get; set; }

        [Display(Name = "Escolaridade")]
        public Escolaridade? escolaridade { get; set; }

        [Display(Name = "Continua Estudando")]
        public ContinuaEstudando? continua_estudando { get; set; }

        [Display(Name = "Ano")]
        public AnoEscolaridade? ano_de_escolaridade { get; set; }

        [Display(Name = "Rede de Ensino")]
        public RedeEnsino? rede_ensino { get; set; }

        [Display(Name = "Esfera Ensino")]
        public EsferaEnsino? esfera_ensino { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Escola válido")]
        [Display(Name = "Nome da Escola")]
        public string nome_escola { get; set; }

        [MaxLength(15)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Digite um Número válida")]
        [Display(Name = "Cartão SUS")]
        public string num_cartaosus { get; set; }

        [MaxLength(11)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Digite um Número válida")]
        [Display(Name = "Cartão NIS")]
        public string num_cartaonis { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome de Mãe válido")]
        [Display(Name = "Nome da Mãe")]
        public string nome_mae { get; set; }

        [Display(Name = "Tem Nome do Pai")]
        public TemNomePaiRegistro? tem_nome_pai_registro { get; set; }
    }
}
