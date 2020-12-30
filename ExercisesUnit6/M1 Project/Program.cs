using System;

namespace M1_Project
{
    class Program
    {
        const int AÑOTRASPASO = 1948;
        
        static void Main(string[] args)
        {
            //Fase1();

            Fase2CalculoAñoTraspaso();
        }

        public static void Fase1()
        {
            string nom = "Miguel Angel";
            string cognom1 = " Gómez";
            string cognom2 = " López";
            int dia = 30;
            int mes = 12;
            int any = 2020;

            Console.WriteLine(nom + cognom1 + cognom2);
            Console.WriteLine(dia + "/" + mes + "/" + any);
        }

        public static void Fase2CalculoAñoTraspaso()
        {
            int añoNacimiento = 1996;
            int cadaCuanto = 4;
            int cuantosAñosHay = 0;
     
            for (int year = AÑOTRASPASO; year <= añoNacimiento;year++) // incluimos el 1996.
            {
                if (DateTime.IsLeapYear(year))
                {
                    cuantosAñosHay++;
                }
            }

            Console.WriteLine("Entre el {0} y {1} hay {2} años de traspaso.", añoNacimiento, AÑOTRASPASO, cuantosAñosHay);

           
        }
    }
}
