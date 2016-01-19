using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spel
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("\nWelcome, press enter to continue.");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

            Console.WriteLine("\nhej");


            Console.WriteLine("\nVälj karaktär...\n1. Don Quijote\n2. Sanchez");
            int svar1 = int.Parse(Console.ReadLine());


                if (svar1 == 11)
                {

                    Console.WriteLine("\nDu valde Don Quijote");

                }
                else if (svar1 == 22)
                {

                    Console.WriteLine("\nDu valde Sanchez");

                }
         

                Console.ReadKey();



            }
        }
    }

