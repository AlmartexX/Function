using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
      class Program
    {
        public static void Sum(int firstValue,int secondValue)
        {
            int result = firstValue + secondValue;
            Console.WriteLine(result);
        }
        public static int Sub(int firstValue, int secondValue)
        {
           return firstValue - secondValue;   
        }

        public static double Multi(int firstValue, int secondValue)
        {
            return firstValue * secondValue;
        }
        static void Main()
        {
            Console.WriteLine($"Enter value :");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nresult:");
            Console.Write($"\nsum ---");
            Sum(firstValue, secondValue);
            Console.Write($"sub ---" + Sub( firstValue, secondValue));
            Console.Write($"\nmulti ---" + Multi(firstValue, secondValue));
            Console.ReadKey();

        }
    }
}
