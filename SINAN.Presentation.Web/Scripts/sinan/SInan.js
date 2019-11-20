$(document).ready(function () {

    // Mask

    $("#cep").mask("99999-999");
    $("#telefone").mask("(99) 99999 - 9999");
    $("#hora_ocorrencia").mask("99:99");
    $("#telefone_acompanhate").mask("(99) 99999 - 9999");
       
    // Block UI 

    $.fn.in_block_ui = function () {

        $.blockUI({
            message: "Aguarde...",
            css: {
                top: '70px',
                left: '15px',
                padding: '15px',
                border: 'none',
                '-webkit-border-radius': '5px',
                '-moz-border-radius': '5px',
                backgroundColor: '#000',
                opacity: .5,
                color: '#fff'
            },
            overlayCSS: {
                backgroundColor: 'transparent'
            }
        });
    };

    $.fn.out_block_ui = function () {

        $.unblockUI();
    }
       
    // Menu Sidebar

    $("#menu-toggle").click(function (e) {
        e.preventDefault();
        $("#wrapper").toggleClass("active");
    });   

    $('body').scrollspy({ target: '#spy', offset: 80 });   

});

// Requisição Ajax

$(document).ajaxStart(function () {

    $.fn.in_block_ui();
});

// Requisição Ajax

$(document).ajaxStop(function () {

    $.fn.out_block_ui();
});