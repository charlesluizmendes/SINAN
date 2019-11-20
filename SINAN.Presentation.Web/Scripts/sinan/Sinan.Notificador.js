$(document).ready(function () {

    // Funções

    $.fn.mun_nome_unidade_notificador = function () {

        var mun_origem = $("#mun_origem").val();
        var nome_unidade_notificadora = $("#nome_unidade_notificadora").val();
        
        if (mun_origem > 0 && nome_unidade_notificadora) {

            $("#municipio_nome_unidade_notificadora").val($("#mun_origem option:selected").text() + "/" + $("#nome_unidade_notificadora").val());
        }        
    };

    $.fn.mun_unidade_notificador = function () {

        var mun_origem = $("#mun_origem").val();
        var unidade_saude = $("#unidade_saude").val();        

        if (mun_origem > 0 && unidade_saude > 0) {

            $("#municipio_unidade_saude").val($("#mun_origem option:selected").text() + "/" + $("#unidade_saude option:selected").text());
        }
    };

    // Eventos

    $("#uf_origem").change(function () {       

        $("#municipio_nome_unidade_notificadora").val('');
        $("#municipio_unidade_saude").val('');
        
    });    

    $("#mun_origem").change(function () {

        $("#municipio_nome_unidade_notificadora").val('');
        $("#municipio_unidade_saude").val('');        

        $.fn.mun_nome_unidade_notificador();
        $.fn.mun_unidade_notificador();        
    });

    $("#nome_unidade_notificadora").blur(function () {

        $("#municipio_nome_unidade_notificadora").val('');

        $.fn.mun_nome_unidade_notificador();        
    });

    $("#unidade_saude").change(function () {

        $("#municipio_unidade_saude").val('');
        
        $.fn.mun_unidade_notificador();        
    });   

    // Variáveis
       
    // Cargas

});