using System;
using System.Collections.Generic;

namespace Camouflage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] clothes = { { "yellowhat", "headgear" },
                { "bluesunglasses", "eyewear" },
                { "green_turban", "headgear" } };
            Console.WriteLine(solution(clothes));

        }

        public static int solution(string[,] clothes)
        {
            int answer = 1;
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            for(int i = 0; i < clothes.GetLength(0); i++)
            {
                if (!dic.ContainsKey(clothes[i, 1]))
                {
                    dic.Add(clothes[i, 1], new List<string>());
                }
                dic[clothes[i, 1]].Add(clothes[i, 0]);
            }

            foreach(var c in dic)
            {
                answer *= (c.Value.Count + 1); // 타입별로 없는 경우 까지 계산하기 위해 +1을 추가
            }
            return answer - 1; // 모두 안입는 경우는 없기 때문에 -1을 해줌
        }

    }
}
