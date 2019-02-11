using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAassignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool toRepeatProg = true;
            int menuSelection;
            int dimension1;
            int dimension2;
            int dimension3;
            string triangleType = "";

            Console.WriteLine("This program is for checking if it's possible to build triangle from entered dimensions values and checking the type of triangle\n");

            while (toRepeatProg == true)
            { 
                menuSelection = ValidateMenuSelection();

                switch (menuSelection)
                {
                    case 1:
                        Console.WriteLine("First dimension:");
                        dimension1 = ValidateDimensionInput();
                        Console.WriteLine("Second dimension:");
                        dimension2 = ValidateDimensionInput();
                        Console.WriteLine("Third dimension:");
                        dimension3 = ValidateDimensionInput();

                        triangleType = TriangleSolver.Analyze(dimension1, dimension2, dimension3);
                        Console.WriteLine(triangleType);
                        break;
                    case 2:
                        toRepeatProg = false;
                        break;
                }
            }

        }


        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("Please, select available task from menu bellow, by entering a number of menu item\n");
                Console.WriteLine("1 -> Enter triangle dimensions");
                Console.WriteLine("2 -> Exit");

                userInput = Console.ReadLine();

                if (userInput != "1" && userInput != "2")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Please, write correct number of menu item again\n");
                }
                else
                {
                    validMenuSelect = true;
                }

            }

            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateDimensionInput()
        {
            string userDimensionInput = "";
            bool validDimensionInput = false;
            int number = 1;

            while (validDimensionInput == false)
            {
                Console.WriteLine("Please, write the dimension of triangle (only integer): ");
                userDimensionInput = Console.ReadLine();

                bool result = int.TryParse(userDimensionInput, out number);

                if (result == false)
                {
                    Console.WriteLine("Sorry, incorrect input, try again\n");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Sorry, number should be more than 0\n");
                }
                else
                {
                    validDimensionInput = true;
                }
            }
            Console.WriteLine();
            return number;
        }
    }
}
