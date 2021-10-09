using System;

namespace actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta = 0;
            while (conta < 1)
            {
                int pagoN = 0, horas=0, horasEx=0, pagoEx=0;
                Console.WriteLine("¿cuantas horas usted trabajo en esta semana?");
                horas = int.Parse(Console.ReadLine());
                if (horas <= 35)
                {
                    pagoN = horas * 15;
                    Console.WriteLine("su salario de está semana es {0}", pagoN);
                }
                else
                    if (horas > 35)
                {
                    pagoN = horas * 15;
                    horasEx = (horas - 35)*22;
                    pagoEx = pagoN + horasEx;
                    Console.WriteLine("su salario de está semana es {0}", pagoEx);
                    Console.WriteLine("obtuvo {0} dolares extras por trabajar mas de 35 horas", horasEx);
                }
                Console.WriteLine("si desea ingresar un nuevo empleado digite 0, sino 1 si desea terminar");
                conta = int.Parse(Console.ReadLine());
            }
        }
    }
}
