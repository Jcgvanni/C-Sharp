using System;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
namespace TortoiseandHare
{
    class Program
    {
        private static int tortoise = 1;
        private static int hare = 1;
        private static int finishLine = 70;
        private static int startLine = 1;
        static void Main(string[] args)
        {
            race();
            
        }
        //Race method
        static void race()
        {
            Console.WriteLine("ON YOUR MARK,\n GET SET,\n AND YHEY'RE OFF!!!!!");
            Console.WriteLine();
            while (tortoise < finishLine && hare < finishLine)
            {
                TortoiseMove();
                HareMove();
                PrintRace();
            
            }
            // Slows down race           
            for (int slowdown = 0; slowdown < 100000; slowdown++) ;           


            if (tortoise == hare)
            {
                Console.WriteLine("\n It’s a TIE!");
            }

            else if (tortoise > hare)
            {
                Console.WriteLine("\n TORTOISE WINS!!! YAY!!!");
            }

            else if (hare > tortoise)
            {
                Console.WriteLine("\n Hare Wins.");
            }
            Stopwatch stopWatch = new Stopwatch();            
            TimeSpan ts = stopWatch.Elapsed;          
            Console.WriteLine("TIME ELAPSED = " + Convert.ToInt32(ts.TotalSeconds) + " SECONDS");
        }//end of race()

        //method to move the tortoise
        static void TortoiseMove()
        {
            //generates random number 1 thru 10 to use for variable move
            Random randomNumbers = new Random();
            int move = randomNumbers.Next(1, 11) % 10;
           
            //fast plod            
            if (move >= 1 && move <= 5)
            {
                tortoise += 3;
            }
            //slow plod            
            else if (move >= 6 && move <= 8)
            {
                ++tortoise;
            }
            //slip           
            else if (move == 9 || move == 10)
            {
                tortoise -= 6;
            }
           
            if (tortoise < startLine)
            {
                tortoise = startLine;
            }
            else if (tortoise > finishLine)
            {
                tortoise = finishLine;
            }
        }//end of tortoise

        //method to move hare
        static void HareMove()
        {            
            Random randomNumbers = new Random();
            int move = randomNumbers.Next(1, 11) % 10;
            
            //sleep
            if (move == 1 || move == 2)
            {
                hare += 0;
            }
            //big hop            
            else if (move == 3 || move == 4)
            {
                hare += 9;
            }
            //big slip            
            else if (move == 5)
            {
                hare -= 12;
            }
            //small hop           
            else if (move >= 5 && move <= 8)
            {
                ++hare;
            }
            //small slip
            else if (move == 9 || move == 10)
            {
                hare -= 2;
            }

           
            if (hare < startLine)
            {
                hare = startLine;
            }           
            else if (hare > finishLine)
            {
                hare = finishLine;
            }
        }//end of hare

        //method to print the race
       static void PrintRace()
       {           
            for (int print = 1; print <= finishLine; ++print)
            {
                
                if (print == tortoise && print == hare)
                {
                    Console.Write("OUCH!!!");
                }               
                else if (print == tortoise)
                {
                    Console.Write("T");
                }               
                else if (print == hare)
                {
                    Console.Write("H");
                }                
                else
                {
                    Console.Write(" ");
                }
            }
       }//end of printrace
    }
}
