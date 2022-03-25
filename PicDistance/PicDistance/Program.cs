﻿using System;
using System.Linq;

namespace PicDistance
{
    /// <summary>
    /// 가을을 맞아 카카오프렌즈는 단체로 소풍을 떠났다. 
    /// 즐거운 시간을 보내고 마지막에 단체사진을 찍기 위해 카메라 앞에 일렬로 나란히 섰다. 
    /// 그런데 각자가 원하는 배치가 모두 달라 어떤 순서로 설지 정하는데 시간이 오래 걸렸다. 
    /// 네오는 프로도와 나란히 서기를 원했고, 튜브가 뿜은 불을 맞은 적이 있던 라이언은 튜브에게서 적어도 세 칸 이상 떨어져서 서기를 원했다. 
    /// 사진을 찍고 나서 돌아오는 길에, 무지는 모두가 원하는 조건을 만족하면서도 다르게 서는 방법이 있지 않았을까 생각해보게 되었다. 
    /// 각 프렌즈가 원하는 조건을 입력으로 받았을 때 모든 조건을 만족할 수 있도록 서는 경우의 수를 계산하는 프로그램을 작성해보자.
    /// 
    /// 입력은 조건의 개수를 나타내는 정수 n과 n개의 원소로 구성된 문자열 배열 data로 주어진다. 
    /// data의 원소는 각 프렌즈가 원하는 조건이 N~F=0과 같은 형태의 문자열로 구성되어 있다. 제한조건은 아래와 같다.
    /// 
    /// 1 <= n <= 100
    /// data의 원소는 다섯 글자로 구성된 문자열이다. 각 원소의 조건은 다음과 같다.
    /// 첫 번째 글자와 세 번째 글자는 다음 8개 중 하나이다. {A, C, F, J, M, N, R, T} 각각 어피치, 콘, 프로도, 제이지, 무지, 네오, 라이언, 튜브를 의미한다. 
    /// 첫 번째 글자는 조건을 제시한 프렌즈, 세 번째 글자는 상대방이다. 첫 번째 글자와 세 번째 글자는 항상 다르다.
    /// 두 번째 글자는 항상 ~이다.
    /// 네 번째 글자는 다음 3개 중 하나이다. {=, <, >} 각각 같음, 미만, 초과를 의미한다.
    /// 다섯 번째 글자는 0 이상 6 이하의 정수의 문자형이며, 조건에 제시되는 간격을 의미한다. 이때 간격은 두 프렌즈 사이에 있는 다른 프렌즈의 수이다.
    /// 
    /// 
    /// </summary>
    class Program
    {
        static int answer = 0;
        static void Main(string[] args)
        {
            string[] data = { "N~F=0", "R~T>2" };
            int n = 2;
            
            Console.WriteLine("answer = " + solution(n, data));
        }

        public static int solution(int n, string[] data)
        {
            answer = 0;
            char[] p = { 'A', 'C', 'F', 'J', 'M', 'N', 'R', 'T' };
            perm(0, p.Length, p, data, n);
            return answer;
        }

        public static void perm(int idx, int len, char[] arr, string[] data, int n)
        {
            if(idx == len - 1)
            {
                for(int i = 0; i < n; i++)
                {
                    char x = data[i][0];
                    char y = data[i][2];
                    char giho = data[i][3];
                    char num = data[i][4];

                    int xidx = Array.FindIndex(arr, e => e == x);
                    int yidx = Array.FindIndex(arr, e => e == y);

                    int diff = Math.Abs(xidx - yidx)-1;

                    if(giho == '=')
                    {
                        if (diff == int.Parse(num.ToString()))
                        {
                            if (i != n - 1)
                            {
                                continue;
                            }
                            answer++;
                        }
                        else
                        {
                            break;
                        }
                    } 
                    else if(giho == '>')
                    {
                        if (diff > int.Parse(num.ToString()))
                        {
                            if (i != n - 1)
                            {
                                continue;
                            }
                            answer++;
                        }
                        else
                        {
                            break;
                        }
                    } 
                    else if(giho == '<')
                    {
                        if (diff < int.Parse(num.ToString()))
                        {
                            if (i != n - 1)
                            {
                                continue;
                            }
                            answer++;
                        }
                        else
                        {
                            break;
                        }
                    }
                   
                }
                return;
            }

            for(int i = idx; i < len; i++)
            {
                swap(i, idx, arr);
                perm(idx + 1, len, arr, data, n);
                swap(i, idx, arr);
            }
        }

        public static void swap(int i, int j, char[] arr)
        {
            char tmp = arr[j];
            arr[j] = arr[i];
            arr[i] = tmp;
        }
    }
}
