using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaImparesPares
{
    internal class NumeroInteiro
    {
        int Numero;
        NumeroInteiro Proximo;

        public NumeroInteiro(int numero)
        {
            this.Numero = numero;
            this.Proximo = null;
        }

        public void SetAnterior(NumeroInteiro numeroInteiro)
        {
            Proximo = numeroInteiro;
        }

        public NumeroInteiro GetAnterior()
        {
            return Proximo;
        }

        public int GetNumero()
        {
            return Numero;
        }


    }
}
