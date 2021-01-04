using System;

namespace Milestone_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularNotaMitjana();

        }

        public static void CalcularNotaMitjana()
        {
            //Notas alumnos
            int[,] notasAlumnes = new int[5, 3];

            int i = 0;

            while ( i < 5)
            {          
                Console.WriteLine("Introduce 3 marks of the student number {0}: ", i+1);
                notasAlumnes[i,0]= Convert.ToInt32(Console.ReadLine());
                notasAlumnes[i, 1] = Convert.ToInt32(Console.ReadLine());
                notasAlumnes[i, 2] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            i = 0;
            while ( i < 5)
            {

                double notaMitjana = (notasAlumnes[i, 0] + notasAlumnes[i, 1] + notasAlumnes[i, 2]) / 3;

                if (notaMitjana >= 5)
                {
                    Console.WriteLine("L'alumne número {0} amb nota mitja {1:R} ha APROBAT", i+1, notaMitjana);
                }
                else
                {
                    Console.WriteLine("L'alumne número {0} amb nota mitja {1:R} ha SUSPÈS", i + 1, notaMitjana);
                }

                i++;
            }
        }
    }
}
