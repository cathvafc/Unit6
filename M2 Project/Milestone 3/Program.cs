using System;
using System.Globalization;
using System.Threading;

namespace Milestone_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 0;
            int minutes = 0;
            int seconds = 0;
            bool firstLoop = true;

            while(true)
            {
                hour = DateTime.Now.Hour;
                minutes = DateTime.Now.Minute;
                seconds = DateTime.Now.Second;

                while (hour < 24)
                {
                    if(!firstLoop)
                    { 
                        minutes = 0;
                         
                     }
                while (minutes < 60)
                    {
                        if (!firstLoop)
                        {
                            seconds = 0;
                            
                        }
                            
                        while(seconds < 60)
                        {
                            Console.WriteLine("{0}:{1}:{2}", hour.ToString("D2"), minutes.ToString("D2"), seconds.ToString("D2"));
                            Thread.Sleep(1000);
                            seconds++;
                            firstLoop = false;
                        }
                        minutes++;
                    }

                    hour++;
                }

                Console.WriteLine("{0}:{1}:{2}", hour.ToString("D2"), minutes.ToString("D2"), seconds.ToString("D2"));
                Thread.Sleep(1000);

                //Sumar hora

            }
        }
    }
}
