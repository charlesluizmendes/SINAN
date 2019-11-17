using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class SinanViewModel
    {

        public int? Id { get; set; }

        public int? usu_codigo { get; set; }

        public DateTime? data_envio { get; set; }

        // Dados Gerias

        public Sinan_DadosGeraisViewModel Sinan_DadosGeraisViewModel { get; set; }

        // Notificação Individual

        public Sinan_NotificacaoIndividualViewModel Sinan_NotificacaoIndividualViewModel { get; set; }

        // Dados de Residência

        public Sinan_DadosResidenciaViewModel Sinan_DadosResidenciaViewModel { get; set; }

        // Dados de Pessoa Atendida

        public Sinan_DadosDePessoaAtendidaViewModel Sinan_DadosDePessoaAtendidaViewModel { get; set; }

        // Dados da Ocorrencia

        public Sinan_DadosDaOcorrenciaViewModel Sinan_DadosDaOcorrenciaViewModel { get; set; }

        // Violencia

        public Sinan_ViolenciaViewModel Sinan_ViolenciaViewModel { get; set; }

        // Violência Sexual

        public Sinan_ViolenciaSexualViewModel Sinan_ViolenciaSexualViewModel { get; set; }

        // Dados do provavel autor da Violência
        
        public Sinan_DadosDoProvavelAutorViolenciaViewModel Sinan_DadosDoProvavelAutorViolenciaViewModel { get; set; }

        // Encaminhamento

        public Sinan_EncaminhamentoViewModel Sinan_EncaminhamentoViewModel { get; set; }


        // Dados Finais

        public Sinan_DadosFinaisViewModel Sinan_DadosFinaisViewModel { get; set; }

        // Observações

        public Sinan_ObservacoesViewModel Sinan_ObservacoesViewModel { get; set; }

        // Notificador

        public Sinan_NotificadorViewModel Sinan_NotificadorViewModel { get; set; }

    }
}
