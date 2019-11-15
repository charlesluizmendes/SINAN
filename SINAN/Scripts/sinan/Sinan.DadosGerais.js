$(document).ready(function () {

    // Funções

    $.fn.list_mun_origem = function (ufe_sg_) {        

        var ufe_sg = ufe_sg_;
        var token = $("[name='__RequestVerificationToken']").val();        

        $.ajax({
            type: 'POST',
            dataType: "json",
            url: '/Sinan/GetMunicipio',
            data: {
                __RequestVerificationToken: token,
                ufe_sg: ufe_sg
            },
            success: function (data) {

                if (data.length != 0) {

                    var mun_origem = $("#mun_origem");
                    mun_origem.empty();
                    mun_origem.append('<option selected="true">-- selecione --</option>');
                    mun_origem.prop('selectedIndex', 0);

                    $.each(data, function (key, val) {
                        mun_origem.append($('<option></option>').attr('value', val.value).text(val.text));
                    });
                }

                if (uf_origem_) {

                    $("#mun_origem").val(mun_origem_);
                }
            },
            error: function (e) {
              
            }
        });
    };    

    $.fn.cod_ibge_origem = function () {        

        var loc_un = $("#mun_origem").val();
        var token = $("[name='__RequestVerificationToken']").val();       

        $.ajax({
            type: 'POST',
            dataType: "json",
            url: '/Sinan/GetCodigoIBGE',
            data: {
                __RequestVerificationToken: token,
                loc_un: loc_un
            },            
            success: function (data) {

                if (data != "") {

                    var cod_ibge = $("#cod_ibge");
                    cod_ibge.empty();
                    cod_ibge.val(data.text);

                    var codufmun_ = $("#cod_ibge").val();

                    $.fn.list_unidade(codufmun_);
                } 
            },
            error: function (e) {
             
            }
        });
    };    

    $.fn.list_unidade = function (codufmun_) {

        var codufmun = codufmun_;
        var token = $("[name='__RequestVerificationToken']").val();

        $.ajax({
            type: 'POST',
            dataType: "json",
            url: '/Sinan/GetUnidade',
            data: {
                __RequestVerificationToken: token,
                codufmun: codufmun
            },            
            success: function (data) {

                if (data.length != 0) {

                    var unidade_saude = $("#unidade_saude");
                    unidade_saude.empty();
                    unidade_saude.append('<option selected="true">-- selecione --</option>');
                    unidade_saude.prop('selectedIndex', 0);

                    $.each(data, function (key, val) {
                        unidade_saude.append($('<option></option>').attr('value', val.value).text(val.text));
                    });
                }  

                if (cod_ibge_) {

                    $("#unidade_saude").val(unidade_saude_);
                }
            },
            error: function (e) {
                
            }
        });
    };    

    $.fn.cod_cnes = function () {        

        var id = $("#unidade_saude").val();
        var token = $("[name='__RequestVerificationToken']").val();       

        $.ajax({
            type: 'POST',
            dataType: "json",
            url: '/Sinan/GetCodigoCNES',
            data: {
                __RequestVerificationToken: token,
                id: id
            },            
            success: function (data) {

                if (data != "") {

                    var cod_cnes = $("#cod_cnes");
                    cod_cnes.empty();
                    cod_cnes.val(data.text);                    

                    $.fn.cod_unidade();
                } 
            },
            error: function (e) {
               
            }
        });
    };    

    $.fn.cod_unidade = function () {

        var cod_unidade = $("#cod_unidade");
        cod_unidade.empty();
        var id = $("#unidade_saude").val();
        cod_unidade.val(id);        
    };

    // Eventos

    $("#uf_origem").change(function () {

        $("#mun_origem").empty();
        $("#cod_ibge").val('');
        $("#unidade_saude").empty();
        $("#cod_cnes").val('');
        $("#cod_unidade").val('');

        var ufe_sg_ = $("#uf_origem option:selected").text();

        $.fn.list_mun_origem(ufe_sg_);
    });

    $("#mun_origem").change(function () {

        $("#unidade_saude").empty();
        $("#cod_ibge").val('');
        $("#cod_cnes").val('');
        $("#cod_unidade").val('');

        $.fn.cod_ibge_origem();
    });

    $("#unidade_saude").change(function () {

        $("#cod_cnes").val('');
        $("#cod_unidade").val('');

        $.fn.cod_cnes();
    });

    // Variáveis

    var uf_origem_ = $("#uf_origem_").val();

    var mun_origem_ = $("#mun_origem_").val();

    var cod_ibge_ = $("#cod_ibge_").val();

    var unidade_saude_ = $("#unidade_saude_").val();

    // Cargas

    if (uf_origem_) {

        var ufe_sg_ = $("#uf_origem option:selected").text();

        $.fn.list_mun_origem(ufe_sg_);        
    }

    if (cod_ibge_) {

        $.fn.list_unidade(cod_ibge_);        
    }       

});