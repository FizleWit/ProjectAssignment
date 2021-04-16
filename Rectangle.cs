using System;
using System.Collections.Generic;
using System.Text;


namespace ProjectAssignment
{
    class Rectangle
    {
        public double rlengthDistance;
        public double rwidthDistance;
        public double rArea;

        public Rectangle()
        {
            Console.WriteLine("Rectangle Created Created");
            dowork();
        }
        void getlengthDistance()
        {

            Console.WriteLine("please enter the length of the Rectangle: ");
            rlengthDistance = Int32.Parse(Console.ReadLine());
        }
        void getWidthDistance()
        {
            Console.WriteLine("please enter the length of the Rectangle: ");
            rwidthDistance = Int32.Parse(Console.ReadLine());
        }
        void getArea()
        {
            rArea = rlengthDistance * rwidthDistance;
        }

        void displayRectangle()
        {
            Console.WriteLine("The rectangle you have created has a unique area of "+ this.rArea+ " unites this is only possible with the width being  " +
                rwidthDistance+" unites and a length of  " +
                rlengthDistance+" unites");
        }
        void dowork()
        {
            getlengthDistance();
            getWidthDistance();
            getArea();
            displayRectangle();
        }

    }

}
