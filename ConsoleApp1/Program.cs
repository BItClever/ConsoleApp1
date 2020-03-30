using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int cl = 3;
            int st = 4;
            int[,] array = new int[cl, st];
            Random rand = new Random();

            for (int i = 0; i < cl; i++)
            {
                for (int j = 0; j < st; j++)
                {
                    array[i, j] = rand.Next(0, 100);
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            int[,] tr = new int[st, cl];
            for (int i = 0; i < st; i++)
            {
                for (int j = 0; j < cl; j++)
                {
                    tr[i, j] = array[j, i];
                    Console.Write(tr[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
