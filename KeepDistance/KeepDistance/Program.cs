using System;
using System.Collections.Generic;
using System.Linq;
namespace KeepDistance
{
    /// <summary>
    /// 개발자를 희망하는 죠르디가 카카오에 면접을 보러 왔습니다.

    ///코로나 바이러스 감염 예방을 위해 응시자들은 거리를 둬서 대기를 해야하는데 개발 직군 면접인 만큼
    ///아래와 같은 규칙으로 대기실에 거리를 두고 앉도록 안내하고 있습니다.

    ///대기실은 5개이며, 각 대기실은 5x5 크기입니다.
    ///거리두기를 위하여 응시자들 끼리는 맨해튼 거리1가 2 이하로 앉지 말아 주세요.
    ///단 응시자가 앉아있는 자리 사이가 파티션으로 막혀 있을 경우에는 허용합니다.
    ///
    /// 
    /// places의 행 길이(대기실 개수) = 5
    /// places의 각 행은 하나의 대기실 구조를 나타냅니다.
    /// places의 열 길이(대기실 세로 길이) = 5
    /// places의 원소는 P,O,X로 이루어진 문자열입니다.
    /// places 원소의 길이(대기실 가로 길이) = 5
    /// P는 응시자가 앉아있는 자리를 의미합니다.
    /// O는 빈 테이블을 의미합니다.
    /// X는 파티션을 의미합니다.
    /// 입력으로 주어지는 5개 대기실의 크기는 모두 5x5 입니다.
    /// return 값 형식
    /// 1차원 정수 배열에 5개의 원소를 담아서 return 합니다.
    /// places에 담겨 있는 5개 대기실의 순서대로, 거리두기 준수 여부를 차례대로 배열에 담습니다.
    /// 각 대기실 별로 모든 응시자가 거리두기를 지키고 있으면 1을, 한 명이라도 지키지 않고 있으면 0을 담습니다.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = {
                { "POOOP", "OXXOX", "OPXPX", "OOXOX", "POXXP" },
                { "POOPX", "OXPXP", "PXXXO", "OXXXO", "OOOPP" }, 
                { "PXOPX", "OXOXP", "OXPOX", "OXXOP", "PXPOX" },
                { "OOOXX", "XOOOX", "OOOXX", "OXOOX", "OOOOO" },
                { "PXPXP", "XPXPX", "PXPXP", "XPXPX", "PXPXP" }
            };
            int[] ans = solution(array);
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static int[] solution(string[,] places)
        {
            int[] answer = new int[5];
            int row = places.GetLength(0);
            int col = places.GetLength(1);
            for (int i = 0; i < row; i++){
                string[,] s = new string[5,5];
                for(int j = 0; j < col; j++)
                {
                    char[] cArray = places[i, j].ToCharArray();
                    int cnt = 0;
                    foreach (var c in cArray)
                    {
                        s[j, cnt] = c.ToString();
                        cnt++;
                    }
                }
                bool check = true;
                for(int si = 0; si < 5; si++)
                {
                    for(int sj = 0; sj < 5; sj++)
                    {
                        if (s[si,sj] == "P")
                        {
                            try
                            {
                                if (s[si - 1, sj] == "P")
                                {
                                    check = false;
                                    break;
                                }
                                else if(s[si - 1, sj] == "O")
                                {
                                    if (sj != 0 && s[si - 1, sj - 1] == "P")
                                    {
                                        check = false; break;
                                    }

                                    if(sj != 4 && s[si - 1, sj + 1] == "P")
                                    {
                                        check = false; break;
                                    }

                                    if (s[si - 2, sj] == "P") 
                                    { 
                                        check = false; break; 
                                    }
                                }

                                
                            }
                            catch { }

                            try
                            {
                                if (s[si + 1, sj] == "P")
                                {
                                    check = false; break;
                                }
                                else if (s[si + 1, sj] == "O")
                                {
                                    if(sj!=0 && s[si+1,sj-1] == "P")
                                    {
                                        check = false; break;
                                    }
                                    if(sj!=4 && s[si + 1, sj + 1] == "P")
                                    {
                                        check = false; break;
                                    }

                                    if (s[si + 2, sj] == "P") 
                                    { 
                                        check = false; break; 
                                    }
                                }
                                
                            }
                            catch { }

                            if(sj!=0 && s[si,sj-1] == "P")
                            {
                                check = false; break;
                            } 
                            else if(sj != 0 && s[si, sj - 1] == "O")
                            {
                                if(si!=0 && s[si-1,sj-1] == "P")
                                {
                                    check = false; break;
                                }

                                if(si!=4 && s[si + 1, sj - 1] == "P")
                                {
                                    check = false; break;
                                }

                                if (sj - 2 > -1 && s[si, sj - 2] == "P")
                                {
                                    check = false; break;
                                }
                            }

                            if(sj!=4 && s[si,sj+1] == "P")
                            {
                                check = false; break;
                            }
                            else if(sj != 4 && s[si, sj + 1] == "O")
                            {
                                if(si!=0 && s[si-1,sj+1] == "P")
                                {
                                    check = false; break;
                                }
                                    
                                if(si!=4 && s[si+1,sj+1] == "P")
                                {
                                    check = false; break;
                                }

                                if (sj + 2 < 5 && s[si, sj + 2] == "P")
                                {
                                    check = false; break;
                                }
                            }


                        }
                    }
                    if (!check) break;
                }
                if (check) answer[i] = 1;
                else answer[i] = 0;
            }
            return answer;
        }
    }
}
