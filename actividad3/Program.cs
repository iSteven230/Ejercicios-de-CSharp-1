using System;

namespace actividad3
{
    class Program
    {
        static void Main(string[] args)
        {   
            int Cvendida;
            double precio, total=0;
            Console.WriteLine("introduzca la cantidad vendida");
            Cvendida = int.Parse(Console.ReadLine());
            if (Cvendida > 0)
            {
                Console.WriteLine("introduzca el precio");
                precio = double.Parse(Console.ReadLine());
                total = Cvendida * precio;
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine("se termina porque no hay cantidad");
            }  
        }
    }
}
