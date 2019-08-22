using Noris.Contrato.WindowsService.Integration;
using Topshelf;

namespace Noris.Contrato.WindowsService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostFactory.Run(configurator =>
            {
                configurator.Service<GeradorDeContratos>(s =>
                {
                    s.ConstructUsing(name => new GeradorDeContratos());
                    s.WhenStarted((service, control) => service.Start(control));
                    s.WhenStopped((service, control) => service.Stop(control));
                });
                configurator.RunAsLocalSystem();

                configurator.SetDescription("Exemplo de integração de chamada Window Service");
                configurator.SetDisplayName("Integração Contrato Energia");
                configurator.SetServiceName("IntegracaoContratoEnergia");
            });
        }
    }
    
}
