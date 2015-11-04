using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criptografadorBasico
{
    class Formula
    {

        private int valor;
        private int chave1;
        private int chave2;
        private int chave3;

        public void setValor(int valor)
        {
            this.valor = valor;
        }
        public int getValor()
        {
            return valor;
        }

        public void setChave1(int chave1)
        {
            this.chave1 = chave1;
        }

        public int getChave1()
        {
            return chave1;
        }

        public void setChave2(int chave2)
        {
            this.chave2 = chave2;
        }

        public int getChave2()
        {
            return chave2;
        }

        public void setChave3(int chave3)
        {
            this.chave3 = chave3;
        }

        public int getChave3()
        {
            return chave3;
        }

        public int criptografa(int valor, int chave1, int chave2, int chave3)
        {
            int numeroCriptografado;

            return numeroCriptografado = ((valor * chave1) / chave2) + chave3;
        }

        public int decriptografa(int valor, int chave1, int chave2, int chave3)
        {
            int numeroDecriptografado;

            return numeroDecriptografado = ((valor - chave3) * chave2) / chave1;
        }
    }
}
