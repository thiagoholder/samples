using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Castle.Core;

namespace LogMaster
{
    
    [Interceptor(typeof(Interceptador))]
    public class Chamado: IChamado
    {
        public void Assustar(int tempoAssustando)
        {
            Console.WriteLine($"Irei tentar lhe assustar por {tempoAssustando} segundos de sua vida");
            if (tempoAssustando < 5)
            {
                Thread.Sleep(1000 * tempoAssustando);
                TentativaDeSustoFrustada();
            }
            else
            {
                Thread.Sleep(1000 * tempoAssustando);
                Console.WriteLine("Hahahahahaha! Você não é corajoso o bastante para sobreviver ao meu susto. Durma com medo!!!!");
            }
        }

        private static void TentativaDeSustoFrustada()
        {
            throw new ArgumentException(@"Tentei te assustar, mas não conseguir! Você é corajoso");
        }

        public void Mensagem()
        {
            Console.WriteLine("Hahahahahahahahahaha Brincadeirinha");
        }
    }
}

