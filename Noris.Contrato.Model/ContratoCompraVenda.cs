
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Noris.Contrato.Model
{
    public class ContratoCompraVenda
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }


        [StringLength(50)]
        public string NomeCliente { get; set; }

        [StringLength(50)]
        public string TipoContrato { get; set; }
        public int QtdeNegociada { get; set; }
        public decimal ValorNegociado { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int DuracaoMes { get; set; }


        [StringLength(100)]
        public string Arquivo { get; set; }

        [StringLength(100)]
        public string TipoArquivo { get; set; }
        public byte[] ConteudoArquivo { get; set; }

        public virtual ContratoLiquido ContratoLiquido { get; set; }
    }
}
