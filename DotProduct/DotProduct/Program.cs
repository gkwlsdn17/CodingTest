using System;

namespace DotProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("내적");
            int[] num1 = { 1, 2, 3, 4 };
            int[] num2 = { -3, -1, 0, 2 };
            Console.WriteLine(dotProduct(num1, num2));
        }

        public static int dotProduct(int[] a, int[] b)
        {
            int sum = 0;
            for(int i=0; i<a.Length; i++)
            {
                sum += a[i] * b[i];
            }
            return sum;
        }
    }
}
