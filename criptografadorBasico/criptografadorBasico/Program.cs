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
            Console.WriteLine("Criptografa: " + criptografa(100, 50, 10, 5));
            Console.WriteLine("Decriptografa: " + decriptografa(505, 50, 10, 5));

            Console.ReadKey();

        }

        static int criptografa(int valor, int chave1, int chave2, int chave3)
        {
            int numeroCriptografado;

            return numeroCriptografado = ((valor * chave1) / chave2) + chave3;
        }

        static int decriptografa(int valor, int chave1, int chave2, int chave3)
        {
            int numeroDecriptografado;

            return numeroDecriptografado = ((valor - chave3) * chave2) / chave1;
        }
    }
}
