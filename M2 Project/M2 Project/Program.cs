using System;

namespace M2_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] nombre = { 'M', 'I', 'G', 'U', 'E', 'L' };

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("{0}", nombre[i]);
            }
        }
    }
}
