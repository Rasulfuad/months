using System;

namespace ConsoleApp1.months_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int months = 1; months <= 12; months++)


                switch (months)
                {
                    case 12:
                    case 1:
                    case 2:

                        {
                            Console.WriteLine("Qish");
                            break;
                        };



                    case 4:
                    case 5:
                    case 3:

                        {
                            Console.WriteLine("yazdir");
                            break;
                        };


                    case 7:
                    case 8:
                    case 6:




                        {
                            Console.WriteLine("yaydir");
                            break;
                        };

                    case 9:
                    case 10:
                    case 11:




                        {
                            Console.WriteLine("payizdir");
                            break;
                        };
                }
        }
    }
}