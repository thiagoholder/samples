using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResolverDependencia.Inicializar();
            var assustar = ResolverDependencia.Para<IChamado>();
            Console.WriteLine("Qual o tamanho de sua coragem?");
            var coragem = Convert.ToInt32(Console.ReadLine());
            assustar.Assustar(coragem);
            assustar.Mensagem();
            Console.ReadKey();
        }
    }
}
