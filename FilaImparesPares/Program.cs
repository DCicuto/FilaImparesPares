using FilaImparesPares;
using PilhaImparesPares;
using System.Security.Cryptography;

namespace PilhaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaNumerosInteiros p1 = new FilaNumerosInteiros();
            FilaNumerosInteiros p2 = new FilaNumerosInteiros();
            int opcao = 0;

            do
            {
                
                Console.WriteLine(">>> Menu Principal - Fila de Números Inteiros <<<");
                Console.WriteLine("Escolha uma das opções:\n" +
                                  "1 - Adcionar numeros a f1;\n" +
                                  "2 - Adcionar numeros a f2;\n" +
                                  "3 - Testa se f1 e f2 possuem o mesmo tamanho;\n" +
                                  "4 - Para exibir o numero maior e menor e a media das filas;\n" +
                                  "5 - Para exibir Numeros Impares;\n" +
                                  "6 - Para exibir Numeros Pares;\n" +
                                  "7 - Trocar elementos de filha;\n" +
                                  "0 - Sair");

                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        p1.Push(AdcionarNumero());
                        break;
                    case 2:
                        p2.Push(AdcionarNumero());
                        break;
                    case 3:
                        CompararPilhas(p1, p2);
                        break;
                    case 4:
                        MostrarMedia(p1);
                        MostrarMedia(p2);
                        break;
                    case 5:
                        p1.GetImpar("fila 1");
                        p2.GetImpar("fila 2");
                        break;
                    case 6:
                        p1.GetPar("fila 1");
                        p2.GetPar("fila 2");
                        break;
                    case 0:
                        Console.WriteLine("Fim do Programa;");
                        break;
                    default:
                        Console.WriteLine("Opção inexistente!");
                        break;
                }
            } while (opcao != 0);
        }

        static NumeroInteiro AdcionarNumero()
        {
            int numero;
            Console.WriteLine("Informe um numero inteiro:");
            numero = int.Parse(Console.ReadLine());
            NumeroInteiro numeroInteiro = new NumeroInteiro(numero);
            return numeroInteiro;
        }

        static void CompararPilhas(FilaNumerosInteiros fila1, FilaNumerosInteiros fila2)
        {
            int numeros1 = fila1.Contador();
            int numeros2 = fila2.Contador();

            if (numeros1 == numeros2)
                Console.WriteLine($"F1 e F2 são iguais e possuem {numeros1} Números;\n\n");
            else if (numeros1 > numeros2)
                Console.WriteLine($"A F1 é maior que F2 e possuem {numeros1} números;\n\n");
            else
                Console.WriteLine($"A F2 é maior que F1 e possuem {numeros2} números;\n\n");
        }

        static void MostrarMedia(FilaNumerosInteiros fila)
        {
            if (fila.Contador() == 1)
            {
                Console.WriteLine("Por favor insira mais de um número da pilha");
                AdcionarNumero();
            }

            Console.WriteLine("O número maior é: " + fila.GetMaior());
            Console.WriteLine("O número menor é: " + fila.GetMenor());
            Console.WriteLine("A média de números é: " + fila.GetMedia(fila.Contador()) + "\n\n");
        }


    }
}