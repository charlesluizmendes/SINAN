$(document).ready(function () {

    // Funções

    $.fn.outros_violencia_sexual = function () {

        var outros_violencia_sexual = $("#outros_violencia_sexual");

        if (outros_violencia_sexual.val() == 1) {

            $("#outros_violencia_sexual_extenso").prop('disabled', false);

        } else {

            $("#outros_violencia_sexual_extenso").val("");
            $("#outros_violencia_sexual_extenso").prop('disabled', true);
        }
    };

    // Eventos

    $("#outros_violencia_sexual").change(function () {

        $.fn.outros_violencia_sexual();
    });

    // Variáveis

    var outros_violencia_sexual = $("#outros_violencia_sexual").val();

    // Cargas

    if (outros_violencia_sexual) {

        $.fn.outros_violencia_sexual();
    }

});


