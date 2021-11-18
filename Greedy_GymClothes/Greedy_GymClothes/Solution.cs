using System;
using System.Collections.Generic;
using System.Text;

namespace Greedy_GymClothes
{
    public class Solution
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;
            for (int i = 0; i < lost.Length; i++)
            {
                for (int j = 0; j < reserve.Length; j++)
                {
                    if (lost[i] == reserve[j])
                    {
                        lost[i] = -1;
                        reserve[j] = -1;
                        break;
                    }
                }
            }
            int cnt = 0;
            for (int i = 0; i < lost.Length; i++)
            {
                if (lost[i] == -1)
                {
                    cnt++;
                    continue;
                }

                for (int j = 0; j < reserve.Length; j++)
                {

                    if (lost[i] - 1 == reserve[j] || lost[i] + 1 == reserve[j])
                    {
                        reserve[j] = -1;
                        cnt++;
                        break;
                    }

                }


            }
            answer = n - lost.Length + cnt;
            return answer;
        }
    }
}
