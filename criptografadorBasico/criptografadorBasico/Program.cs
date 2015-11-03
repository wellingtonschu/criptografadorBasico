using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criptografadorBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criptografa: " + criptografa(31682, 24983));
            Console.WriteLine("Decriptografa: " + decriptografa(791511406, 24983));

            Console.ReadKey();

        }

        static int criptografa(int valor, int chave)
        {
            int numeroCriptografado;

            return numeroCriptografado = valor * chave;
        }

        static int decriptografa(int valor, int chave)
        {
            int numeroDecriptografado;

            return numeroDecriptografado = valor / chave;
        }
    }
}
