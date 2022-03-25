using System;

namespace Fibonacci
{
    class Program
    {
        /// <summary>
        /// F(n) = F(n-1) + F(n-2)
        /// n번째 피보나치 수 % 1234567 의 값을 구하여라
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(n);
        }

        public int solution(int n)
        {
            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;

            // 재귀보다 반복문이 빠름, 재귀는 depth가 한정적임
            for(int i = 2; i <= n; i++)
            {
                arr[i] = (arr[i - 1] + arr[i - 2])%1234567; // 자료형 범위 때문에 큰 수를 나눔
            }

            return arr[n];
        }

    }
}
