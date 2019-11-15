$(document).ready(function () {

    // Funções

    $.fn.list_mun_residencia = function (ufe_sg_) {

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

                    var municipio_residencia = $("#municipio_residencia");
                    municipio_residencia.empty();
                    municipio_residencia.append('<option selected="true">-- selecione --</option>');
                    municipio_residencia.prop('selectedIndex', 0);

                    $.each(data, function (key, val) {
                        municipio_residencia.append($('<option></option>').attr('value', val.value).text(val.text));
                    });
                }

                if (uf_residencia_) {

                    $("#municipio_residencia").val(municipio_residencia_);
                }
            },
            error: function (e) {
               
            }
        });
    };

    $.fn.cod_ibge_residencia = function () {

        var loc_un = $("#municipio_residencia").val();
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

                    var cod_ibge_residencia = $("#cod_ibge_residencia");
                    cod_ibge_residencia.empty();
                    cod_ibge_residencia.val(data.text);   

                    var loc_nu_ = $("#municipio_residencia").val();

                    $.fn.list_bai_residencia(loc_nu_);
                } 
            },
            error: function (e) {
                
            }
        });
    };

    $.fn.list_bai_residencia = function (loc_nu_) {

        var loc_nu = loc_nu_;
        var token = $("[name='__RequestVerificationToken']").val();

        $.ajax({
            type: 'POST',
            dataType: "json",
            url: '/Sinan/GetBairro',
            data: {
                __RequestVerificationToken: token,
                loc_nu: loc_nu
            },
            success: function (data) {

                if (data.length != 0) {

                    var bairro_residencia = $("#bairro_residencia");
                    bairro_residencia.empty();
                    bairro_residencia.append('<option selected="true">-- selecione --</option>');
                    bairro_residencia.prop('selectedIndex', 0);

                    $.each(data, function (key, val) {
                        bairro_residencia.append($('<option></option>').attr('value', val.value).text(val.text));
                    });
                }

                if (municipio_residencia_) {

                    $("#bairro_residencia").val(bairro_residencia_);
                }
            },
            error: function (e) {

            }
        });
    };

    $.fn.list_end = function () {

        $.fn.in_block_ui();

        var cep = $("#cep").val().replace("-", "");
        var token = $("[name='__RequestVerificationToken']").val();

        $.ajax({
            type: 'POST',
            dataType: "json",
            url: '/Sinan/GetEndereco',
            data: {
                __RequestVerificationToken: token,
                cep: cep
            },           
            success: function (data) {

                if (data != "") {

                    //Estado
                    var uf_residencia = $("#uf_residencia");
                    uf_residencia.val($('option:contains("' + data.ufe_sg + '")').val());

                    //Municipio
                    var municipio_residencia = $("#municipio_residencia");
                    municipio_residencia.empty();
                    municipio_residencia.append('<option>-- selecione --</option>');
                    municipio_residencia.append('<option value="' + data.loc_un + '" selected="true">' + data.loc_no + '</option>');
                    municipio_residencia.prop('selectedIndex', 1);

                    //IBGE
                    var cod_ibge_residencia = $("#cod_ibge_residencia");
                    cod_ibge_residencia.val(data.mun_nu);

                    //Bairro
                    var bairro_residencia = $("#bairro_residencia");
                    bairro_residencia.empty();
                    bairro_residencia.append('<option>-- selecione --</option>');
                    bairro_residencia.append('<option value="' + data.bai_nu + '" selected="true">' + data.bai_no + '</option>');
                    bairro_residencia.prop('selectedIndex', 1);

                    //Codigo
                    var cod_residencia = $("#cod_residencia");
                    cod_residencia.val(data.bai_nu);

                    //Logradouro
                    var logradouro_residencia = $("#logradouro_residencia");
                    logradouro_residencia.val(data.tlo_tx + " " + data.log_no);

                    $.fn.out_block_ui();
                }                
            },
            error: function (e) {

                $.fn.out_block_ui();
            }
        });
    };

    // Eventos

    $("#uf_residencia").change(function () {

        $("#municipio_residencia").empty();
        $("#cod_ibge_residencia").val('');
        $("#bairro_residencia").empty();
        $("#cod_residencia").val('');
        $("#logradouro_residencia").val('');
        $("#comp_residencia").val('');
        $("#numero_residencia").val('');

        var ufe_sg_ = $("#uf_residencia option:selected").text();

        $.fn.list_mun_residencia(ufe_sg_);
    });

    $("#municipio_residencia").change(function () {

        $("#cod_ibge_residencia").val('');
        $("#bairro_residencia").empty();
        $("#cod_residencia").val('');
        $("#logradouro_residencia").val('');
        $("#comp_residencia").val('');
        $("#numero_residencia").val('');

        $.fn.cod_ibge_residencia();
    });

    $("#bairro_residencia").change(function () {

        var cod_residencia = $("#cod_residencia");
        cod_residencia.val('');

        if ($("#bairro_residencia").val() > 0) {

            var bai_nu = $("#bairro_residencia").val();
            cod_residencia.val(bai_nu);
        }
    });

    $("#cep").blur(function () {

        var uf = $("#uf_residencia").val();

        if (uf == 0) {

            $.fn.list_end();
        }
    });

    // Variáveis

    var uf_residencia_ = $("#uf_residencia_").val();

    var municipio_residencia_ = $("#municipio_residencia_").val();

    var bairro_residencia_ = $("#bairro_residencia_").val();

    // Cargas

    if (uf_residencia_) {

        var ufe_sg_ = $("#uf_residencia option:selected").text();

        $.fn.list_mun_residencia(ufe_sg_);
    }

    if (municipio_residencia_) {

        $.fn.list_bai_residencia(municipio_residencia_);
    }    

});