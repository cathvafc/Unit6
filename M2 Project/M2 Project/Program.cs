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
            Dictionary<char, int> mapCharacters = new Dictionary<char, int>();

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

                    Fase3(character, ref mapCharacters);

                }
                else
                {
                    Console.WriteLine("Els noms de persones no contenen números!");
                }

            }

            foreach (KeyValuePair<char, int> character in mapCharacters)
            {
                Console.WriteLine("The char {0} appears {1} times on my name ", character.Key, character.Value);
            }

        }

        public static void Fase3 (char character, ref Dictionary<char, int> mapCharacters)
        {
            if (mapCharacters.ContainsKey(character))
            {
                mapCharacters[character] += 1;
            }
            else
            {
                mapCharacters.Add(character, 1);
            }
        }
    }
}
