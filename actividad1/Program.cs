using System;

namespace actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
                int numeros, conta = 0, num, numM = 0;
                Console.WriteLine("Digite cuantos numero desea ingresar: ");
                numeros = int.Parse(Console.ReadLine());
                while (conta < numeros)
                {
                    conta++;
                    Console.WriteLine("{0} digite un numero", conta);
                    num = int.Parse(Console.ReadLine());
                    if (num > numM)
                    {
                        numM = num;
                    }
                }
                Console.WriteLine("el numero mayor es: {0}", numM);
            }
    }
}
