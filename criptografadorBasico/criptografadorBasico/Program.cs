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
            Formula f = new Formula();

            Console.WriteLine("Criptografa: " + f.criptografa(284, 50, 10, 5));
            Console.WriteLine("Decriptografa: " + f.decriptografa(1425, 50, 10, 5));

            Console.ReadKey();

        }
    }
}
