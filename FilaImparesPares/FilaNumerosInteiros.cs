using FilaImparesPares;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaImparesPares
{
    internal class FilaNumerosInteiros
    {
        NumeroInteiro Calda;
        public FilaNumerosInteiros()
        {
            Calda = null;
        }

        public void Push(NumeroInteiro aux)
        {
            if (Vazia())
                Calda = aux;
            else
            {
                aux.SetAnterior(Calda);
                Calda = aux;
            }
        }
        bool Vazia()
        {
            if (Calda == null)
                return true;
            else
                return false;
        }
        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("\nFila vazia! Impossivel remover!");
                Console.WriteLine("Pressione qualquer tecla para continuar...\n\n");
                Console.ReadKey();
            }
            else
                Calda = Calda.GetAnterior();
        }

        public int Contador()
        {
            int quantidadeElementos = 0;
            NumeroInteiro aux = Calda;

            if (Vazia())
            {
                Console.WriteLine("\nFila vazia! Impossivel remover!");
                Console.WriteLine("Pressione qualquer tecla para continuuar...\n\n");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    aux = aux.GetAnterior();
                    quantidadeElementos++;
                } while (aux != null);
            }

            return quantidadeElementos;
        }

        public int GetMaior()
        {
            int numeroMaior = 0;
            NumeroInteiro aux = Calda;

            do
            {
                if (aux.GetNumero() > numeroMaior)
                {
                    numeroMaior = aux.GetNumero();
                }
                aux = aux.GetAnterior();
            } while (aux != null);

            return numeroMaior;
        }

        public int GetMenor()
        {
            int numeroMenor = 100;
            NumeroInteiro aux = Calda;

            do
            {
                if (aux.GetNumero() < numeroMenor)
                {
                    numeroMenor = aux.GetNumero();
                }
                aux = aux.GetAnterior();
            } while (aux != null);

            return numeroMenor;
        }

        public double GetMedia(int tamanho)
        {
            double media = 0;
            NumeroInteiro aux = Calda;

            do
            {
                media = media + aux.GetNumero();
                aux = aux.GetAnterior();
            } while (aux != null);

            media = media / tamanho;
            return media;
        }

        public void GetImpar(string nomeFila)
        {
            int contador = 0;
            NumeroInteiro aux = Calda;

            do
            {
                if (aux.GetNumero() % 2 != 0)
                {
                    Console.WriteLine("Numero impar: " + aux.GetNumero());
                    contador++;
                }
                aux = aux.GetAnterior();
            } while (aux != null);

            Console.WriteLine("A quantidade de numeros impares na " + nomeFila + " é: " + contador + "\n\n");
        }

        public void GetPar(string nomeFila)
        {
            int contador = 0;
            NumeroInteiro aux = Calda;

            do
            {
                if (aux.GetNumero() % 2 == 0)
                {
                    Console.WriteLine("Numero Par: " + aux.GetNumero());
                    contador++;
                }
                aux = aux.GetAnterior();
            } while (aux != null);

            Console.WriteLine("A quantidade de numeros pares na " + nomeFila + " é: " + contador + "\n\n");
        }
    }
}


