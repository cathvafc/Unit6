using System;
using System.Collections.Generic;
using System.Text;

namespace M2_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Fase2();
        }

        public static void Fase2()
        {
            List<char> nombre = new List<char>();

            nombre.Add('M');
            nombre.Add('I');
            nombre.Add('G');
            nombre.Add('U');
            nombre.Add('E');
            nombre.Add('L');


            foreach (char character in nombre)
            {
                if (char.IsLetter(character))
                {

                    if (character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')
                    {
                        Console.WriteLine("VOCAL");
                    }
                    else
                    {
                        Console.WriteLine("CONSONANT");
                    }
                }
                else
                {
                    Console.WriteLine("Els noms de persones no contenen números!");
                }
            }
        }
    }
}
