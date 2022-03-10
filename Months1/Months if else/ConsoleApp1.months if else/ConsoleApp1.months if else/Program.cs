using System;

namespace ConsoleApp1.months_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthOctober = 10;

            if (monthOctober > 1 && monthOctober < 3) 

            { Console.WriteLine("qishdir");

            }
                else if (monthOctober > 3 && monthOctober < 6 || monthOctober <= 4) 

            { Console.WriteLine("yaz feslidir"); 
            
            }

              else if (monthOctober > 8 || monthOctober == 9 || monthOctober < 12) 
            {
                Console.WriteLine("payizdir");
                    
                    }
            else
            {
                Console.WriteLine("yay feslidir");
                    }






        }
    }
}
