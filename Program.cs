using System;
using System.Collections;

namespace ProjectAssignment
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string choice = "0"; //using for holding value
            Console.WriteLine("Welcome to the machine that calculates basic shapes area!/nJust type the number of the shape you want to calculate and we will be good to go");

        begin:
            Console.WriteLine("" +
                "1.Rectangle\n2.Circle\n3.Square");

            choice = Console.ReadLine();
            if (choice == "1")
            {

                Square square1 = new Square();
            }
            else if (choice == "2")
            {
                circle circle1 = new circle();
            }
            else if (choice == "3")
            {
                Rectangle rectangle1 = new Rectangle();
            }
            else
            {
                Console.WriteLine("That is not a real answer to the situation you were given, shame on you.");
            }
            Console.WriteLine("Would you like to make another imaginary shape(y/n)");
            choice = Console.ReadLine();
            if (choice == "Y" || choice == "y")
                goto begin;
            else
            {
                Console.WriteLine("I hope you had fun making shapes");

            }

        }
    }
}
