using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SINAN.Domain.Entities;
using SINAN.Application.ViewModel;
using SINAN.Application.Enums;

namespace SINAN.Application.AutoMapper
{
    public class EntitiesToViewModel : Profile
    {
        public override string ProfileName
        {
            get { return this.GetType().Name; }
        }

        public EntitiesToViewModel()
        {
            CreateMap<Usuario, LoginViewModel>();
            CreateMap<Usuario, RecuperarSenhaViewModel>();
            CreateMap<Usuario, AlterarSenhaViewModel>();
            CreateMap<Usuario, CriarContaViewModel>();
            CreateMap<Sinan_DadosGerais, Sinan_DadosGeraisViewModel>()
                .AfterMap((e, v) => v.tipo_notificacao = (TipoNotificacao)e.tipo_notificacao)
                .AfterMap((e, v) => v.unidade_notificadora = (UnidadeNotificadora)e.unidade_notificadora)
                .AfterMap((e, v) => v.data_notificacao = e.data_notificacao == null ? null : Convert.ToDateTime(e.data_notificacao).ToString("yyyy-MM-dd"))
                .AfterMap((e, v) => v.data_violencia = e.data_violencia == null ? null : Convert.ToDateTime(e.data_violencia).ToString("yyyy-MM-dd"));
            CreateMap<Sinan_NotificacaoIndividual, Sinan_NotificacaoIndividualViewModel>()
                .AfterMap((e, v) => v.data_nascimento = e.data_nascimento == null ? null : Convert.ToDateTime(e.data_nascimento).ToString("yyyy-MM-dd"))
                .AfterMap((e, v) => v.ou_idade = (OuIdade)e.ou_idade)
                .AfterMap((e, v) => v.gestante = (Gestante)e.gestante)
                .AfterMap((e, v) => v.raca = (Raca)e.raca)
                .AfterMap((e, v) => v.escolaridade = (Escolaridade)e.escolaridade)
                .AfterMap((e, v) => v.continua_estudando = (SimNaoNaoSeAplicaIgnorado)e.continua_estudando)
                .AfterMap((e, v) => v.ano_de_escolaridade = (AnoEscolaridade)e.ano_de_escolaridade)
                .AfterMap((e, v) => v.rede_ensino = (RedeEnsino)e.rede_ensino)
                .AfterMap((e, v) => v.esfera_ensino = (EsferaEnsino)e.esfera_ensino)
                .AfterMap((e, v) => v.tem_nome_pai_registro = (SimNaoIgnorado)e.tem_nome_pai_registro);
            CreateMap<Sinan_DadosResidencia, Sinan_DadosResidenciaViewModel>()
                .AfterMap((e, v) => v.zona = (Zona)e.zona);
            CreateMap<Sinan_DadosDePessoaAtendida, Sinan_DadosDePessoaAtendidaViewModel>()
                .AfterMap((e, v) => v.situacao_conjugal = (SituacaoConjugal)e.situacao_conjugal)
                .AfterMap((e, v) => v.orientacao_sexual = (OrientacaoSexual)e.orientacao_sexual)
                .AfterMap((e, v) => v.identidade_genero = (IdentidadeGenero)e.identidade_genero)
                .AfterMap((e, v) => v.deficiencia = (SimNaoNaoSeAplicaIgnorado)e.deficiencia)
                .AfterMap((e, v) => v.deficiencia_fisica = (SimNaoNaoSeAplicaIgnorado)e.deficiencia_fisica)
                .AfterMap((e, v) => v.deficiencia_visual = (SimNaoNaoSeAplicaIgnorado)e.deficiencia_visual)
                .AfterMap((e, v) => v.transtorno_mental = (SimNaoNaoSeAplicaIgnorado)e.transtorno_mental)
                .AfterMap((e, v) => v.deficiencia_intelectual = (SimNaoNaoSeAplicaIgnorado)e.deficiencia_intelectual)
                .AfterMap((e, v) => v.deficiencia_auditiva = (SimNaoNaoSeAplicaIgnorado)e.deficiencia_auditiva)
                .AfterMap((e, v) => v.trans_de_comportamento = (SimNaoNaoSeAplicaIgnorado)e.trans_de_comportamento)
                .AfterMap((e, v) => v.deficiencia_outros = (SimNaoNaoSeAplicaIgnorado)e.deficiencia_outros);
            CreateMap<Sinan_DadosDaOcorrencia, Sinan_DadosDaOcorrenciaViewModel>()
                .AfterMap((e, v) => v.zona_ocorrencia = (Zona)e.zona_ocorrencia)
                .AfterMap((e, v) => v.local_ocorrencia = (LocalOcorrencia)e.local_ocorrencia)
                .AfterMap((e, v) => v.ocorrencia_repetida = (SimNaoIgnorado)e.ocorrencia_repetida)
                .AfterMap((e, v) => v.autoprovocada = (SimNaoIgnorado)e.autoprovocada);
            CreateMap<Sinan_Violencia, Sinan_ViolenciaViewModel>()
                .AfterMap((e, v) => v.motivo_ocorrencia = (ViolenciaMotivada)e.motivo_ocorrencia)
                .AfterMap((e, v) => v.violencia_fisica = (SimNaoIgnorado)e.violencia_fisica)
                .AfterMap((e, v) => v.trafico_de_humanos = (SimNaoIgnorado)e.trafico_de_humanos)
                .AfterMap((e, v) => v.intervencao_legal = (SimNaoIgnorado)e.intervencao_legal)
                .AfterMap((e, v) => v.pisicologica_mental = (SimNaoIgnorado)e.pisicologica_mental)
                .AfterMap((e, v) => v.financeira_economica = (SimNaoIgnorado)e.financeira_economica)
                .AfterMap((e, v) => v.tortura = (SimNaoIgnorado)e.tortura)
                .AfterMap((e, v) => v.negligencia_abandono = (SimNaoIgnorado)e.negligencia_abandono)
                .AfterMap((e, v) => v.sexual = (SimNaoIgnorado)e.sexual)
                .AfterMap((e, v) => v.trabalho_infantil = (SimNaoIgnorado)e.trabalho_infantil)
                .AfterMap((e, v) => v.violencia_outros = (SimNaoIgnorado)e.violencia_outros)
                .AfterMap((e, v) => v.forca_corporal_espacamento = (SimNaoIgnorado)e.forca_corporal_espacamento)
                .AfterMap((e, v) => v.objeto_perfurante_cortante = (SimNaoIgnorado)e.objeto_perfurante_cortante)
                .AfterMap((e, v) => v.arma_de_fogo = (SimNaoIgnorado)e.arma_de_fogo)
                .AfterMap((e, v) => v.enforcamento = (SimNaoIgnorado)e.enforcamento)
                .AfterMap((e, v) => v.substancia_objeto_quente = (SimNaoIgnorado)e.substancia_objeto_quente)
                .AfterMap((e, v) => v.ameaca = (SimNaoIgnorado)e.ameaca)
                .AfterMap((e, v) => v.objeto_contindente = (SimNaoIgnorado)e.objeto_contindente)
                .AfterMap((e, v) => v.envenenamento_intoxicacao = (SimNaoIgnorado)e.envenenamento_intoxicacao)
                .AfterMap((e, v) => v.agressao_outros = (SimNaoIgnorado)e.agressao_outros);
            CreateMap<Sinan_ViolenciaSexual, Sinan_ViolenciaSexualViewModel>()
                .AfterMap((e, v) => v.assedio_sexual = (SimNaoNaoSeAplicaIgnorado)e.assedio_sexual)
                .AfterMap((e, v) => v.estupro = (SimNaoNaoSeAplicaIgnorado)e.estupro)
                .AfterMap((e, v) => v.pornorafia_infantil = (SimNaoNaoSeAplicaIgnorado)e.pornorafia_infantil)
                .AfterMap((e, v) => v.exploracao_sexual = (SimNaoNaoSeAplicaIgnorado)e.exploracao_sexual)
                .AfterMap((e, v) => v.outros_violencia_sexual = (SimNaoNaoSeAplicaIgnorado)e.outros_violencia_sexual)
                .AfterMap((e, v) => v.profilaxia_dst = (SimNaoNaoSeAplicaIgnorado)e.profilaxia_dst)
                .AfterMap((e, v) => v.porfilaxia_hepatite_b = (SimNaoNaoSeAplicaIgnorado)e.porfilaxia_hepatite_b)
                .AfterMap((e, v) => v.coleta_de_semen = (SimNaoNaoSeAplicaIgnorado)e.coleta_de_semen)
                .AfterMap((e, v) => v.contracepcao_de_emergencia = (SimNaoNaoSeAplicaIgnorado)e.contracepcao_de_emergencia)
                .AfterMap((e, v) => v.profilacia_hiv = (SimNaoNaoSeAplicaIgnorado)e.profilacia_hiv)
                .AfterMap((e, v) => v.coleta_de_sangue = (SimNaoNaoSeAplicaIgnorado)e.coleta_de_sangue)
                .AfterMap((e, v) => v.coleta_de_secrecao_vaginal = (SimNaoNaoSeAplicaIgnorado)e.coleta_de_secrecao_vaginal)
                .AfterMap((e, v) => v.aborto_previsto_em_lei = (SimNaoNaoSeAplicaIgnorado)e.aborto_previsto_em_lei);
            CreateMap<Sinan_DadosDoProvavelAutorDaViolencia, Sinan_DadosDoProvavelAutorViolenciaViewModel>()
                .AfterMap((e, v) => v.num_envolvidos = (UmDoisOuMaisIgnorado)e.num_envolvidos)
                .AfterMap((e, v) => v.pai = (SimNaoIgnorado)e.pai)
                .AfterMap((e, v) => v.ex_conjugue = (SimNaoIgnorado)e.ex_conjugue)
                .AfterMap((e, v) => v.amigos_conhecidos = (SimNaoIgnorado)e.amigos_conhecidos)
                .AfterMap((e, v) => v.policial_agente = (SimNaoIgnorado)e.policial_agente)
                .AfterMap((e, v) => v.mae = (SimNaoIgnorado)e.mae)
                .AfterMap((e, v) => v.namoradoa = (SimNaoIgnorado)e.namoradoa)
                .AfterMap((e, v) => v.desconhecidoa = (SimNaoIgnorado)e.desconhecidoa)
                .AfterMap((e, v) => v.propria_pessoa = (SimNaoIgnorado)e.propria_pessoa)
                .AfterMap((e, v) => v.padrassto = (SimNaoIgnorado)e.padrassto)
                .AfterMap((e, v) => v.ex_namoradoa = (SimNaoIgnorado)e.ex_namoradoa)
                .AfterMap((e, v) => v.cuidadoraa = (SimNaoIgnorado)e.cuidadoraa)
                .AfterMap((e, v) => v.madrastra = (SimNaoIgnorado)e.madrastra)
                .AfterMap((e, v) => v.filhoa = (SimNaoIgnorado)e.filhoa)
                .AfterMap((e, v) => v.patrao_chefe = (SimNaoIgnorado)e.patrao_chefe)
                .AfterMap((e, v) => v.conjugue = (SimNaoIgnorado)e.conjugue)
                .AfterMap((e, v) => v.irmaoa = (SimNaoIgnorado)e.irmaoa)
                .AfterMap((e, v) => v.pessoa_relacao_intituc = (SimNaoIgnorado)e.pessoa_relacao_intituc)
                .AfterMap((e, v) => v.vinculo_outros = (SimNaoIgnorado)e.vinculo_outros)
                .AfterMap((e, v) => v.sexo_autor = (SexoProvavelAutorViolencia)e.sexo_autor)
                .AfterMap((e, v) => v.uso_alcool = (SimNaoIgnorado)e.uso_alcool)
                .AfterMap((e, v) => v.ciclo_vida_autor = (CicloVidaProvavelAutorViolencia)e.ciclo_vida_autor);
            CreateMap<Sinan_Encaminhamento, Sinan_EncaminhamentoViewModel>()
                .AfterMap((e, v) => v.rede_saude = (SimNaoIgnorado)e.rede_saude)
                .AfterMap((e, v) => v.conselho_do_idoso = (SimNaoIgnorado)e.conselho_do_idoso)
                .AfterMap((e, v) => v.delegacia_atendimento_mulher = (SimNaoIgnorado)e.delegacia_atendimento_mulher)
                .AfterMap((e, v) => v.rede_assistencia_social = (SimNaoIgnorado)e.rede_assistencia_social)
                .AfterMap((e, v) => v.delegacia_atendimento_idoso = (SimNaoIgnorado)e.delegacia_atendimento_idoso)
                .AfterMap((e, v) => v.outras_delegacias = (SimNaoIgnorado)e.outras_delegacias)
                .AfterMap((e, v) => v.rede_educacao = (SimNaoIgnorado)e.rede_educacao)
                .AfterMap((e, v) => v.centro_referencia_diretos_humanos = (SimNaoIgnorado)e.centro_referencia_diretos_humanos)
                .AfterMap((e, v) => v.justica_da_infancia_juventude = (SimNaoIgnorado)e.justica_da_infancia_juventude)
                .AfterMap((e, v) => v.rede_atendimento_mulher = (SimNaoIgnorado)e.rede_atendimento_mulher)
                .AfterMap((e, v) => v.delegacia_especializada_crianca_adolecente = (SimNaoIgnorado)e.delegacia_especializada_crianca_adolecente)
                .AfterMap((e, v) => v.defensoria_publica = (SimNaoIgnorado)e.defensoria_publica)
                .AfterMap((e, v) => v.conselho_tutelar = (SimNaoIgnorado)e.conselho_tutelar)
                .AfterMap((e, v) => v.ministerio_publico = (SimNaoIgnorado)e.ministerio_publico);
            CreateMap<Sinan_DadosFinais, Sinan_DadosFinaisViewModel>()
                .AfterMap((e, v) => v.violencia_trabalho = (SimNaoIgnorado)e.violencia_trabalho)
                .AfterMap((e, v) => v.emissao_cat = (SimNaoNaoSeAplicaIgnorado)e.emissao_cat)
                .AfterMap((e, v) => v.data_encerramento = e.data_encerramento == null ? null : Convert.ToDateTime(e.data_encerramento).ToString("yyyy-MM-dd"));
            CreateMap<Sinan_Observacoes, Sinan_ObservacoesViewModel>();
            CreateMap<Sinan_Notificador, Sinan_NotificadorViewModel>();
        }
    }
}