using System;
using System.Collections.Generic;

namespace WordToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "one4seveneight";
            
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("zero", 0);
            dic.Add("one", 1);
            dic.Add("two", 2);
            dic.Add("three", 3);
            dic.Add("four", 4);
            dic.Add("five", 5);
            dic.Add("six", 6);
            dic.Add("seven", 7);
            dic.Add("eight", 8);
            dic.Add("nine", 9);
            
            foreach (var d in dic.Keys)
            {
                int val = 0;
                bool res = dic.TryGetValue(d, out val);
                if (res)
                {
                    s = s.Replace(d, val.ToString());
                }

            }
            int result = int.Parse(s);
            Console.WriteLine(result);

        }
    }
}
