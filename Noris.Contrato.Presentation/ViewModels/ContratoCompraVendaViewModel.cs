using Noris.Contrato.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Noris.Contrato.Presentation.ViewModels
{
    public class ContratoCompraVendaViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "É necessário informar um nome de cliente.")]
        [Display(Name ="Cliente")]
        public string NomeCliente { get; set; }
        [Display(Name ="Tipo Contrato")]
        public string TipoContrato { get; set; }
        [Required(ErrorMessage = "É necessário informar uma quantidade negociada.")]
        [Display(Name ="Qtde Negociada")]
        public int QtdeNegociada { get; set; }
        [Required(ErrorMessage = "É necessário informar um valor negociado.")]
        [Display(Name ="Valor Negociado (R$)")]
        public decimal ValorNegociado { get; set; }
        [Required(ErrorMessage = "É necessário informar o Mês.")]
        [Display(Name = "Mês")]
        public string Mes { get; set; }
        [Required(ErrorMessage = "É necessário informar o Ano.")]
        public string Ano { get; set; }
        [Required(ErrorMessage = "É necessário informar a duração de meses.")]
        [Display(Name = "Duração (Meses)")]
        public string DuracaoMes { get; set; }
        public string Arquivo { get; set; }
        public string TipoArquivo { get; set; }
        public byte[] ConteudoArquivo { get; set; }
        public IEnumerable<ContratoCompraVenda> ColecaoContratos { get; set; }


    }
}