using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N=1;
            Random r = new Random();
            int mid = 0;
            int max = -1;
            Console.WriteLine("Введите размер матрицы");
            while (!int.TryParse(Console.ReadLine(), out N) || (N <= 0))
                Console.WriteLine("Введите натуральное число число больше 0");
            int[,] arr = new int[N, N];
            mid = N / 2;
            for (int i = 0; i < N ; i++)
                for (int j = 0; j < N ; j++)
                    arr[i, j] = r.Next();
            for (int i = 0; i < N ; i++)
                for (int j = 0; j < N ; j++)
                {
                    Console.Write(arr[i, j] + " ");
                    if (j == N - 1) Console.WriteLine();
                }
            Console.ReadLine();
            // поиск максимального элемента в области
            for (int i = 0; i < mid; i++)
                for (int j = i; j < N - i; j++)
                    if (arr[i, j] > max)
                        max = arr[i, j];
            for (int i = mid; i < N; i++)
                for (int j = N - 1 - i; j <= i; j++)
                    if (arr[i, j] > max)
                        max = arr[i, j];
            Console.WriteLine("Максимальный эл-т из области = " + max);
            Console.ReadLine();
        }
    }
}
