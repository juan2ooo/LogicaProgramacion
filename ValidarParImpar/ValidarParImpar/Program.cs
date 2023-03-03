using System;

namespace ValidarParImpar
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            Console.WriteLine("Programa para validar si un numero es par o impar");
            Console.WriteLine("--------------------------------------------------");
 

            Console.WriteLine("Ingrese un numero positivo");
            num1 = Convert.ToInt16(Console.ReadLine());

                
            if(num1 < 0) 
            {
                while(num1 < 0)
                    {
                        Console.WriteLine("Ha ingresado un numero negativo, porfavor ingrese uno positivo");
                        num1 = Convert.ToInt16(Console.ReadLine());
                    }
            }
            
            if(num1 % 2 == 0)
            {
                Console.WriteLine($"el numero {num1} es par");
            }
            else
            {
                Console.WriteLine($"El numero {num1} es impar");
            }
        }
    }
}
