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
        }
    }
}
