using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStaments
{
    class Program
    {
        static void Main(string[] args)
        {
            // build a program for a small shop
            // the program will have a menu, and it will ask theh user for selection

            //show the menu
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please select an option");
            Console.WriteLine ("1. Coke");
            Console.WriteLine("2. Water");
            Console.WriteLine("3. Kit Kat");
            Console.WriteLine("4. M&Ms");



            // input
            int selection = int.Parse(Console.ReadLine());

            
            //switch statement

            switch(selection)
            {
                case 1: // if(selection ==1) if we write the same thiing in if/else statement

                    //Console.WriteLine(" Make a selection");
                    //Console.WriteLine("1. 12 OZ");
                    //Console.WriteLine("1. 16 OZ");
                    //int sizeofthecoke = int.Parse(Console.ReadLine());

                  Console.WriteLine("Coke is good! Here you go!");
                    break;
                case 2:
                    Console.WriteLine("healthy option! Water is good!");
                    break;
                case 3:
                    Console.WriteLine("Enjoy your kit kat!");
                    break;
                case 4:
                    Console.WriteLine("Good choice!");
                    break;

                default: // for invalid input

                    Console.Beep();
                    Console.WriteLine("Wrong selection!");
                    break;
            }
            Console.ReadLine();


        }
    }
}
