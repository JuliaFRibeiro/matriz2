using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //definindo o tamanho da matriz
            Console.WriteLine("Digite o número de linhas da matriz: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de colunas da matriz: ");
            int c = int.Parse(Console.ReadLine());
            int[,] mat = new int[l, c];

            //definindo os nuemros para matriz
            Console.WriteLine("Digite a linha da matriz: ");
            for (int i = 0; i < l; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int z = 0; z < c; z++)
                {
                    mat[i, z] = int.Parse(values[z]);
                }
            }
            Console.WriteLine("");
            //informar os numeros para ser digitados
            Console.WriteLine("Digite o valor a ser procurado: ");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //informar a posição e os valores 
            for (int i = 0; i < l; i++)
            {
                for (int z = 0; z < c; z++)
                {
                    if (mat[i, z] == v)
                    {
                        Console.WriteLine($"Posição: {i},{z}");
                        if (z + 1 < c && mat[i, z + 1] != 0)
                        {
                            Console.WriteLine($"Direita: {mat[i, z + 1]} ");
                        }
                        if (z - 1 >= 0 && mat[i, z - 1] != 0)
                        {
                            Console.WriteLine($"Esquerda: {mat[i, z - 1]} ");
                        }
                        if (i + 1 < l && mat[i + 1, z] != 0)
                        {
                            Console.WriteLine($"Baixo: {mat[i + 1, z]} ");
                        }
                        if (i - 1 >= 0 && mat[i - 1, z] != 0)
                        {
                            Console.WriteLine($"Cima: {mat[i - 1, z]} ");
                        }
                        Console.WriteLine("");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
