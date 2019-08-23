using Noris.Contrato.Model;
using System.Collections.Generic;

namespace Noris.Contrato.Service.Interface
{
    public interface IContratoCompraVendaService
    {
        List<ContratoCompraVenda> ListarContratoCompraVendas();
        List<ContratoCompraVenda> PesquisarContratoCompraVendas(string nome);
        ContratoCompraVenda BuscarContratoCompraVenda(int id);
        void InserirContratoCompraVenda(ContratoCompraVenda ContratoCompraVenda);
        void AtualizarContratoCompraVenda(ContratoCompraVenda ContratoCompraVenda);
        void ExcluirContratoCompraVenda(int id);

        bool GravarContratosLiquidos();
    }
}
