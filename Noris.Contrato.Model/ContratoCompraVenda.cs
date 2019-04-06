
namespace Noris.Contrato.Model
{
    public class ContratoCompraVenda
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string TipoContrato { get; set; }
        public int QtdeNegociada { get; set; }
        public decimal ValorNegociado { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int DuracaoMes { get; set; }
        public string Arquivo { get; set; }
        public string TipoArquivo { get; set; }
        public byte[] ConteudoArquivo { get; set; }
    }
}
