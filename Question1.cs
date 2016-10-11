using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the area of a rectangle!");
            Console.WriteLine("Please enter the length of side 1 below:");
            int side1 = 0;
            do
            {
                string x = Console.ReadLine();
                int.TryParse(x, out side1);
            } while(side1 == 0);
            Console.WriteLine("Please enter the length of side 2 below:");
            int side2 = 0;
            do
            {
                string x = Console.ReadLine();
                int.TryParse(x, out side2);
            } while (side2 == 0);
            int area = side1 * side2;
            Console.WriteLine("The area of your rectangle is: " + area);
            Console.ReadLine();
        }
    }
}
