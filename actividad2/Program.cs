using System;

namespace actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("digite un numero para hacer un cuadra a partir de ese dato");
            num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
            }
        }
    }
}
