using System;

namespace Milestone_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CreateLadder();
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
    }
}
