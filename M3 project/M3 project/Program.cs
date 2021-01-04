using System;

namespace M3_project
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteMilestone1();
           
        }

        public static void ExecuteMilestone1()
        {
            string ciutat1 = "";
            string ciutat2 = "";
            string ciutat3 = "";
            string ciutat4 = "";
            string ciutat5 = "";
            string ciutat6 = "";
            string[] arrayCiutats = new string[6];
            string[] arrayCiutatsModificades = new string[6];
            

            Console.WriteLine("Introdueix el nom de 6 ciutats:");
            ciutat1 = Console.ReadLine();
            arrayCiutats[0] = ciutat1;
            ciutat2 = Console.ReadLine();
            arrayCiutats[1] = ciutat2;
            ciutat3 = Console.ReadLine();
            arrayCiutats[2] = ciutat3;
            ciutat4 = Console.ReadLine();
            arrayCiutats[3] = ciutat4;
            ciutat5 = Console.ReadLine();
            arrayCiutats[4] = ciutat5;
            ciutat6 = Console.ReadLine();
            arrayCiutats[5] = ciutat6;

            char[] ciutatArray1 = new char[ciutat1.Length];

            ciutatArray1 = ciutat1.ToCharArray(0, ciutat1.Length);
          
            char[] ciutatArray2 = new char[ciutat2.Length];

            ciutatArray2 = ciutat2.ToCharArray(0, ciutat2.Length);

            char[] ciutatArray3 = new char[ciutat3.Length];

            ciutatArray3 = ciutat3.ToCharArray(0, ciutat3.Length);

            char[] ciutatArray4 = new char[ciutat4.Length];

            ciutatArray4 = ciutat4.ToCharArray(0, ciutat4.Length);

            char[] ciutatArray5 = new char[ciutat5.Length];

            ciutatArray5 = ciutat5.ToCharArray(0, ciutat5.Length);

            char[] ciutatArray6 = new char[ciutat6.Length];

            ciutatArray6 = ciutat6.ToCharArray(0, ciutat6.Length);


            //Notas alumnos
            string[,] notasAlumnes = new string[5, 4];

            notasAlumnes[0,0] = "Pepito";
            notasAlumnes[0,1] = "1";
            notasAlumnes[0,2] = "2";
            notasAlumnes[0,3] = "3";
            notasAlumnes[1, 0] = "PepitoGrillo";
            notasAlumnes[1, 1] = "1";
            notasAlumnes[1, 2] = "2";
            notasAlumnes[1, 3] = "3";
            notasAlumnes[2, 0] = "PepitoGrillado";
            notasAlumnes[2, 1] = "1";
            notasAlumnes[2, 2] = "2";
            notasAlumnes[2, 3] = "3";
            notasAlumnes[3, 0] = "PepitoGrilladisimo";
            notasAlumnes[3, 1] = "1";
            notasAlumnes[3, 2] = "2";
            notasAlumnes[3, 3] = "3";
            notasAlumnes[4, 0] = "PepitoFrillo";
            notasAlumnes[4, 1] = "1";
            notasAlumnes[4, 2] = "2";
            notasAlumnes[4, 3] = "3";

            Comparison<string> comparador = new Comparison<string>((firstString, secondString) => firstString.CompareTo(secondString));
            Array.Sort(arrayCiutats, comparador);

            int i = 0;
            foreach (string cadena in arrayCiutats)
            {
               arrayCiutatsModificades[i] =  cadena.Replace('a', '4');
                i++;
            }
            Console.WriteLine("Les 6 ciutats ordenades alfabeticament son: {0}, {1}, {2}, {3}, {4} i {5}.", arrayCiutats[0], arrayCiutats[1], arrayCiutats[2], arrayCiutats[3], arrayCiutats[4], arrayCiutats[5]);
            Console.WriteLine("Les 6 ciutats ordenades alfabeticament son: {0}, {1}, {2}, {3}, {4} i {5}.", arrayCiutatsModificades[0], arrayCiutatsModificades[1], arrayCiutatsModificades[2], arrayCiutatsModificades[3], arrayCiutatsModificades[4], arrayCiutatsModificades[5]);


            PrintArrayReversed(ciutatArray1);
            PrintArrayReversed(ciutatArray2);
            PrintArrayReversed(ciutatArray3);
            PrintArrayReversed(ciutatArray4);
            PrintArrayReversed(ciutatArray5);
            PrintArrayReversed(ciutatArray6);

        }

        public static void PrintArrayReversed(char[] array)
        {
            Array.Reverse(array, 0, array.Length);

            foreach(char character in array)
            {
                Console.Write("{0}", character);
            }
            Console.Write("\n");
        }
    }
}
