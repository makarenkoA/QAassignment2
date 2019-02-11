using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QAassignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            string result = "";

            if (side1 >= (side2 + side3) || side2 >= (side1 + side3) || side3 >= (side1 + side2))
            {
                result = "Triangle with " + side1 + ", " + side2 + ", " + side3 + " sides can not be built\n";
            }
            else if (side1 == side2 && side2 == side3)
            {
                result = "Triangle with " + side1 + ", " + side2 + ", " + side3 + " sides is equilateral\n";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                result = "Triangle with " + side1 + ", " + side2 + ", " + side3 + " sides is isosceles\n";
            }
            else
            {
                result = "Triangle with " + side1 + ", " + side2 + ", " + side3 + " sides is scalene\n";
            }

            return result;
        }
    }
}
