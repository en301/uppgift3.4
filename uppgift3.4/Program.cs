using System;
using System.Diagnostics.CodeAnalysis;

namespace uppgift_3_4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten svara i minuter för sig och sekunder för sig...");
            string längd = Console.ReadLine();
            
            int längdindex = längd.IndexOf(" ");
            int min = int.Parse(längd[..längdindex]);
            int sec = int.Parse(längd[längdindex..]);

            switch (min)
            {
                case 2:
                    if (sec >= 45)
                    {
                        Console.WriteLine("Låten får vara med");
                    }
                    else
                    {
                        Console.WriteLine("Låten får inte vara med");
                    }
                    break;
                case 3:
                    Console.WriteLine("Låten får vara med");
                    break; 
                case 4:
                    if (sec <= 20)
                    {
                        Console.WriteLine("Låten får vara med");
                    }
                    else
                    {
                        Console.WriteLine("Låten får inte vara med");
                    }    
                    break;
                default:
                    Console.WriteLine("Låten får inte vara med");
                        break; 
            }
            Console.ReadKey();

        }
    }
}
