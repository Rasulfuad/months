using System;

namespace ConsoleApp.switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthapril = 4;

            switch (monthapril)

            {
                case 12:
                case 1:
                case 2:



                    {
                        Console.WriteLine("qish");
                        break;
                    }

                    
                case 3:
                case 4:
                case 5:



                    {
                        Console.WriteLine("yaz");
                        break;
                    }

                    
                case 6:
                case 7:
                case 8:



                    {
                        Console.WriteLine("yay");
                        break;
                    }
                    
                case 9:
                case 10:
                case 11:



                    {
                        Console.WriteLine("payiz");
                        break;
                    }
                default:

                    {
                        Console.WriteLine("hec biri");
                        break;
                    }







            }
        }
    }
}
