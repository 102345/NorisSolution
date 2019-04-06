using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Noris.Contrato.Model;

namespace Noris.Contrato.DAL.Context
{
    public class ContratoContext :DbContext
    {
        public DbSet<ContratoCompraVenda> ContratosCompraVenda { get; set; }


        public ContratoContext() : base("ContratoContext")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
