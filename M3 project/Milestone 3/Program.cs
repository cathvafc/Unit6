using System;

namespace Milestone_3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Introduce how many fibonacci numbers do you want to calculate: ");

             int n = Convert.ToInt32(Console.ReadLine());

             Fibonacci(n);

            //int a, b, limite, i, auxiliar;
            //Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
            //limite = int.Parse(Console.ReadLine());
            //a = 0;
            //b = 1;
            //for (i = 0; i < limite; i++)
            //{
            //    auxiliar = a;
            //    a = b;
            //    b = auxiliar + a;
            //    Console.WriteLine(a);
            //}
        }

        public static void Fibonacci(int n)
        {
            int result = 0;
            int result1 = 1;
            int result2;

            int i = 0;

            while (i < n)
            { 
                result2 = result;
                result = result1 ;
                result1 = result + result2;
               

                Console.WriteLine("{0}", result);
                i++;
            }
        }
    }
}
