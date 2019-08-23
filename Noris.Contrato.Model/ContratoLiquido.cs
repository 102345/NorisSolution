using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Noris.Contrato.Model
{
    public class ContratoLiquido
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        //public int Id { get; set; }
        [Key]
        [ForeignKey("ContratoCompraVenda")]
        public int IdContrato { get; set; }

        [StringLength(50)]
        public string NomeCliente { get; set; }

        [StringLength(50)]
        public string TipoContrato { get; set; }
        public int QtdeNegociada { get; set; }
        public decimal ValorNegociado { get; set; }

        public decimal ValorTaxaComissao { get; set; }

        public decimal ValorLiquido { get; set; }

        public virtual ContratoCompraVenda ContratoCompraVenda { get; set; }

    }
}
