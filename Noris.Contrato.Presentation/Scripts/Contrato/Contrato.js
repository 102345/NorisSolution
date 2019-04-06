$(".incluirContrato").click(function () {
    $("#modIncluirContrato").load("/Contrato/ExibirJanelaIncluiContrato", function () {
        $("#modIncluirContrato").modal();
    })
});


$(".editarContrato").click(function () {
    var id = $(this).attr("data-id");
    $("#modAtualizarContrato").load("/Contrato/ExibirJanelaEditaContrato/" + id, function () {
        $("#modAtualizarContrato").modal();
    })
});


$(".excluirContrato").click(function () {
    var id = $(this).attr("data-id");
    $("#modExcluirContrato").load("/Contrato/ExibirJanelaExcluiContrato/" + id, function () {
        $("#modExcluirContrato").modal();
    })
});

$(".downloadContrato").click(function () {
    var id = $(this).attr("data-id");
    $("#modExcluirContrato").load("/Contrato/DownloadArquivo/" + id);
});



$(".pesquisarContrato").click(function () {
    $("#modPesquisarContrato").load("/Contrato/ExibirJanelaPesquisaContrato", function () {
        $("#modPesquisarContrato").modal();
    })
});