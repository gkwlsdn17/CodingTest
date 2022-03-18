using System;
using System.Collections.Generic;

namespace Declaration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] user = { "muzi", "frodo", "apeach", "neo"};
            string[] report = { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
            int k = 2;

            int[] answer = sol(user, report, 2);
            for(int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }
    }

        class map
        {
            public int cnt { get; set; }
            public List<string> er { get; set; }
            public int mail;
            public map()
            {
                cnt = 0;
                er = new List<string>();
                mail = 0;
            }

            public void print()
            {
                foreach(var e in er)
                {
                    Console.Write(e+",");
                }
            }

        }

        public static int[] sol(string[] id_list, string[] report, int k)
        {
            int[] answer = new int[id_list.Length];
            Dictionary<string, map> list = new Dictionary<string, map>();
            
            for (int i = 0; i < id_list.Length; i++)
            {
                map m = new map();
                list.Add(id_list[i], m);
            }

            for(int i = 0; i < report.Length; i++)
            {
                string[] tmp = report[i].Split(" ");
                string ed = tmp[1];
                string er = tmp[0];
                
                if (!list[ed].er.Contains(er))
                {
                    list[ed].cnt++;
                    list[ed].er.Add(er);
                }
            }

            int idx = 0;
            foreach(var val in list)
            {                
                if(val.Value.cnt >= k)
                {
                    foreach (var user in val.Value.er)
                    {
                        list[user].mail++;
                    }
                }
            }

            foreach(var v in list)
            {
                answer[idx++] = v.Value.mail;
            }

            return answer;
        }
    }
}
