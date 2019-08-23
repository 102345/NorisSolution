using System;
using System.Threading;
using System.Threading.Tasks;
using Topshelf;

namespace Noris.Contrato.WindowsService.Integration
{
    public sealed class GeradorDeContratos : ServiceControl
    {
        private readonly CancellationTokenSource _cancellationTokenSource;

        public GeradorDeContratos()
        {
            _cancellationTokenSource = new CancellationTokenSource();
        }

        public bool Start(HostControl hostControl)
        {
            Task.Run(() =>
            {
                //while (true)
                //{

                //    System.Console.WriteLine("Processamento da Rotina");
                //    Thread.Sleep(TimeSpan.FromSeconds(5));
                //}

                var contratoService = new Service.ContratoCompraVendaService();

                bool ret = contratoService.GravarContratosLiquidos();

                if (ret)
                {
                    System.Console.WriteLine("Processamento da carga de contratos liquido feito");
                }
                else
                {
                    System.Console.WriteLine("Problemas de geração de carga de contratos liquido");
                }
                
                this.Stop(hostControl);
               

            }, _cancellationTokenSource.Token);
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource.Dispose();
            return true;
        }
    }
}
