using AutoMapper;
using Noris.Contrato.Model;
using Noris.Contrato.Presentation.ViewModels;
using Noris.Contrato.Service.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Noris.Contrato.Presentation.Controllers
{
    public class ContratoController : Controller
    {
        private IContratoCompraVendaService _contratoCompraVendaService;

        public ContratoController(IContratoCompraVendaService contratoCompraVendaService)
        {
            _contratoCompraVendaService = contratoCompraVendaService;
        }

        // GET: Contrato
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ListaContratos()
        {

            var modelVM = Mapper.Map<IEnumerable<ContratoCompraVenda>, 
                            IEnumerable<ContratoCompraVendaViewModel>>(_contratoCompraVendaService.ListarContratoCompraVendas());

            return View(modelVM);


        }

        public PartialViewResult ExibirJanelaPesquisaContrato()
        {

            var modelVM = new ContratoCompraVendaViewModel();

            return PartialView("_PesquisaContrato", modelVM);


        }

        [HttpGet]
        public ActionResult DownloadArquivo(int id)
        {
            var model = _contratoCompraVendaService.BuscarContratoCompraVenda(id);

            //return File(model.ConteudoArquivo, model.TipoArquivo, model.Arquivo);
            return File(model.ConteudoArquivo, System.Net.Mime.MediaTypeNames.Application.Octet, model.Arquivo);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PesquisarContratos(ContratoCompraVendaViewModel contratoCompraVendaViewModel)
        {


            if (ModelState.IsValid)
            {
                string pathRecurso = string.Format("ListaFiltradaContratos/{0}", contratoCompraVendaViewModel.NomeCliente);
                ModelState.Clear();
                return RedirectToAction(pathRecurso, "Contrato");
            }

            return RedirectToAction("ListaContratos", "Contrato");
        }


        [HttpGet]
        public ActionResult ListaFiltradaContratos(string id)
        {

            var modelVM = Mapper.Map<IEnumerable<ContratoCompraVenda>, IEnumerable<ContratoCompraVendaViewModel>>
                                    (_contratoCompraVendaService.PesquisarContratoCompraVendas(id));

            return View(modelVM);


        }




        public PartialViewResult ExibirJanelaExcluiContrato(int id)
        {
            var modelVM = Mapper.Map<ContratoCompraVenda, ContratoCompraVendaViewModel>(_contratoCompraVendaService.BuscarContratoCompraVenda(id));

            return PartialView("_ExcluiContrato", modelVM);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirContrato(ContratoCompraVendaViewModel contratoCompraVendaViewModel)
        {

            _contratoCompraVendaService.ExcluirContratoCompraVenda(contratoCompraVendaViewModel.Id);

            return RedirectToAction("ListaContratos", "Contrato");

        }



        public PartialViewResult ExibirJanelaIncluiContrato()
        {

            var modelVM = new ContratoCompraVendaViewModel();


            return PartialView("_NovoContrato", modelVM);


        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        [HandleError]
        public ActionResult IncluirContrato(ContratoCompraVendaViewModel contratoCompraVendaViewModel, HttpPostedFileBase ArquivoSelecionado)
        {

            if (ModelState.IsValid)
            {   
                if(ArquivoSelecionado != null)
                {
                    using (var binaryReader = new BinaryReader(ArquivoSelecionado.InputStream))
                    {
                        contratoCompraVendaViewModel.ConteudoArquivo = binaryReader.ReadBytes(ArquivoSelecionado.ContentLength);
                        contratoCompraVendaViewModel.Arquivo = ArquivoSelecionado.FileName;
                        contratoCompraVendaViewModel.TipoArquivo = ArquivoSelecionado.ContentType;
                    }

                }

                var model = Mapper.Map<ContratoCompraVendaViewModel, ContratoCompraVenda>(contratoCompraVendaViewModel);


                _contratoCompraVendaService.InserirContratoCompraVenda(model);

           
                ModelState.Clear();
              
                return RedirectToAction("ListaContratos", "Contrato");

            }



            return RedirectToAction("ListaContratos", "Contrato");

        }



        public PartialViewResult ExibirJanelaProcessaContrato()
        {
            var teste = "ABC";
           var modelVM = new ContratoCompraVendaViewModel();

            var t = Task.Run(() => {

                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    // You can start any process, HelloWorld is a do-nothing example.
                    myProcess.StartInfo.FileName = "C:\\Program Files\\Pencil\\Pencil.exe";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                }
                catch (Exception ex)
                {
                }
            });



            return PartialView("_ProcessaContrato",modelVM);


        }




        public PartialViewResult ExibirJanelaEditaContrato(int id)
        {

            var modelVM = Mapper.Map<ContratoCompraVenda, ContratoCompraVendaViewModel>(_contratoCompraVendaService.BuscarContratoCompraVenda(id));


            return PartialView("_EditaContrato", modelVM);


        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [HandleError]
        public ActionResult AtualizarContrato(ContratoCompraVendaViewModel contratoCompraVendaViewModel, HttpPostedFileBase ArquivoSelecionado)
        {

            if (ModelState.IsValid)
            {

                if (ArquivoSelecionado != null)
                {
                    using (var binaryReader = new BinaryReader(ArquivoSelecionado.InputStream))
                    {
                        contratoCompraVendaViewModel.ConteudoArquivo = binaryReader.ReadBytes(ArquivoSelecionado.ContentLength);
                        contratoCompraVendaViewModel.Arquivo = ArquivoSelecionado.FileName;
                        contratoCompraVendaViewModel.TipoArquivo = ArquivoSelecionado.ContentType;
                    }

                }


                var model = Mapper.Map<ContratoCompraVendaViewModel, ContratoCompraVenda>(contratoCompraVendaViewModel);

                var contrato = _contratoCompraVendaService.BuscarContratoCompraVenda(contratoCompraVendaViewModel.Id);

                contrato.Ano = model.Ano;
                contrato.Arquivo = model.Arquivo;
                contrato.ConteudoArquivo = model.ConteudoArquivo;
                contrato.DuracaoMes = model.DuracaoMes;
                contrato.Id = model.Id;
                contrato.NomeCliente = model.NomeCliente;
                contrato.QtdeNegociada = model.QtdeNegociada;
                contrato.TipoContrato = model.TipoContrato;
                contrato.TipoArquivo = model.TipoArquivo;
                contrato.ValorNegociado = model.ValorNegociado;


                _contratoCompraVendaService.AtualizarContratoCompraVenda(contrato);

          

                return RedirectToAction("ListaContratos", "Contrato");

            }

            return RedirectToAction("ListaContratos", "Contrato");

        }
    }
}