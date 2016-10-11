using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiple = 0;
            do
            {
                Console.WriteLine("Welcome! Please enter an integer below to create a multiplication table:");
                string x = Console.ReadLine();
                int.TryParse(x, out multiple);
            } while (multiple == 0);
            for(int i = 1; i<= multiple; i++)
            {
                for(int j = 1; j < multiple; j++)
                {
                    Console.Write(i*j + " ");
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
