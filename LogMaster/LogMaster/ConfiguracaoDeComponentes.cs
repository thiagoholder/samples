using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;


namespace LogMaster
{
    public class ConfiguracaoDeComponentes : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(Component.For<Interceptador>().ImplementedBy<Interceptador>());
            kernel.Register(Component.For<IChamado>()
                .ImplementedBy<Chamado>());
        }
    }
}
