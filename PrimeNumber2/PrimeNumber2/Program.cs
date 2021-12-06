using System;
using System.Collections.Generic;

namespace PrimeNumber2
{
    class Program
    {
        public static List<int> primeNumList;
        static void Main(string[] args)
        {
            string numbers = "17";
            Console.WriteLine(solution(numbers));
            //Console.WriteLine(primeNumList.Count);
            numbers = "011";
            Console.WriteLine(solution(numbers));
            //Perm(numbers.ToCharArray(),0);
        }

        public static int solution(string numbers)
        {
            primeNumList= new List<int>();
            char[] s  = numbers.ToCharArray();
            Perm(s, 0);
            return primeNumList.Count;
        }

        private static bool CheckPrimeNumber(int num)
        {
            if (num <= 1) return false;
            
            for(int i=2; i*i <= num; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        private static void swap(char[] list, int i, int j)
        {
            char tmp = list[i];
            list[i] = list[j];
            list[j] = tmp;
        }

        private static void Perm(char[] a, int k)
        {
            if (k == a.Length - 1)//순열을 출력
            {
                string s = "";
                for (int i = 0; i < a.Length; i++)
                {
                    s += a[i].ToString();
                    int num = int.Parse(s);
                    Console.WriteLine(num);
                    bool check = CheckPrimeNumber(num);
                    if (check)
                    {
                        if (!primeNumList.Contains(num))
                            primeNumList.Add(num);
                    }
                }
                

            }
            else
            {
                for (int i = k; i < a.Length; i++)
                {
                    //a[k]와 a[i]를 교환
                    swap(a, i, k);
                    Perm(a, k + 1); //a[k+1],…,a[n-1]에 대한 모든 순열
                    //원래 상태로 되돌리기 위해 a[k]와 a[i]를 다시 교환
                    swap(a, k, i);
                }
            }
        }

    }

}
