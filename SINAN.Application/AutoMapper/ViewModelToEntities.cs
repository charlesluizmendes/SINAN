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
    public class ViewModelToEntities : Profile
    {
        public override string ProfileName
        {
            get { return this.GetType().Name; }
        }

        public ViewModelToEntities()
        {
            CreateMap<LoginViewModel, Usuario>();
            CreateMap<RecuperarSenhaViewModel, Usuario>();
            CreateMap<AlterarSenhaViewModel, Usuario>();
            CreateMap<CriarContaViewModel, Usuario>()
                .AfterMap((v, e) => e.usu_perfil = Enum.GetName(typeof(Perfil), v.usu_perfil));
            CreateMap<Sinan_DadosGeraisViewModel, Sinan_DadosGerais>()
                .AfterMap((v, e) => e.tipo_notificacao = v.tipo_notificacao == null ? 0 : (int)v.tipo_notificacao)
                .AfterMap((v, e) => e.uf_origem = v.uf_origem == null ? "" : Enum.GetName(typeof(UF), v.uf_origem))
                .AfterMap((v, e) => e.unidade_notificadora = v.unidade_notificadora == null ? 0 : (int)v.unidade_notificadora);
            CreateMap<Sinan_NotificacaoIndividualViewModel, Sinan_NotificacaoIndividual>()
                .AfterMap((v, e) => e.ou_idade = v.ou_idade == null ? 0 : (int)v.ou_idade)
                .AfterMap((v, e) => e.sexo = v.sexo == null ? null : Enum.GetName(typeof(Sexo), v.sexo))
                .AfterMap((v, e) => e.gestante = v.gestante == null ? 0 : (int)v.gestante)
                .AfterMap((v, e) => e.raca = v.raca == null ? 0 : (int)v.raca)
                .AfterMap((v, e) => e.escolaridade = v.escolaridade == null ? 0 : (int)v.escolaridade)
                .AfterMap((v, e) => e.continua_estudando = v.continua_estudando == null ? 0 : (int)v.continua_estudando)
                .AfterMap((v, e) => e.ano_de_escolaridade = v.ano_de_escolaridade == null ? 0 : (int)v.ano_de_escolaridade)
                .AfterMap((v, e) => e.rede_ensino = v.rede_ensino == null ? 0 : (int)v.rede_ensino) 
                .AfterMap((v, e) => e.esfera_ensino = v.esfera_ensino == null ? 0 : (int)v.esfera_ensino)
                .AfterMap((v, e) => e.tem_nome_pai_registro = v.tem_nome_pai_registro == null ? 0 : (int)v.tem_nome_pai_registro);
            CreateMap<Sinan_DadosResidenciaViewModel, Sinan_DadosResidencia>()
                .AfterMap((v, e) => e.uf_residencia = v.uf_residencia == null ? "" : Enum.GetName(typeof(UF), v.uf_residencia))
                .AfterMap((v, e) => e.zona = v.zona == null ? 0 : (int)v.zona);
            CreateMap<Sinan_DadosDePessoaAtendidaViewModel, Sinan_DadosDePessoaAtendida>()
                .AfterMap((v, e) => e.situacao_conjugal = v.situacao_conjugal == null ? 0 : (int)v.situacao_conjugal)
                .AfterMap((v, e) => e.orientacao_sexual = v.orientacao_sexual == null ? 0 : (int)v.orientacao_sexual)
                .AfterMap((v, e) => e.identidade_genero = v.identidade_genero == null ? 0 : (int)v.identidade_genero)
                .AfterMap((v, e) => e.deficiencia = v.deficiencia == null ? 0 : (int)v.deficiencia)
                .AfterMap((v, e) => e.deficiencia_fisica = v.deficiencia_fisica == null ? 0 : (int)v.deficiencia_fisica)
                .AfterMap((v, e) => e.deficiencia_visual = v.deficiencia_visual == null ? 0 : (int)v.deficiencia_visual)
                .AfterMap((v, e) => e.transtorno_mental = v.transtorno_mental == null ? 0 : (int)v.transtorno_mental)
                .AfterMap((v, e) => e.deficiencia_intelectual = v.deficiencia_intelectual == null ? 0 : (int)v.deficiencia_intelectual)
                .AfterMap((v, e) => e.deficiencia_auditiva = v.deficiencia_auditiva == null ? 0 : (int)v.deficiencia_auditiva)
                .AfterMap((v, e) => e.trans_de_comportamento = v.trans_de_comportamento == null ? 0 : (int)v.trans_de_comportamento)
                .AfterMap((v, e) => e.deficiencia_outros = v.deficiencia_outros == null ? 0 : (int)v.deficiencia_outros);
            CreateMap<Sinan_DadosDaOcorrenciaViewModel, Sinan_DadosDaOcorrencia>()
                .AfterMap((v, e) => e.uf_ocorrencia = v.uf_ocorrencia == null ? "" : Enum.GetName(typeof(UF), v.uf_ocorrencia))
                .AfterMap((v, e) => e.zona_ocorrencia = v.zona_ocorrencia == null ? 0 : (int)v.zona_ocorrencia)
                .AfterMap((v, e) => e.local_ocorrencia = v.local_ocorrencia == null ? 0 : (int)v.local_ocorrencia)
                .AfterMap((v, e) => e.ocorrencia_repetida = v.ocorrencia_repetida == null ? 0 : (int)v.ocorrencia_repetida)
                .AfterMap((v, e) => e.autoprovocada = v.autoprovocada == null ? 0 : (int)v.autoprovocada);
            CreateMap<Sinan_ViolenciaViewModel, Sinan_Violencia>()
                .AfterMap((v, e) => e.motivo_ocorrencia = v.motivo_ocorrencia == null ? 0 : (int)v.motivo_ocorrencia)
                .AfterMap((v, e) => e.violencia_fisica = v.violencia_fisica == null ? 0 : (int)v.violencia_fisica)
                .AfterMap((v, e) => e.trafico_de_humanos = v.trafico_de_humanos == null ? 0 : (int)v.trafico_de_humanos)
                .AfterMap((v, e) => e.intervencao_legal = v.intervencao_legal == null ? 0 : (int)v.intervencao_legal)
                .AfterMap((v, e) => e.pisicologica_mental = v.pisicologica_mental == null ? 0 : (int)v.pisicologica_mental)
                .AfterMap((v, e) => e.financeira_economica = v.financeira_economica == null ? 0 : (int)v.financeira_economica)
                .AfterMap((v, e) => e.tortura = v.tortura == null ? 0 : (int)v.tortura)
                .AfterMap((v, e) => e.negligencia_abandono = v.negligencia_abandono == null ? 0 : (int)v.negligencia_abandono)
                .AfterMap((v, e) => e.sexual = v.sexual == null ? 0 : (int)v.sexual)
                .AfterMap((v, e) => e.trabalho_infantil = v.trabalho_infantil == null ? 0 : (int)v.trabalho_infantil)
                .AfterMap((v, e) => e.violencia_outros = v.violencia_outros == null ? 0 : (int)v.violencia_outros)
                .AfterMap((v, e) => e.forca_corporal_espacamento = v.forca_corporal_espacamento == null ? 0 : (int)v.forca_corporal_espacamento)
                .AfterMap((v, e) => e.objeto_perfurante_cortante = v.objeto_perfurante_cortante == null ? 0 : (int)v.objeto_perfurante_cortante)
                .AfterMap((v, e) => e.arma_de_fogo = v.arma_de_fogo == null ? 0 : (int)v.arma_de_fogo)
                .AfterMap((v, e) => e.enforcamento = v.enforcamento == null ? 0 : (int)v.enforcamento)
                .AfterMap((v, e) => e.substancia_objeto_quente = v.substancia_objeto_quente == null ? 0 : (int)v.substancia_objeto_quente)
                .AfterMap((v, e) => e.ameaca = v.ameaca == null ? 0 : (int)v.ameaca)
                .AfterMap((v, e) => e.objeto_contindente = v.objeto_contindente == null ? 0 : (int)v.objeto_contindente)
                .AfterMap((v, e) => e.envenenamento_intoxicacao = v.envenenamento_intoxicacao == null ? 0 : (int)v.envenenamento_intoxicacao)
                .AfterMap((v, e) => e.agressao_outros = v.agressao_outros == null ? 0 : (int)v.agressao_outros);
            CreateMap<Sinan_ViolenciaSexualViewModel, Sinan_ViolenciaSexual>()
                .AfterMap((v, e) => e.assedio_sexual = v.assedio_sexual == null ? 0 : (int)v.assedio_sexual)
                .AfterMap((v, e) => e.estupro = v.estupro == null ? 0 : (int)v.estupro)
                .AfterMap((v, e) => e.pornorafia_infantil = v.pornorafia_infantil == null ? 0 : (int)v.pornorafia_infantil)
                .AfterMap((v, e) => e.exploracao_sexual = v.exploracao_sexual == null ? 0 : (int)v.exploracao_sexual)
                .AfterMap((v, e) => e.outros_violencia_sexual = v.outros_violencia_sexual == null ? 0 : (int)v.outros_violencia_sexual)
                .AfterMap((v, e) => e.profilaxia_dst = v.profilaxia_dst == null ? 0 : (int)v.profilaxia_dst)
                .AfterMap((v, e) => e.porfilaxia_hepatite_b = v.porfilaxia_hepatite_b == null ? 0 : (int)v.porfilaxia_hepatite_b)
                .AfterMap((v, e) => e.coleta_de_semen = v.coleta_de_semen == null ? 0 : (int)v.coleta_de_semen)
                .AfterMap((v, e) => e.contracepcao_de_emergencia = v.contracepcao_de_emergencia == null ? 0 : (int)v.contracepcao_de_emergencia)
                .AfterMap((v, e) => e.profilacia_hiv = v.profilacia_hiv == null ? 0 : (int)v.profilacia_hiv)
                .AfterMap((v, e) => e.coleta_de_sangue = v.coleta_de_sangue == null ? 0 : (int)v.coleta_de_sangue)
                .AfterMap((v, e) => e.coleta_de_secrecao_vaginal = v.coleta_de_secrecao_vaginal == null ? 0 : (int)v.coleta_de_secrecao_vaginal)
                .AfterMap((v, e) => e.aborto_previsto_em_lei = v.aborto_previsto_em_lei == null ? 0 : (int)v.aborto_previsto_em_lei);
            CreateMap<Sinan_DadosDoProvavelAutorViolenciaViewModel, Sinan_DadosDoProvavelAutorDaViolencia>()
                .AfterMap((v, e) => e.num_envolvidos = v.num_envolvidos == null ? 0 : (int)v.num_envolvidos)
                .AfterMap((v, e) => e.pai = v.pai == null ? 0 : (int)v.pai)
                .AfterMap((v, e) => e.ex_conjugue = v.ex_conjugue == null ? 0 : (int)v.ex_conjugue)
                .AfterMap((v, e) => e.amigos_conhecidos = v.amigos_conhecidos == null ? 0 : (int)v.amigos_conhecidos)
                .AfterMap((v, e) => e.policial_agente = v.policial_agente == null ? 0 : (int)v.policial_agente)
                .AfterMap((v, e) => e.mae = v.mae == null ? 0 : (int)v.mae)
                .AfterMap((v, e) => e.namoradoa = v.namoradoa == null ? 0 : (int)v.namoradoa)
                .AfterMap((v, e) => e.desconhecidoa = v.desconhecidoa == null ? 0 : (int)v.desconhecidoa)
                .AfterMap((v, e) => e.propria_pessoa = v.propria_pessoa == null ? 0 : (int)v.propria_pessoa)
                .AfterMap((v, e) => e.padrassto = v.padrassto == null ? 0 : (int)v.padrassto)
                .AfterMap((v, e) => e.ex_namoradoa = v.ex_namoradoa == null ? 0 : (int)v.ex_namoradoa)
                .AfterMap((v, e) => e.cuidadoraa = v.cuidadoraa == null ? 0 : (int)v.cuidadoraa)
                .AfterMap((v, e) => e.madrastra = v.madrastra == null ? 0 : (int)v.madrastra)
                .AfterMap((v, e) => e.filhoa = v.filhoa == null ? 0 : (int)v.filhoa)
                .AfterMap((v, e) => e.patrao_chefe = v.patrao_chefe == null ? 0 : (int)v.patrao_chefe)
                .AfterMap((v, e) => e.conjugue = v.conjugue == null ? 0 : (int)v.conjugue)
                .AfterMap((v, e) => e.irmaoa = v.irmaoa == null ? 0 : (int)v.irmaoa)
                .AfterMap((v, e) => e.pessoa_relacao_intituc = v.pessoa_relacao_intituc == null ? 0 : (int)v.pessoa_relacao_intituc)
                .AfterMap((v, e) => e.vinculo_outros = v.vinculo_outros == null ? 0 : (int)v.vinculo_outros)
                .AfterMap((v, e) => e.sexo_autor = v.sexo_autor == null ? 0 : (int)v.sexo_autor)
                .AfterMap((v, e) => e.uso_alcool = v.uso_alcool == null ? 0 : (int)v.uso_alcool)
                .AfterMap((v, e) => e.ciclo_vida_autor = v.ciclo_vida_autor == null ? 0 : (int)v.ciclo_vida_autor);
            CreateMap<Sinan_EncaminhamentoViewModel, Sinan_Encaminhamento>()
                .AfterMap((v, e) => e.rede_saude = v.rede_saude == null ? 0 : (int)v.rede_saude)
                .AfterMap((v, e) => e.conselho_do_idoso = v.conselho_do_idoso == null ? 0 : (int)v.conselho_do_idoso)
                .AfterMap((v, e) => e.delegacia_atendimento_mulher = v.delegacia_atendimento_mulher == null ? 0 : (int)v.delegacia_atendimento_mulher)
                .AfterMap((v, e) => e.rede_assistencia_social = v.rede_assistencia_social == null ? 0 : (int)v.rede_assistencia_social)
                .AfterMap((v, e) => e.delegacia_atendimento_idoso = v.delegacia_atendimento_idoso == null ? 0 : (int)v.delegacia_atendimento_idoso)
                .AfterMap((v, e) => e.outras_delegacias = v.outras_delegacias == null ? 0 : (int)v.outras_delegacias)
                .AfterMap((v, e) => e.rede_educacao = v.rede_educacao == null ? 0 : (int)v.rede_educacao)
                .AfterMap((v, e) => e.centro_referencia_diretos_humanos = v.centro_referencia_diretos_humanos == null ? 0 : (int)v.centro_referencia_diretos_humanos)
                .AfterMap((v, e) => e.justica_da_infancia_juventude = v.justica_da_infancia_juventude == null ? 0 : (int)v.justica_da_infancia_juventude)
                .AfterMap((v, e) => e.rede_atendimento_mulher = v.rede_atendimento_mulher == null ? 0 : (int)v.rede_atendimento_mulher)
                .AfterMap((v, e) => e.delegacia_especializada_crianca_adolecente = v.delegacia_especializada_crianca_adolecente == null ? 0 : (int)v.delegacia_especializada_crianca_adolecente)
                .AfterMap((v, e) => e.defensoria_publica = v.defensoria_publica == null ? 0 : (int)v.defensoria_publica)
                .AfterMap((v, e) => e.conselho_tutelar = v.conselho_tutelar == null ? 0 : (int)v.conselho_tutelar)
                .AfterMap((v, e) => e.ministerio_publico = v.ministerio_publico == null ? 0 : (int)v.ministerio_publico);
            CreateMap<Sinan_DadosFinaisViewModel, Sinan_DadosFinais>()
                .AfterMap((v, e) => e.violencia_trabalho = v.violencia_trabalho == null ? 0 : (int)v.violencia_trabalho)
                .AfterMap((v, e) => e.emissao_cat = v.emissao_cat == null ? 0 : (int)v.emissao_cat);
            CreateMap<Sinan_ObservacoesViewModel, Sinan_Observacoes>();
            CreateMap<Sinan_NotificadorViewModel, Sinan_Notificador>();
        }
    }
}