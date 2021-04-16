using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAssignment
{
    class Square
    {
        double sSideLength;
        double sArea;

        public Square()
        {
            Console.WriteLine("Square Class Created");
            dowork();
        }
        void getSide()
        {
            Console.WriteLine("What is the side length of your square: ");
            sSideLength =  Int32.Parse(Console.ReadLine());
        }
        void calcualteArea()
        {
            sArea = sSideLength * sSideLength;
        }
        void displaySquare()
        {
            Console.WriteLine("This Marvelous Square has 4 equal sides and 4 right angles. \n" +
                "Truely a unique shape because of this it is my 3rd favorite shape \n"+
                "This square in particular has a side length of " +sSideLength+ " units\n" +
                "and because the area is side length squared this shapes area is a superb" + sArea+ " units large \n");
        }
        void dowork()
        {
            getSide();
            calcualteArea();
            displaySquare();
        }
    }
}
