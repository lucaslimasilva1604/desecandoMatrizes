using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desecandoMatrizes
{
    internal class Program
    {
        public static void Letreiro()
        {
            Console.WriteLine("MENU DE OPÇÕES");
            Console.WriteLine("====================");
            Console.WriteLine("[1] Mostrar a Matriz");
            Console.WriteLine("[2] Diagonal Principal");
            Console.WriteLine("[3] Triângulo Superior");
            Console.WriteLine("[4] Triângulo Inferior");
            Console.WriteLine("[5] Sair");
            Console.WriteLine("===== OPCAO: ");
        }
        public static void Opcoes(int escolha, int[,] matriz)
        {
            Console.WriteLine();
            if (escolha == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(matriz[i, j] + "   ");
                    }
                    Console.WriteLine();
                }
            }
            else if (escolha == 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(matriz[i, j] + "   ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (escolha == 3)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (j > i)
                        {
                            Console.Write(matriz[i, j] + "  ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (escolha == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i > j)
                        {
                            Console.Write(matriz[i, j] + "   ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("ENCERRANDO...");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];

            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = j + 1;
                }
            }

            int escolha;

            do
            {
                Letreiro();
                escolha = int.Parse(Console.ReadLine());

                Console.Clear();
                Opcoes(escolha, matriz);
            } while (escolha < 5);

            Console.ReadKey();
        }
    }
}
