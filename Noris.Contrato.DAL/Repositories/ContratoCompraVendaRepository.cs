using Noris.Contrato.DAL.Context;
using Noris.Contrato.DAL.Interface.Repositories;
using Noris.Contrato.Model;

namespace Noris.Contrato.DAL.Repositories
{
    public class ContratoCompraVendaRepository : RepositoryBase<ContratoCompraVenda>, IContratoCompraVendaRepository
    {
     
        public bool GravarContratosLiquido()
        {
            try
            {
                var context = new ContratoContext();

                context.Database.ExecuteSqlCommand("exec sp_carga_contrato_liquido");

               

                   
            }
            catch (System.Exception ex)
            {
                string msg = ex.Message;
                return false;
            }

            return true;
           
        }
    }
}
