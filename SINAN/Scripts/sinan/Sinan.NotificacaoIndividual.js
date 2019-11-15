$(document).ready(function () {

    // Eventos

    $("#sexo").change(function () {

        var sexo = $("#sexo");

        if (sexo.val() == 70) {

            $("#gestante").prop('disabled', false);

        } else {

            $("#gestante").val(null);
            $("#gestante").prop('disabled', true);
        }
    });

    $("#continua_estudando").change(function () {

        var continua_estudando = $("#continua_estudando");

        if (continua_estudando.val() == 1) {

            $("#ano_de_escolaridade").prop('disabled', false);
            $("#rede_ensino").prop('disabled', false);
            $("#nome_escola").prop('disabled', false);

        } else {

            $("#ano_de_escolaridade").val(null);
            $("#ano_de_escolaridade").prop('disabled', true);

            $("#rede_ensino").val(null);
            $("#rede_ensino").prop('disabled', true);

            $("#esfera_ensino").val(null);
            $("#esfera_ensino").prop('disabled', true);

            $("#nome_escola").val('');
            $("#nome_escola").prop('disabled', true);
        }
    });

    $("#rede_ensino").change(function () {

        var rede_ensino = $("#rede_ensino");

        if (rede_ensino.val() == 1) {

            $("#esfera_ensino").prop('disabled', false);

        } else {

            $("#esfera_ensino").val(null);
            $("#esfera_ensino").prop('disabled', true);
        }
    });

});