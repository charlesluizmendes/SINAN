$(document).ready(function () {

    // Eventos

    $("#deficiencia").change(function () {

        var deficiencia = $("#deficiencia");

        if (deficiencia.val() == 1) {

            $("#deficiencia_fisica").prop('disabled', false);
            $("#deficiencia_visual").prop('disabled', false);
            $("#transtorno_mental").prop('disabled', false);
            $("#deficiencia_intelectual").prop('disabled', false);
            $("#deficiencia_auditiva").prop('disabled', false);
            $("#trans_de_comportamento").prop('disabled', false);
            $("#deficiencia_outros").prop('disabled', false);                      

        } else {

            $("#deficiencia_fisica").val(null);
            $("#deficiencia_fisica").prop('disabled', true);

            $("#deficiencia_visual").val(null);
            $("#deficiencia_visual").prop('disabled', true);

            $("#transtorno_mental").val(null);
            $("#transtorno_mental").prop('disabled', true);

            $("#deficiencia_intelectual").val(null);
            $("#deficiencia_intelectual").prop('disabled', true);

            $("#deficiencia_auditiva").val(null);
            $("#deficiencia_auditiva").prop('disabled', true);

            $("#trans_de_comportamento").val(null);
            $("#trans_de_comportamento").prop('disabled', true);

            $("#deficiencia_outros").val(null);
            $("#deficiencia_outros").prop('disabled', true);

            $("#deficiencia_outros_extenso").val("");
            $("#deficiencia_outros_extenso").prop('disabled', true);
        }
    });

    $("#deficiencia_outros").change(function () {

        var deficiencia_outros = $("#deficiencia_outros");

        if (deficiencia_outros.val() == 1) {

            $("#deficiencia_outros_extenso").prop('disabled', false);

        } else {

            $("#deficiencia_outros_extenso").val("");
            $("#deficiencia_outros_extenso").prop('disabled', true);
        }

    });

});