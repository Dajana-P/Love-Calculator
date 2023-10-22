using System;
using System.Threading;

namespace Love_Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rb = new Random();
            //Timer time = new Timer(TimerCallback, null, 0, 500);
            //int check = 0;
            Console.Title = "Love Calculator 1000";
            Boolean kraj = true;
            while(kraj)
            {
                Console.WriteLine("Ime prve osobe: ");
                String name1 = Console.ReadLine();
                Console.WriteLine("Ime druge osobe: ");
                String name2 = Console.ReadLine();
                //int vrv = rb.Next(0, 101);
                Console.WriteLine("Procenat ljubavi izmedju " + name1 + " i " + name2 + " je: " + rb.Next(0, 101) + "%");
                /*
                time.
                Console.Write(". ");
                Console.Write("\r. ");
                Console.Write("\r. ");
                Console.Write("\r. ");
                Console.Write("\r. ");
                */
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.Escape) kraj = false;
            }
        }
        /*private static void TimerCallback(Object o)
        {
            // Display the date/time when this method got called.
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
        }*/
    }
}
