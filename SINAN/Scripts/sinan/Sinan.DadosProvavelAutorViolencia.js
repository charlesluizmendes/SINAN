$(document).ready(function () {

    // Funções

    $.fn.vinculo_outros = function () {

        var vinculo_outros = $("#vinculo_outros");

        if (vinculo_outros.val() == 1) {

            $("#vinculo_outros_extenso").prop('disabled', false);

        } else {

            $("#vinculo_outros_extenso").val(null);
            $("#vinculo_outros_extenso").prop('disabled', true);
        }
    };

    // Eventos

    $("#vinculo_outros").change(function () {

        $.fn.vinculo_outros();
    });

    // Variáveis

    var vinculo_outros = $("#vinculo_outros").val();

    // Cargas

    if (vinculo_outros) {

        $.fn.vinculo_outros();
    }

});