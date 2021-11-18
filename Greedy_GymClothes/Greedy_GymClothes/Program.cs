using System;

namespace Greedy_GymClothes
{
    class Program
    {
        /// <summary>
        /// n명의 학생 중 lost학생들이 체육복을 분실했는데 여분의 체육복을 가지고 있는 reserve학생들이 있다.
        /// lost에는 분실한 학생의 번호가 담겨져있고, reserve는 여분의 체육복을 가지고 있는 학생들의 번호가 담겨져있다.
        /// lost와 reserve에는 중복 값은 없다. 
        /// 분실한 학생이 여분의 체육복을 가지고 있는 경우, 본인이 그 여분의 체육복을 가지게 되므로 다른 학생들에게 체육복을 빌려
        /// 줄 수 없다.
        /// 체육 수업을 들을 수 있는 학생의 최대값을 구하라.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int n = 5;
            int[] lost = { 2, 4 };
            int[] reserve = { 1, 3, 5 };
            Console.WriteLine($"n:5, lost:2,4, reserve:1,3,5, answer:{solution.solution(n,lost,reserve)}");

            n = 5;
            lost = new int[]{ 2, 4 };
            reserve = new int[]{ 3 };
            Console.WriteLine($"n:5, lost:2,4, reserve:3, answer:{solution.solution(n, lost, reserve)}");

            n = 3;
            lost = new int[] { 3 };
            reserve = new int[] { 1 };
            Console.WriteLine($"n:3, lost:3, reserve:1, answer:{solution.solution(n, lost, reserve)}");
        }

    }
}
