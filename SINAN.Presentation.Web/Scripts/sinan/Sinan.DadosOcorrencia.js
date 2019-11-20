$(document).ready(function () {

    // Funções

    $.fn.list_mun_ocorrencia = function (ufe_sg_) {

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

                    var mun_ocorrencia = $("#mun_ocorrencia");
                    mun_ocorrencia.empty();
                    mun_ocorrencia.append('<option selected="true">-- selecione --</option>');
                    mun_ocorrencia.prop('selectedIndex', 0);

                    $.each(data, function (key, val) {
                        mun_ocorrencia.append($('<option></option>').attr('value', val.value).text(val.text));
                    });
                }

                if (uf_ocorrencia_) {

                    $("#mun_ocorrencia").val(mun_ocorrencia_);
                }
            },
            error: function (e) {

            }
        });
    };

    $.fn.cod_ibge_ocorrencia = function () {

        var loc_un = $("#mun_ocorrencia").val();
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

                    var cod_ibge_ocorrencia = $("#cod_ibge_ocorrencia");
                    cod_ibge_ocorrencia.empty();
                    cod_ibge_ocorrencia.val(data.text);

                    var loc_nu_ = $("#mun_ocorrencia").val();

                    $.fn.list_bai_ocorrencia(loc_nu_);
                }
            },
            error: function (e) {

            }
        });
    };

    $.fn.list_bai_ocorrencia = function (loc_nu_) {

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

                    var bairro_ocorrencia = $("#bairro_ocorrencia");
                    bairro_ocorrencia.empty();
                    bairro_ocorrencia.append('<option selected="true">-- selecione --</option>');
                    bairro_ocorrencia.prop('selectedIndex', 0);

                    $.each(data, function (key, val) {
                        bairro_ocorrencia.append($('<option></option>').attr('value', val.value).text(val.text));
                    });
                }

                if (mun_ocorrencia_) {

                    $("#bairro_ocorrencia").val(bairro_ocorrencia_);
                }
            },
            error: function (e) {

            }
        });
    };

    // Eventos

    $("#uf_ocorrencia").change(function () {

        $("#mun_ocorrencia").empty();
        $("#cod_ibge_ocorrencia").val('');
        $("#bairro_ocorrencia").empty();
        $("#cod_ocorrencia").val('');
        $("#lograd_ocorrencia").val('');
        $("#comp_ocorrencia").val('');
        $("#numero_ocorrencia").val('');

        uf_ocorrencia_ = null;
        mun_ocorrencia_ = null;
        bairro_ocorrencia_ = null;

        var ufe_sg_ = $("#uf_ocorrencia option:selected").text();

        $.fn.list_mun_ocorrencia(ufe_sg_);
    });

    $("#mun_ocorrencia").change(function () {

        $("#cod_ibge_ocorrencia").val('');
        $("#bairro_ocorrencia").empty();
        $("#cod_ocorrencia").val('');
        $("#lograd_ocorrencia").val('');
        $("#comp_ocorrencia").val('');
        $("#numero_ocorrencia").val('');

        mun_ocorrencia_ = null;
        bairro_ocorrencia_ = null;

        $.fn.cod_ibge_ocorrencia();
    });

    $("#bairro_ocorrencia").change(function () {

        var cod_ocorrencia = $("#cod_ocorrencia");
        cod_ocorrencia.val('');

        bairro_ocorrencia_ = null;

        if ($("#bairro_ocorrencia").val() > 0) {

            var bai_nu = $("#bairro_ocorrencia").val();
            cod_ocorrencia.val(bai_nu);
        }
    });

    // Variáveis

    var uf_ocorrencia_ = $("#uf_ocorrencia_").val();

    var mun_ocorrencia_ = $("#mun_ocorrencia_").val();

    var bairro_ocorrencia_ = $("#bairro_ocorrencia_").val();

    // Cargas

    if (uf_ocorrencia_) {

        var ufe_sg_ = $("#uf_ocorrencia option:selected").text();

        $.fn.list_mun_ocorrencia(ufe_sg_);
    }

    if (mun_ocorrencia_) {

        $.fn.list_bai_ocorrencia(mun_ocorrencia_);
    }   

});