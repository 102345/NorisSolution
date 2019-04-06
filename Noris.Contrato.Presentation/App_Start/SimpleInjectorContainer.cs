using Noris.Contrato.Service;
using Noris.Contrato.Service.Interface;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Lifestyles;
using System.Web.Mvc;

namespace Noris.Contrato.Presentation.App_Start
{
    public static class SimpleInjectorContainer
    {
        public static void RegisterServices()
        {

            var container = new Container();
            //container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();


            container.Register<IContratoCompraVendaService, ContratoCompraVendaService>(Lifestyle.Transient);

            container.Verify();

            DependencyResolver.SetResolver(
                    new SimpleInjectorDependencyResolver(container));


        }
    }
}