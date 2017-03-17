using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace LogMaster
{
    public class ResolverDependencia
    {
        private static IWindsorContainer container;

        public static void Inicializar()
        {
            container = new WindsorContainer();
            container.Register(new ConfiguracaoDeComponentes());
        }

        public static T Para<T>()
        {
            return container.Resolve<T>();
        }
    }
}
