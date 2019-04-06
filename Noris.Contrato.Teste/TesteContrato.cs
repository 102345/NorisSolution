using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Noris.Contrato.Service;

namespace Noris.Contrato.Teste
{
    [TestClass]
    public class TesteContrato
    {
        [TestMethod]
        public void ListarContratos()
        {
            var contratos = new ContratoCompraVendaService().ListarContratoCompraVendas();

            Assert.AreNotEqual(null, contratos);
        }

        [TestMethod]
        public void InserirContrato()
        {

        }

}


  

}
