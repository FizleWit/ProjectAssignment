using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAssignment
{
    class circle
    {
        double cRadius;
        double cArea;

        public circle()
        {
            Console.WriteLine("Circle Class Created");
        }

        void getRadius()
        {
            Console.WriteLine("What is the Radius of the Circle: ");
            cRadius = Int32.Parse(Console.ReadLine());
        }

       
        void calculateArea()
        {
            cArea = cRadius * cRadius * 3.14;
            Console.WriteLine("The Radius is " + cArea + " units in size.");
        }
        void displaycircle()
        {
            Console.WriteLine("THe circle present has a special area of " + cArea+
                " unites, this is only possible with a radius of " + cRadius+
                "but also using geometry we can deduce that the diameter of the circle is 2x the radisu meaning, the diameter is" + (2*cRadius)+
                " unites of length");
        }
        
        
    }
}
