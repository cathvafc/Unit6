using System;

namespace M1_Project
{
    class Program
    {
        const int AÑOTRASPASO = 1948;
        
        static void Main(string[] args)
        {
            Fase1();

            Console.WriteLine("\n\n\n");

            Fase2CalculoAñoTraspaso();

            Console.WriteLine("\n\n\n");

            Fase3();
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

            string notALeapYear = " is not a Leap Year";
            string aLeapYear = " is  a Leap Year";


            for (int year = AÑOTRASPASO; year <= añoNacimiento;year++) // incluimos el 1996.
            {
                if (DateTime.IsLeapYear(year))
                {
                    cuantosAñosHay++;
                    Console.WriteLine("{0}" + aLeapYear, year);
                }
                else
                {
                    Console.WriteLine("{0}" + notALeapYear, year);
                }
            }
            Console.WriteLine("The total of leap years is: {0}",cuantosAñosHay );
        
        }
        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        public static void Fase3()
        {
            string nom = "Miguel Angel";
            string cognom1 = " Gómez";
            string cognom2 = " López";
            int dia = 30;
            int mes = 12;
            int any = 2020;
            int añoNacimiento = 1996;

            string fullName = "El meu nom es " + nom + cognom1 + cognom2;
            string fullDate = "Vaig néixer el " + dia + "/" + mes + "/" + any;
           
            string leapYear = "El meu any de naixement no és de traspàs";

            if (IsLeapYear(1996))
                leapYear = "El meu any de naixement és de traspàs";

            Console.WriteLine(fullName + "\n" + fullDate + "\n" + leapYear);
        }
    }
}
