$(document).ready(function () {

    // Eventos   

    $("#violencia_outros").change(function () {

        var violencia_outros = $("#violencia_outros");

        if (violencia_outros.val() == 1) {

            $("#violencia_outros_extenso").prop('disabled', false);

        } else {

            $("#violencia_outros_extenso").val(null);
            $("#violencia_outros_extenso").prop('disabled', true);
        }
    });

    $("#agressao_outros").change(function () {

        var agressao_outros = $("#agressao_outros");

        if (agressao_outros.val() == 1) {

            $("#agressao_outros_extenso").prop('disabled', false);

        } else {

            $("#agressao_outros_extenso").val(null);
            $("#agressao_outros_extenso").prop('disabled', true);
        }
    });

});