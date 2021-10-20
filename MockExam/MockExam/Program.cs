using System;
using System.Collections.Generic;
using System.Linq;

namespace MockExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 3, 2, 4, 2, 5,3,1 };
            foreach (var item in solution(arr1))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===========");
            foreach (var item in solution(arr2))
            {
                Console.WriteLine(item);
            }
        }

        public static int[] solution(int[] answers)
        {
            int[] answer = new int[] { };
            int[] p1 = { 1, 2, 3, 4, 5 };
            int[] p2 = { 1, 3, 4, 5 };
            int[] p3 = { 3, 1, 2, 4, 5 };
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("1", 0);
            dic.Add("2", 0);
            dic.Add("3", 0);
            int even = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (p1[i%p1.Length] == answers[i]) dic["1"]++;
                
                if ((i + 1) % 2 == 0)
                {
                    if (answers[i] == p2[even % 4]) dic["2"]++;
                    even++;
                }
                else
                {
                    if (answers[i] == 2) dic["2"]++;
                }
                
                if (p3[(i / 2)%p3.Length] == answers[i]) dic["3"]++;
            }
            
            var val = (from x in dic
                       where dic.Values.Max() == x.Value
                       orderby x.Key ascending
                       select int.Parse(x.Key)).ToArray();
            answer = val;

            return answer;

        }
    }
}
