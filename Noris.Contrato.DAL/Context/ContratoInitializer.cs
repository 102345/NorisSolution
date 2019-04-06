using Noris.Contrato.Model;
using System.Collections.Generic;

namespace Noris.Contrato.DAL.Context
{
    public class ContratoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContratoContext>
    {
        protected override void Seed(ContratoContext context)
        {
            var contratos = new List<ContratoCompraVenda>
            {
                new ContratoCompraVenda {NomeCliente="Cliente A", Ano=2019, Arquivo= "A.pdf",ConteudoArquivo =null,TipoArquivo = null,DuracaoMes=2,Mes=3,QtdeNegociada=20,TipoContrato= "Compra",ValorNegociado= 12000 },
                new ContratoCompraVenda {NomeCliente="Cliente B", Ano=2019, Arquivo= "B.pdf",ConteudoArquivo =null,TipoArquivo = null,DuracaoMes=2,Mes=4,QtdeNegociada=30,TipoContrato= "Venda",ValorNegociado= 24000}

            };

            contratos.ForEach(c => context.ContratosCompraVenda.Add(c));
            context.SaveChanges();
        }
    }
}
