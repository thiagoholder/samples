using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace LogMaster
{
    public class Interceptador: IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var nomeDoMetodo = invocation.Method.Name;
            try
            {
                Console.WriteLine(
                    $"Entrando no método:{nomeDoMetodo}, com os Argumentos: {string.Join(",", invocation.Arguments)}");
                invocation.Proceed();
                Console.WriteLine($"O método {nomeDoMetodo} foi executado com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine($"O método {nomeDoMetodo}, gerou a exceção {e.Message}");
                Console.WriteLine($"O método {nomeDoMetodo} não foi executado com sucesso");

            }
            finally
            {
                Console.WriteLine($"Saindo do método {nomeDoMetodo}");
            }
        }
    }
}
