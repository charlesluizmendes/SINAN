$(document).ready(function () {

    // Funções

    $.fn.violencia_outros = function () {

        var violencia_outros = $("#violencia_outros");

        if (violencia_outros.val() == 1) {

            $("#violencia_outros_extenso").prop('disabled', false);

        } else {

            $("#violencia_outros_extenso").val(null);
            $("#violencia_outros_extenso").prop('disabled', true);
        }
    };

    $.fn.agressao_outros = function () {

        var agressao_outros = $("#agressao_outros");

        if (agressao_outros.val() == 1) {

            $("#agressao_outros_extenso").prop('disabled', false);

        } else {

            $("#agressao_outros_extenso").val(null);
            $("#agressao_outros_extenso").prop('disabled', true);
        }
    };

    // Eventos

    $("#violencia_outros").change(function () {

        $.fn.violencia_outros();
    });

    $("#agressao_outros").change(function () {

        $.fn.agressao_outros();
    });

    // Variáveis

    var violencia_outros = $("#violencia_outros").val();

    var agressao_outros = $("#agressao_outros").val();

    // Cargas

    if (violencia_outros) {

        $.fn.violencia_outros();
    }

    if (agressao_outros) {

        $.fn.agressao_outros();
    }

});