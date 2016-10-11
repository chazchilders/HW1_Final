using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static int CMax(int[] xx)
        {
            int MyMax = 0;
            for(int i = 0, j = xx.Length; i <= j; i++)
            { int k = xx[i];
                if (k >= MyMax)
                    MyMax = k;
            }
            return MyMax;
        }
        static int Cmin(int[] yy)
        {
            int MyMin = 0;
            for (int i = 0, j = yy.Length; i <= j; i++)
            {
                int k = yy[i];
                if (k <= MyMin)
                    MyMin = k;
            }
            return MyMin;
        }
        static int CRange(int[] zz)
        {
            
            int MyMax = CMax(zz);
            int MyMin = Cmin(zz);
            int MyRange = MyMax - MyMin;
            return MyRange;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Let's check an array of your choosing!");
            Console.WriteLine("Please enter how many values will be in your array:");
            int arrsze = 0;
            string x = Console.ReadLine();
            int.TryParse(x, out arrsze);
            int[] test = new int[arrsze];
            for(int i = 0; i<= arrsze; i++)
            {
                int z = -123456789;
                do
                {
                    string y = Console.ReadLine();
                    int.TryParse(y, out z);
                } while (z == -123456789);
                test[i] = z;
            }
            Console.WriteLine("The MAX of your array is:");
            int MyMax = CMax(test);
            Console.WriteLine(MyMax);
            Console.WriteLine("The MIN of your array is:");
            int MyMin = Cmin(test);
            Console.WriteLine(MyMin);
            Console.WriteLine("And the RANGE of your array is:");
            int MyRange = CRange(test);
            Console.WriteLine(MyRange);
            Console.ReadLine();


        }
    }
}
