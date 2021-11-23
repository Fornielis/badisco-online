// APOS CARREGAMENTO PÁGINA
$(document).ready(function ($) {

});

// FECHA  SAIBA MAIS
function FechaSaibaMais() {
    $('#conteudo-saiba-mais').removeClass('zoomInDown');
    $('#conteudo-saiba-mais').addClass('zoomOutDown');

    // ESPERA 1 SEGUNDO PARA EXECUTAR PROXIMO PASSO
    var delayInMilliseconds = 1000;

    setTimeout(function () {
        $('#box-retorno').css('display', 'none');
    }, delayInMilliseconds);
};

// FECHA  RESPOSTA
function FechaResposta() {
    $('#conteudo').removeClass('zoomInDown');
    $('#conteudo').addClass('zoomOutDown');

    // ESPERA 1 SEGUNDO PARA EXECUTAR PROXIMO PASSO
    var delayInMilliseconds = 1000;

    setTimeout(function () {
        $('#box-resposta').css('display', 'none');
    }, delayInMilliseconds);
};