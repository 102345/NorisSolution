using Noris.Contrato.DAL.Repositories;
using Noris.Contrato.Model;
using Noris.Contrato.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Noris.Contrato.Service
{
    public class ContratoCompraVendaService : IContratoCompraVendaService
    {
        private readonly ContratoCompraVendaRepository _contratoCompraVendaRepository;

        public ContratoCompraVendaService()
        {
            _contratoCompraVendaRepository = new ContratoCompraVendaRepository();
        }


        public void AtualizarContratoCompraVenda(ContratoCompraVenda contratoCompraVenda)
        {
            _contratoCompraVendaRepository.Update(contratoCompraVenda);
        }

        public ContratoCompraVenda BuscarContratoCompraVenda(int id)
        {
            return _contratoCompraVendaRepository.GetById(id);
        }

        public void ExcluirContratoCompraVenda(int id)
        {
            _contratoCompraVendaRepository.Remove(_contratoCompraVendaRepository.GetById(id));
        }

        public void InserirContratoCompraVenda(ContratoCompraVenda contratoCompraVenda)
        {
            _contratoCompraVendaRepository.Add(contratoCompraVenda);
        }

        public List<ContratoCompraVenda> ListarContratoCompraVendas()
        {
            return _contratoCompraVendaRepository.GetAll().OrderBy(x => x.NomeCliente).ToList();
        }

        public List<ContratoCompraVenda> PesquisarContratoCompraVendas(string nome)
        {
            return _contratoCompraVendaRepository.GetAll().Where(p => p.NomeCliente.Contains(nome))
                                                        .OrderBy(x => x.NomeCliente).ToList();
        }
    }
}
