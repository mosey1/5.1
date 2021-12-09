using System;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите размерновсть массива n:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] mas = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("введите элемент массива mas[{0}]: ", i);
                    mas[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (mas[j] > mas[j + 1])
                        {
                            int tmp = mas[j];
                            mas[j] = mas[j + 1];
                            mas[j + 1] = tmp;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("элемент массива mas[{0}]={1}", i, mas[i]);
                }
                Console.ReadLine();

            }
        }
    }
}
