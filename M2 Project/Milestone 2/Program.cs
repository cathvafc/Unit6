using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CreateLadder();

            CreatePyramid();
        }

        public static void CreateLadder()
        {
            Console.WriteLine("Introduce the height of the ladder: ");

            int height = Convert.ToInt32(Console.ReadLine());

            int j =0;

            for (int i = 0; i <= height; i++)
            {
                j = 0;

                while( j < i)
                {
                    Console.Write("{0}", j+1);
                    j++;
                }
                Console.Write("\n");
            }
        }

        public static void CreatePyramid()
        {

        inicio:
            Console.WriteLine("Introduce the height of the pyramid: ");
            try
            {
                int nivel = int.Parse(Console.ReadLine());

                if (nivel != 0)
                {

                    int a;
                    int espacios;
                    for (int i = 1; i <= nivel; i++)
                    {
                        StringBuilder final = new StringBuilder();

                        espacios = nivel - i;
                        a = i + (i - 1);
                        for (int i1 = nivel; i1 > espacios; i1--)
                            final.Append(" ");

                        for (int i2 = (nivel * 2); i2 > a; i2--)
                            final.Append("*");

                        Console.WriteLine(final.ToString());

                    }
                }
                else
                {
                    System.Console.Clear();
                    goto inicio;
                }

            }
            catch (Exception)
            {
                System.Console.Clear();
                Console.WriteLine("Please, use only integer numbers");
                goto inicio;

            }
        }
    }
        
}
